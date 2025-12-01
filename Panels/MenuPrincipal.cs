using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPT_Juego_Cliente.Panels
{
    public partial class MenuPrincipal : UserControl
    {
        public MenuPrincipal()
        {
            InitializeComponent();

            // labels: lbNombreJugador, lbPartidasJugadas, lbPartidasGanadas, lbPartidasPerdidas, lbPartidasEmpatadas, lbTasaVictoria
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnNuevaPartida_Click(object sender, EventArgs e)
        {
            // Abrir panel de nueva partida
        }
    }
}
