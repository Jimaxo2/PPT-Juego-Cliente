using PPT_Juego_Cliente.Panels;
using System.Windows.Forms;

namespace PPT_Juego_Cliente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Limpiar el panel por si acaso
            pDisplay.Controls.Clear();

            // Crear instancia del panel Login
             IniciarSesion Login = new IniciarSesion();
          
             Login.Dock = DockStyle.Fill;
            // Quitar Dock
            Login.Dock = DockStyle.None;

            // Agregarlo al panel contenedor
            pDisplay.Controls.Add(Login);
           // this.Text = "Iniciar sesion";
            this.Text = "Inicio de Sesion";
        }
    }
}
