using System;
using System.Drawing;
using System.Windows.Forms;

namespace PPT_Juego_Cliente.Panels
{
    public partial class PanelEleccion : UserControl
    {
        private string eleccionJugador = null;

        public event Action<string> EleccionConfirmada; // Para comunicar al formulario principal

        public PanelEleccion()
        {
            InitializeComponent();
            InicializarEventosEleccion();
        }

        private void InicializarEventosEleccion()
        {
      
            pbPiedra.Click -= SeleccionarOpcion;
            pbPapel.Click -= SeleccionarOpcion;
            pbTijera.Click -= SeleccionarOpcion;
            btnConfirmar.Click -= BtnConfirmar_Click;

            pbPiedra.Tag = "Piedra";
            pbPapel.Tag = "Papel";
            pbTijera.Tag = "Tijera";

            pbPiedra.Click += SeleccionarOpcion;
            pbPapel.Click += SeleccionarOpcion;
            pbTijera.Click += SeleccionarOpcion;

            btnConfirmar.Click += BtnConfirmar_Click;

            eleccionJugador = null;
            btnConfirmar.Enabled = false;
            lblEstadoEleccion.Text = "Selecciona tu jugada";
        }

        private void SeleccionarOpcion(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            if (pb == null || pb.Tag == null)
            {
                MessageBox.Show("ERROR: Opción sin jugada asignada.");
                return;
            }

            pbPiedra.BorderStyle = BorderStyle.None;
            pbPapel.BorderStyle = BorderStyle.None;
            pbTijera.BorderStyle = BorderStyle.None;

            pb.BorderStyle = BorderStyle.Fixed3D;

            eleccionJugador = pb.Tag.ToString();
            lblEstadoEleccion.Text = $"Elegiste: {eleccionJugador}";

            btnConfirmar.Enabled = true;
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(eleccionJugador))
            {
                MessageBox.Show("Selecciona una opción antes de confirmar.");
                return;
            }

            EleccionConfirmada?.Invoke(eleccionJugador);

            btnConfirmar.Enabled = false;
        }


        private void lblEstadoEleccion_Click(object sender, EventArgs e)
        {

        }
    }
}

    