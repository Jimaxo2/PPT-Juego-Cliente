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
            // Asignar tags según la jugada
            pbPiedra.Tag = "Piedra";
            pbPapel.Tag = "Papel";
            pbTijera.Tag = "Tijera";

            // Asignar eventos sin modificar designer
            pbPiedra.Click += SeleccionarOpcion;
            pbPapel.Click += SeleccionarOpcion;
            pbTijera.Click += SeleccionarOpcion;

            btnConfirmar.Click += BtnConfirmar_Click;

            lblEstadoEleccion.Text = "Selecciona tu jugada";
        }

        private void SeleccionarOpcion(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            if (pb == null) return;

            // Quitar selección previa
            pbPiedra.BorderStyle = BorderStyle.None;
            pbPapel.BorderStyle = BorderStyle.None;
            pbTijera.BorderStyle = BorderStyle.None;

            // Marcar el nuevo seleccionado
            pb.BorderStyle = BorderStyle.Fixed3D;

            // Guardar la elección
            eleccionJugador = pb.Tag.ToString();

            lblEstadoEleccion.Text = $"Elegiste: {eleccionJugador}";
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            if (eleccionJugador == null)
            {
                MessageBox.Show("Selecciona una opción antes de confirmar.");
                return;
            }

            // Enviar al formulario que contiene este panel
            EleccionConfirmada?.Invoke(eleccionJugador);

            // Opcional: deshabilitar para evitar doble clic
            btnConfirmar.Enabled = false;
        }
    }
}

    