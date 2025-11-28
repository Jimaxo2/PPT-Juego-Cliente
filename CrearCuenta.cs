using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPT_Juego_Cliente
{
    public partial class CrearCuenta : Form
    {
        public CrearCuenta()
        {
            InitializeComponent();

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
        }
    }
}
