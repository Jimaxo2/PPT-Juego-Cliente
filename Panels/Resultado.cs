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
    public partial class Resultado : UserControl
    {
        public Resultado()
        {
            InitializeComponent();
        }
        public void SetDatosResultado(
    string nombreJugadorLocal,
    string nombre1, string jugada1,
    string nombre2, string jugada2)
        {
            // Determinar qué lado es “Tú”
            if (nombreJugadorLocal == nombre1)
            {
                lblNombreIzq.Text = $"{nombre1} (Tú)";
                lblNombreDer.Text = nombre2;

                pictureIzq.Image = GetImagen(jugada1);
                pictureDer.Image = GetImagen(jugada2);
            }
            else
            {
                lblNombreIzq.Text = $"{nombre2} (Tú)";
                lblNombreDer.Text = nombre1;

                pictureIzq.Image = GetImagen(jugada2);
                pictureDer.Image = GetImagen(jugada1);
            }
        }
        private Image GetImagen(string jugada)
        {
            switch (jugada.ToUpper())
            {
                case "PIEDRA": return Properties.Resources.Piedra;
                case "PAPEL": return Properties.Resources.Papel;
                case "TIJERA": return Properties.Resources.Tijera;
            }
            return null;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
