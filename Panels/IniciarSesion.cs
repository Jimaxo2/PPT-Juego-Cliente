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
        public IniciarSesion(TcpClient client, NetworkStream stram)
        {
            InitializeComponent();
            this.client = client;
            this.stream = stram;
        }

        private void BtnIniciarSesion_Click(object sender, EventArgs e)
        {
            // Validaciones básicas
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

            string usuario = TbNombreJugador.Text;
            string contrasena = TbContraseñaJugador.Text;

            // CREAR MENSAJE PARA EL SERVIDOR
            string mensaje =
                "IniciarSesion\n" +
                $"{usuario}|{contrasena}\n";

            // ENVIAR AL SERVIDOR
            byte[] dataOut = Encoding.UTF8.GetBytes(mensaje);
            stream.Write(dataOut, 0, dataOut.Length);

            // ESPERAR RESPUESTA DEL SERVIDOR
            byte[] buffer = new byte[1024];
            int bytes = stream.Read(buffer, 0, buffer.Length);
            string respuesta = Encoding.UTF8.GetString(buffer, 0, bytes).Trim();

            // PROCESAR RESPUESTA
            if (respuesta.StartsWith("Error"))
            {
                // EJEMPLO: "Error|Credenciales incorrectas"
                string[] partes = respuesta.Split('|');
                MessageBox.Show(partes.Length > 1 ? partes[1] : respuesta);
                return;
            }

            // LOGIN CORRECTO
            // respuesta = "Javier|Password12" (por ejemplo)
            string[] datos = respuesta.Split('|');

            string nombreJugador = datos[1];
            string passJugador = datos[0];

            MessageBox.Show("Sesión iniciada correctamente: " + nombreJugador);

            // Aquí ya puedes cambiar de ventana / cargar menú principal
        }

        private void BtnCrearCuenta_Click(object sender, EventArgs e)
        {
            // Abrir el formulario de creación de cuenta.
            CrearCuenta CrearCuenta = new CrearCuenta(stream);
            CrearCuenta.ShowDialog();
        }
    }
}
