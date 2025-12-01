using PPT_Juego_Cliente.Panels;
using System.Net.Sockets;
using System.Windows.Forms;

namespace PPT_Juego_Cliente
{
    public partial class Form1 : Form
    {
        TcpClient client;
        NetworkStream stream;
        public Form1()
        {
            InitializeComponent();

            // Conectamos con el servidor al iniciar la aplicaci�n
            client = new TcpClient("127.0.0.1", 5000);
            stream = client.GetStream();

            if (client.Connected)
            {
                MessageBox.Show("Conectado al servidor.");
            }

            // Limpiar el panel por si acaso
            pDisplay.Controls.Clear();

            // Crear instancia del panel Login
            IniciarSesion Login = new IniciarSesion(client, stream);

            // Para que ocupe todo el espacio
            Login.Dock = DockStyle.Fill;

            // Agregarlo al panel contenedor
            pDisplay.Controls.Add(Login);

           // this.Text = "Iniciar sesion";
            this.Text = "Inicio de Sesion";
        }
    }
}
