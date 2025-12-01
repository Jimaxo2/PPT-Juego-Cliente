namespace PPT_Juego_Cliente.Panels
{
    partial class MenuPrincipal
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            lbJugador = new Label();
            lbNombreJugador = new Label();
            lbPartidas = new Label();
            lbEmpatadas = new Label();
            lbGanadas = new Label();
            lbPerdidas = new Label();
            lbVictoria = new Label();
            pictureBox1 = new PictureBox();
            lbPartidasGanadas = new Label();
            lbPartidasEmpatadas = new Label();
            lbPartidasPerdidas = new Label();
            lbTasaVictoria = new Label();
            BtnNuevaPartida = new Button();
            BtnSalir = new Button();
            lbTotalPartidas = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbJugador
            // 
            lbJugador.AutoSize = true;
            lbJugador.ForeColor = Color.White;
            lbJugador.Location = new Point(128, 19);
            lbJugador.Name = "lbJugador";
            lbJugador.Size = new Size(49, 15);
            lbJugador.TabIndex = 0;
            lbJugador.Text = "Jugador";
            // 
            // lbNombreJugador
            // 
            lbNombreJugador.AutoSize = true;
            lbNombreJugador.Font = new Font("Segoe UI Variable Display Semib", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbNombreJugador.ForeColor = Color.Coral;
            lbNombreJugador.Location = new Point(128, 38);
            lbNombreJugador.Name = "lbNombreJugador";
            lbNombreJugador.Size = new Size(315, 43);
            lbNombreJugador.TabIndex = 1;
            lbNombreJugador.Text = "Nombre del Jugador";
            // 
            // lbPartidas
            // 
            lbPartidas.AutoSize = true;
            lbPartidas.Font = new Font("Segoe UI Variable Display Semib", 20F, FontStyle.Bold);
            lbPartidas.ForeColor = Color.White;
            lbPartidas.Location = new Point(22, 148);
            lbPartidas.Name = "lbPartidas";
            lbPartidas.Size = new Size(218, 36);
            lbPartidas.TabIndex = 2;
            lbPartidas.Text = "Partidas Jugadas";
            // 
            // lbEmpatadas
            // 
            lbEmpatadas.AutoSize = true;
            lbEmpatadas.Font = new Font("Segoe UI Variable Display Semib", 15.75F, FontStyle.Bold);
            lbEmpatadas.ForeColor = Color.White;
            lbEmpatadas.Location = new Point(168, 308);
            lbEmpatadas.Name = "lbEmpatadas";
            lbEmpatadas.Size = new Size(118, 28);
            lbEmpatadas.TabIndex = 3;
            lbEmpatadas.Text = "Empatadas";
            // 
            // lbGanadas
            // 
            lbGanadas.AutoSize = true;
            lbGanadas.Font = new Font("Segoe UI Variable Display Semib", 15.75F, FontStyle.Bold);
            lbGanadas.ForeColor = Color.White;
            lbGanadas.Location = new Point(31, 308);
            lbGanadas.Name = "lbGanadas";
            lbGanadas.Size = new Size(95, 28);
            lbGanadas.TabIndex = 4;
            lbGanadas.Text = "Ganadas";
            // 
            // lbPerdidas
            // 
            lbPerdidas.AutoSize = true;
            lbPerdidas.Font = new Font("Segoe UI Variable Display Semib", 15.75F, FontStyle.Bold);
            lbPerdidas.ForeColor = Color.White;
            lbPerdidas.Location = new Point(328, 308);
            lbPerdidas.Name = "lbPerdidas";
            lbPerdidas.Size = new Size(94, 28);
            lbPerdidas.TabIndex = 5;
            lbPerdidas.Text = "Perdidas";
            // 
            // lbVictoria
            // 
            lbVictoria.AutoSize = true;
            lbVictoria.Font = new Font("Segoe UI Variable Display Semib", 15.75F, FontStyle.Bold);
            lbVictoria.ForeColor = Color.White;
            lbVictoria.Location = new Point(472, 308);
            lbVictoria.Name = "lbVictoria";
            lbVictoria.Size = new Size(161, 28);
            lbVictoria.TabIndex = 6;
            lbVictoria.Text = "Tasa de Victoria";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(22, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // lbPartidasGanadas
            // 
            lbPartidasGanadas.AutoSize = true;
            lbPartidasGanadas.Font = new Font("MV Boli", 36F, FontStyle.Bold);
            lbPartidasGanadas.ForeColor = Color.White;
            lbPartidasGanadas.Location = new Point(47, 357);
            lbPartidasGanadas.Name = "lbPartidasGanadas";
            lbPartidasGanadas.Size = new Size(62, 63);
            lbPartidasGanadas.TabIndex = 8;
            lbPartidasGanadas.Text = "0";
            // 
            // lbPartidasEmpatadas
            // 
            lbPartidasEmpatadas.AutoSize = true;
            lbPartidasEmpatadas.Font = new Font("MV Boli", 36F, FontStyle.Bold);
            lbPartidasEmpatadas.ForeColor = Color.White;
            lbPartidasEmpatadas.Location = new Point(196, 357);
            lbPartidasEmpatadas.Name = "lbPartidasEmpatadas";
            lbPartidasEmpatadas.Size = new Size(62, 63);
            lbPartidasEmpatadas.TabIndex = 9;
            lbPartidasEmpatadas.Text = "0";
            // 
            // lbPartidasPerdidas
            // 
            lbPartidasPerdidas.AutoSize = true;
            lbPartidasPerdidas.Font = new Font("MV Boli", 36F, FontStyle.Bold);
            lbPartidasPerdidas.ForeColor = Color.White;
            lbPartidasPerdidas.Location = new Point(344, 357);
            lbPartidasPerdidas.Name = "lbPartidasPerdidas";
            lbPartidasPerdidas.Size = new Size(62, 63);
            lbPartidasPerdidas.TabIndex = 10;
            lbPartidasPerdidas.Text = "0";
            // 
            // lbTasaVictoria
            // 
            lbTasaVictoria.AutoSize = true;
            lbTasaVictoria.Font = new Font("MV Boli", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTasaVictoria.ForeColor = Color.White;
            lbTasaVictoria.Location = new Point(472, 363);
            lbTasaVictoria.Name = "lbTasaVictoria";
            lbTasaVictoria.Size = new Size(144, 49);
            lbTasaVictoria.TabIndex = 11;
            lbTasaVictoria.Text = "0.00%";
            // 
            // BtnNuevaPartida
            // 
            BtnNuevaPartida.BackColor = Color.LimeGreen;
            BtnNuevaPartida.FlatAppearance.BorderSize = 0;
            BtnNuevaPartida.FlatStyle = FlatStyle.Flat;
            BtnNuevaPartida.Font = new Font("Segoe UI Variable Display Semib", 15.75F, FontStyle.Bold);
            BtnNuevaPartida.ForeColor = Color.White;
            BtnNuevaPartida.Location = new Point(772, 308);
            BtnNuevaPartida.Name = "BtnNuevaPartida";
            BtnNuevaPartida.Size = new Size(151, 78);
            BtnNuevaPartida.TabIndex = 12;
            BtnNuevaPartida.Text = "Nueva Partida";
            BtnNuevaPartida.UseVisualStyleBackColor = false;
            BtnNuevaPartida.Click += BtnNuevaPartida_Click;
            // 
            // BtnSalir
            // 
            BtnSalir.BackColor = Color.ForestGreen;
            BtnSalir.FlatAppearance.BorderSize = 0;
            BtnSalir.FlatStyle = FlatStyle.Flat;
            BtnSalir.Font = new Font("Segoe UI Variable Display Semib", 15.75F, FontStyle.Bold);
            BtnSalir.ForeColor = Color.White;
            BtnSalir.Location = new Point(772, 19);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(151, 45);
            BtnSalir.TabIndex = 13;
            BtnSalir.Text = "Salir";
            BtnSalir.UseVisualStyleBackColor = false;
            BtnSalir.Click += BtnSalir_Click;
            // 
            // lbTotalPartidas
            // 
            lbTotalPartidas.AutoSize = true;
            lbTotalPartidas.Font = new Font("MV Boli", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTotalPartidas.ForeColor = Color.White;
            lbTotalPartidas.Location = new Point(47, 200);
            lbTotalPartidas.Name = "lbTotalPartidas";
            lbTotalPartidas.Size = new Size(82, 85);
            lbTotalPartidas.TabIndex = 14;
            lbTotalPartidas.Text = "0";
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(65, 65, 65);
            Controls.Add(lbTotalPartidas);
            Controls.Add(BtnSalir);
            Controls.Add(BtnNuevaPartida);
            Controls.Add(lbTasaVictoria);
            Controls.Add(lbPartidasPerdidas);
            Controls.Add(lbPartidasEmpatadas);
            Controls.Add(lbPartidasGanadas);
            Controls.Add(pictureBox1);
            Controls.Add(lbVictoria);
            Controls.Add(lbPerdidas);
            Controls.Add(lbGanadas);
            Controls.Add(lbEmpatadas);
            Controls.Add(lbPartidas);
            Controls.Add(lbNombreJugador);
            Controls.Add(lbJugador);
            Name = "MenuPrincipal";
            Size = new Size(960, 512);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbJugador;
        private Label lbNombreJugador;
        private Label lbPartidas;
        private Label lbEmpatadas;
        private Label lbGanadas;
        private Label lbPerdidas;
        private Label lbVictoria;
        private PictureBox pictureBox1;
        private Label lbPartidasGanadas;
        private Label lbPartidasEmpatadas;
        private Label lbPartidasPerdidas;
        private Label lbTasaVictoria;
        private Button BtnNuevaPartida;
        private Button BtnSalir;
        private Label lbTotalPartidas;
    }
}
