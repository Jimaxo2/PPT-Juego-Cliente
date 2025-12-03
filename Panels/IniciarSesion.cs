using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPT_Juego_Cliente.Panels
{
    public partial class IniciarSesion : UserControl
    {
        TcpClient client;
        NetworkStream stream;

        // --- CONSTRUCTOR ---
        // Recibe la conexión que ya se creó en el Form1 para poder usarla aquí.
        public IniciarSesion(TcpClient client, NetworkStream stram)
        {
            InitializeComponent();
            this.client = client;
            this.stream = stram;
        }

        // --- BOTÓN INICIAR SESIÓN ---
        // Envía tu usuario y contraseña al servidor para validar.
        // Es ASÍNCRONO (async/await) para no congelar la pantalla mientras espera respuesta del servidor.
        private async void BtnIniciarSesion_Click(object sender, EventArgs e)
        {
            // 1. Validaciones: Revisa que las cajas de texto no estén vacías.
            if (string.IsNullOrWhiteSpace(TbNombreJugador.Text))
            {
                MessageBox.Show("Por favor, ingrese nombre de Jugador.");
                return;
            }
            if (string.IsNullOrWhiteSpace(TbContraseñaJugador.Text))
            {
                MessageBox.Show("Por favor, ingrese contraseña.");
                return;
            }

            // 2. Feedback Visual: Ponemos cursor de carga y desactivamos botón para que el usuario sepa que está trabajando.
            BtnIniciarSesion.Enabled = false;
            this.Cursor = Cursors.WaitCursor;

            try
            {
                string usuario = TbNombreJugador.Text;
                string contrasena = TbContraseñaJugador.Text;

                // 3. Preparar Mensaje: Armamos el protocolo que entiende el servidor.
                string mensaje = "IniciarSesion\n" + $"{usuario}|{contrasena}\n";
                byte[] dataOut = Encoding.UTF8.GetBytes(mensaje);

                // 4. Enviar Datos: Usamos 'await' para enviar sin detener el programa principal.
                await stream.WriteAsync(dataOut, 0, dataOut.Length);

                byte[] buffer = new byte[1024];

                // 5. Esperar Respuesta: Aquí el programa espera los datos del servidor PERO la ventana sigue respondiendo (no se congela).
                int bytes = await stream.ReadAsync(buffer, 0, buffer.Length);

                string respuesta = Encoding.UTF8.GetString(buffer, 0, bytes).Trim();

                // 6. Restaurar Interfaz: Ya contestó el servidor, devolvemos el cursor a la normalidad.
                this.Cursor = Cursors.Default;
                BtnIniciarSesion.Enabled = true;

                // 7. Verificar Errores: Si el servidor dice "Error", mostramos el mensaje y paramos.
                if (respuesta.StartsWith("Error"))
                {
                    string[] partes = respuesta.Split('|');
                    MessageBox.Show(partes.Length > 1 ? partes[1] : respuesta);
                    return;
                }

                // 8. Login Exitoso: Procesamos los datos recibidos.
                string[] datos = respuesta.Split('|');
                string nombreJugador = datos[1].Trim();

                MessageBox.Show("Sesión iniciada correctamente: " + nombreJugador);

                // Buscamos el formulario padre (Form1) para guardar los datos ahí.
                Form1 formPrincipal = this.ParentForm as Form1;

                if (formPrincipal != null)
                {
                    formPrincipal.NombreUsuario = nombreJugador;

                    // IMPORTANTE: Guardamos la contraseña en la memoria para poder usarla en la reconexión de "Nueva Partida".
                    formPrincipal.ContraseniaUsuario = contrasena;

                    // Cambiamos de pantalla al menú principal.
                    formPrincipal.MostrarMenu();
                }
            }
            catch (Exception ex)
            {
                // Si falla la conexión, aseguramos que el cursor vuelva a la normalidad antes de mostrar el error.
                this.Cursor = Cursors.Default;
                BtnIniciarSesion.Enabled = true;
                MessageBox.Show("Error de conexión: " + ex.Message);
            }
        }

        // --- BOTÓN CREAR CUENTA ---
        // Abre una ventana secundaria para registrar un nuevo usuario.
        private void BtnCrearCuenta_Click(object sender, EventArgs e)
        {
            CrearCuenta CrearCuenta = new CrearCuenta(stream);
            CrearCuenta.ShowDialog(); // ShowDialog hace que no puedas tocar la ventana de atrás hasta cerrar esta.
        }
    }
}