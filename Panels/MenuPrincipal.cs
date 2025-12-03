using PPT_Juego_Cliente.Models;
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
    public partial class MenuPrincipal : UserControl
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        public void CargarDatosJugador(Jugador jugador)
        {   
            if (jugador != null)
            {
                // Mostrar nombre del jugador
                lbNombreJugador.Text = jugador.NombreJugador;

                // Mostrar estadísticas
                lbTotalPartidas.Text = jugador.TotalPartidas.ToString();
                lbPartidasGanadas.Text = jugador.PartidasGanadas.ToString();
                lbPartidasEmpatadas.Text = jugador.PartidasEmpatadas.ToString();
                lbPartidasPerdidas.Text = jugador.PartidasPerdidas.ToString();

                // Calcular y mostrar tasa de victoria
                if (jugador.TotalPartidas > 0)
                {
                    double tasaVictoria = (jugador.PartidasGanadas * 100.0) / jugador.TotalPartidas;
                    lbTasaVictoria.Text = tasaVictoria.ToString("0.00") + "%";
                }
                else
                {
                    lbTasaVictoria.Text = "0.00%";
                }
            }
        }

        // --- BOTÓN SALIR ---
        // Cierra toda la aplicación.
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // --- BOTÓN NUEVA PARTIDA ---
        // Pide al formulario principal (Form1) que inicie la conexión.
        private void BtnNuevaPartida_Click(object sender, EventArgs e)
        {
            Form1 form = this.ParentForm as Form1;
            if (form != null)
            {
                form.IniciarJuego(); // Ejecuta la reconexión
            }
        }
    }
}