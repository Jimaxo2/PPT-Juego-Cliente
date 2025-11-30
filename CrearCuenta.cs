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

namespace PPT_Juego_Cliente
{
    public partial class CrearCuenta : Form
    {
        NetworkStream stream;
        public CrearCuenta(NetworkStream stream)
        {
            InitializeComponent();

            this.stream = stream;

            // Cambios de texto para actualizar el label.
            TbContraseñaJugador.TextChanged += PasswordFields_TextChanged;
            TbConfirmarContraseña.TextChanged += PasswordFields_TextChanged;

            // Asegurar estado inicial correcto
            UpdateCoincidenciasLabel();
        }

        private void PasswordFields_TextChanged(object? sender, EventArgs e)
        {
            UpdateCoincidenciasLabel();
        }

        private void UpdateCoincidenciasLabel()
        {
            // Si alguno está vacío, o si coinciden, vaciar texto.
            if ((string.IsNullOrEmpty(TbContraseñaJugador.Text) &&
                string.IsNullOrEmpty(TbConfirmarContraseña.Text))||
                TbContraseñaJugador.Text == TbConfirmarContraseña.Text)
            {
                lbCoincidencias.Text = string.Empty;
                return;
            }

            // Si no coinciden.
            lbCoincidencias.Text = "¡ Las contraseñas no coinciden !";
        }

        private void BtnIniciarSesion_Click(object sender, EventArgs e)
        {
            // Verificar nombre de usuario.
            if (TbContraseñaJugador.Text == "")
            {
                MessageBox.Show("Por favor, ingrese su nombre de Jugador.");
                return;
            }

            // Verificar la contraseña.
            if (TbNombreJugador.Text == "")
            {
                MessageBox.Show("Por favor, ingrese su contraseña.");
                return;
            }
            if (TbContraseñaJugador.Text != TbConfirmarContraseña.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden.");
                return;
            }

            // Aquí crear la cuenta en el servidor. :)
            string usuario = TbNombreJugador.Text;
            string contrasena = TbContraseñaJugador.Text;

            // CREAR MENSAJE PARA EL SERVIDOR
            string mensaje =
                "CrearCuenta\n" +
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

            string nombreJugador = datos[0];

            MessageBox.Show("La cuenta se creo exitosamente: " + nombreJugador);

            this.Close();
        }
    }
}
