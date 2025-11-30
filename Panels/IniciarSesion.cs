using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPT_Juego_Cliente.Panels
{
    public partial class IniciarSesion : UserControl
    {
        public IniciarSesion()
        {
            InitializeComponent();
        }

        private void BtnIniciarSesion_Click(object sender, EventArgs e)
        {
            // Verificar que no esté vacío el nombre de usuario y la contraseña.
            if (TbNombreJugador.Text == "")
            {
                MessageBox.Show("Por favor, ingrese nombre de Jugador.");
                return;
            }
            if (TbContraseñaJugador.Text == "")
            {
                MessageBox.Show("Por favor, ingrese contraseña.");
                return;
            }

            // Verificar si el nombre de usuario y la contraseña están en nuestro servidor.
        }

        private void BtnCrearCuenta_Click(object sender, EventArgs e)
        {
            // Abrir el formulario de creación de cuenta.
            CrearCuenta CrearCuenta = new CrearCuenta();
            CrearCuenta.ShowDialog();
        }
    }
}
