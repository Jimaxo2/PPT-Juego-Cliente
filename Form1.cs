using PPT_Juego_Cliente.Models;
using PPT_Juego_Cliente.Panels;
using System;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPT_Juego_Cliente
{
    public partial class Form1 : Form
    {
        // Variables para manejar la conexión y los hilos
        private Thread hiloEscucha;
        private bool conectado = true;
        TcpClient client;
        NetworkStream stream;

        // Bandera para saber si la desconexión fue por error o porque terminó la partida
        private bool requiereReconexion = false;

        // Datos del usuario actual para poder reconectar automáticamente
        public string NombreUsuario = "";
        public string ContraseniaUsuario = "";
        private bool esPrimeraPartida = true;

        public Jugador JugadorActual { get; set; }

        public Form1()
        {
            InitializeComponent();

            // Desactiva la comprobación de errores de hilos cruzados 
            // (Permite modificar la UI desde hilos secundarios sin que crashee, aunque no es la mejor práctica, funciona aquí)
            CheckForIllegalCrossThreadCalls = false;

            // --- 1. CONEXIÓN INICIAL ---
            // Intentamos conectar al servidor (localhost puerto 5000) al abrir el programa
            client = new TcpClient("127.0.0.1", 5000);
            stream = client.GetStream();

            if (client.Connected)
            {
                MessageBox.Show("Conectado al servidor.");
            }

            // --- 2. PREPARAR INTERFAZ ---
            // Limpiamos cualquier panel que hubiera
            pDisplay.Controls.Clear();

            // Creamos el panel de "Iniciar Sesión" y le pasamos la conexión
            IniciarSesion Login = new IniciarSesion(client, stream);

            // Configuramos para que ocupe toda la ventana
            Login.Dock = DockStyle.Fill;

            // Lo mostramos en pantalla
            pDisplay.Controls.Add(Login);

            this.Text = "Inicio de Sesion";
        }

        // --- MÉTODO: CAMBIAR PANEL ---
        // Este método es el "controlador de navegación". Quita la pantalla actual y pone una nueva.
        public void CambiarPanel(UserControl nuevoPanel)
        {
            pDisplay.Controls.Clear();          // Borra lo que haya (ej. Login)
            nuevoPanel.Dock = DockStyle.Fill;   // Expande el nuevo panel
            pDisplay.Controls.Add(nuevoPanel);  // Lo agrega a la ventana
        }

        // --- MÉTODO: INICIAR JUEGO ---
        // Se llama desde el Menú Principal al dar "Nueva Partida".
        // Maneja la reconexión al servidor si acabamos de terminar una partida anterior.
        public void IniciarJuego()
        {
            // Creamos un hilo para no congelar la ventana mientras conecta
            Thread hiloArranque = new Thread(() =>
            {
                try
                {
                    if (esPrimeraPartida)
                    {
                        // Si es la primera vez, ya estamos conectados desde el Login
                        esPrimeraPartida = false;
                        conectado = true;
                    }
                    else
                    {
                        // --- LÓGICA DE RECONEXIÓN ---
                        // Si venimos de terminar una partida, la conexión vieja está cerrada.

                        // 1. Cerramos cualquier residuo anterior
                        if (client != null) client.Close();

                        Thread.Sleep(500); // Esperamos un poco para seguridad

                        // 2. Creamos una NUEVA conexión al puerto 5000
                        client = new TcpClient("127.0.0.1", 5000);
                        stream = client.GetStream();
                        conectado = true;

                        // 3. AUTO-LOGIN: Enviamos usuario y contraseña automáticamente
                        // Así el servidor sabe quiénes somos sin pedir loguearnos de nuevo
                        string msgLogin = "IniciarSesion\n" + $"{NombreUsuario}|{ContraseniaUsuario}\n";
                        byte[] data = Encoding.UTF8.GetBytes(msgLogin);
                        stream.Write(data, 0, data.Length);

                        // 4. Leemos la respuesta del login (para vaciar el buffer)
                        byte[] temp = new byte[1024];
                        stream.Read(temp, 0, temp.Length);
                    }

                    // --- ACTUALIZAR UI ---
                    // Usamos Invoke porque estamos en un hilo secundario
                    this.Invoke(new Action(() =>
                    {
                        CambiarPanel(new EsperaConfirmacion()); // Mostramos pantalla de carga
                        this.Text = "Buscando oponente...";
                    }));

                    // --- INICIAR ESCUCHA ---
                    // Arrancamos el hilo que se quedará esperando mensajes del servidor (Jugadas, Resultados, etc.)
                    hiloEscucha = new Thread(EscucharServidor);
                    hiloEscucha.IsBackground = true;
                    hiloEscucha.Start();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al iniciar la partida: " + ex.Message);
                }
            });

            hiloArranque.IsBackground = true;
            hiloArranque.Start();
        }

        // --- MÉTODO: ESCUCHAR SERVIDOR ---
        // Bucle infinito que lee todo lo que llega por el cable de red.
        private void EscucharServidor()
        {
            byte[] buffer = new byte[1024];
            while (conectado)
            {
                try
                {
                    // Si no hay datos, esperamos un poco para no saturar el CPU
                    if (!stream.DataAvailable)
                    {
                        Thread.Sleep(100);
                        continue;
                    }

                    // Leemos los bytes que llegaron
                    int bytes = stream.Read(buffer, 0, buffer.Length);

                    // Si recibimos 0 bytes, significa que el servidor cortó la conexión
                    if (bytes == 0)
                    {
                        break;
                    }

                    // Convertimos bytes a texto y lo mandamos procesar
                    string mensaje = Encoding.UTF8.GetString(buffer, 0, bytes);
                    ProcesarComando(mensaje);
                }
                catch
                {
                    // Si ocurre un error (cable desconectado, server apagado, etc.)
                    conectado = false;

                    // Solo mostramos error si NO estábamos esperando desconectarnos
                    // (requiereReconexion es true cuando termina la partida normalmente)
                    if (!requiereReconexion)
                    {
                        MessageBox.Show("Desconectado del servidor.");
                    }
                }
            }
        }

        // --- MÉTODO: PROCESAR COMANDO ---
        // El cerebro del cliente. Recibe "Orden|Datos" y decide qué hacer.
        private void ProcesarComando(string mensaje)
        {
            // Separamos por saltos de línea por si llegaron varios mensajes juntos
            string[] lineas = mensaje.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string linea in lineas)
            {
                string[] partes = linea.Split('|');
                string comando = partes[0];
                string argumento = partes.Length > 1 ? partes[1] : "";

                // Usamos Invoke para modificar la pantalla (UI) de forma segura
                this.Invoke(new Action(() =>
                {
                    switch (comando)
                    {
                        // EL SERVIDOR PIDE QUE JUEGUES
                        case "PedirJugada":
                            PanelEleccion panelJuego = new PanelEleccion();
                            // Nos suscribimos al evento: cuando el usuario elija, se ejecuta EnviarJugada
                            panelJuego.EleccionConfirmada += EnviarJugada;
                            CambiarPanel(panelJuego);
                            this.Text = "¡Tu turno!";
                            break;

                        // EL SERVIDOR MANDA EL NOMBRE Y LA ELECCION DE CADA JUGADOR
                        case "ResultadoCompleto":
                            {
                                // argumento: "Nombre1,Jugada1,Nombre2,Jugada2"
                                string[] datos = argumento.Split(',');

                                if (datos.Length < 4)
                                {
                                    MessageBox.Show("ERROR: Datos incompletos del servidor.");
                                    break;
                                }

                                string nombre1 = datos[0].Trim();
                                string jugada1 = datos[1].Trim();
                                string nombre2 = datos[2].Trim();
                                string jugada2 = datos[3].Trim();

                                Resultado panelResultado = new Resultado();
                                panelResultado.SetDatosResultado(
                                    NombreUsuario,
                                    nombre1, jugada1,
                                    nombre2, jugada2
                                );

                                CambiarPanel(panelResultado);
                                this.Text = "Resultados del Juego";
                                break;
                            }
                        // EL SERVIDOR MANDA QUIÉN GANÓ
                        case "Ganador":
                                    {
                                        string resultadoRaw = argumento.Trim();
                                        string resultadoMayus = resultadoRaw.ToUpper();

                                        // 1. Mostrar panel según resultado
                                        if (resultadoMayus.Contains("EMPATE"))
                                        {
                                            CambiarPanel(new Empate());
                                        }
                                        else if (resultadoMayus.StartsWith("GANADOR"))
                                        {
                                            string nombreGanador = resultadoRaw;
                                            int idx = nombreGanador.IndexOf(':');
                                            if (idx >= 0)
                                                nombreGanador = nombreGanador.Substring(idx + 1).Trim();

                                            if (string.Equals(nombreGanador, NombreUsuario?.Trim(), StringComparison.OrdinalIgnoreCase))
                                            {
                                                CambiarPanel(new Ganador());
                                            }
                                            else
                                            {
                                                CambiarPanel(new Perdedor());
                                            }
                                        }
                                        else
                                        {
                                            CambiarPanel(new Resultado());
                                        }

                                        // 2. FINALIZAR CONEXIÓN Y REGRESAR AL MENÚ
                                        requiereReconexion = true;

                                        Task.Run(() =>
                                        {
                                            Thread.Sleep(4000); // ver pantalla resultado final

                                            this.Invoke(() =>
                                            {
                                                try
                                                {
                                                    conectado = false;
                                                    stream?.Close();
                                                    client?.Close();
                                                }
                                                catch { }

                                                MostrarMenu();
                                            });
                                        });
                                        break;
                                    }



                                // EL SERVIDOR MANDA UN MENSAJE DE TEXTO (ej. "Esperando rival")
                                case "Mensaje":
                            this.Text = argumento;
                            break;
                    }
                }));
            }
        }

        // --- MÉTODO: ENVIAR JUGADA ---
        // Se ejecuta cuando haces clic en Piedra, Papel o Tijera.
        private void EnviarJugada(string jugada)
        {
            try
            {
                // Convertimos el texto (ej. "Piedra") a bytes y lo enviamos
                byte[] msg = Encoding.UTF8.GetBytes(jugada + "\n");
                stream.Write(msg, 0, msg.Length);

                // Cambiamos pantalla a "Espera" para que no puedas jugar dos veces
                CambiarPanel(new EsperaConfirmacion());
                this.Text = "Esperando al rival...";
            }
            catch
            {
                MessageBox.Show("Error enviando jugada");
            }
        }

        // --- MÉTODO: MOSTRAR MENÚ ---
        // ACTUALIZADO: Ahora carga los datos del jugador en el menú
        public void MostrarMenu()
        {
            MenuPrincipal menu = new MenuPrincipal();

            // NUEVO: Cargamos los datos del jugador en el menú
            if (JugadorActual != null)
            {
                menu.CargarDatosJugador(JugadorActual);
            }

            CambiarPanel(menu);
            this.Text = "Menu Principal - " + NombreUsuario;
        }
    }
}