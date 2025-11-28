namespace PPT_Juego_Cliente
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnIniciarSesion = new Button();
            BtnCrearCuenta = new Button();
            TbContraseñaJugador = new TextBox();
            TbNombreJugador = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // BtnIniciarSesion
            // 
            BtnIniciarSesion.BackColor = Color.LimeGreen;
            BtnIniciarSesion.Cursor = Cursors.Hand;
            BtnIniciarSesion.FlatAppearance.BorderColor = Color.Red;
            BtnIniciarSesion.FlatAppearance.BorderSize = 0;
            BtnIniciarSesion.FlatStyle = FlatStyle.Flat;
            BtnIniciarSesion.Font = new Font("Segoe UI Variable Display Semib", 15.75F, FontStyle.Bold);
            BtnIniciarSesion.ForeColor = Color.White;
            BtnIniciarSesion.Location = new Point(112, 310);
            BtnIniciarSesion.Name = "BtnIniciarSesion";
            BtnIniciarSesion.Size = new Size(166, 58);
            BtnIniciarSesion.TabIndex = 0;
            BtnIniciarSesion.Text = "Iniciar sesión";
            BtnIniciarSesion.UseVisualStyleBackColor = false;
            BtnIniciarSesion.Click += BtnIniciarSesion_Click;
            // 
            // BtnCrearCuenta
            // 
            BtnCrearCuenta.BackColor = Color.LimeGreen;
            BtnCrearCuenta.Cursor = Cursors.Hand;
            BtnCrearCuenta.FlatAppearance.BorderColor = Color.Blue;
            BtnCrearCuenta.FlatAppearance.BorderSize = 0;
            BtnCrearCuenta.FlatStyle = FlatStyle.Flat;
            BtnCrearCuenta.Font = new Font("Segoe UI Variable Display Semib", 15.75F, FontStyle.Bold);
            BtnCrearCuenta.ForeColor = Color.White;
            BtnCrearCuenta.Location = new Point(112, 410);
            BtnCrearCuenta.Name = "BtnCrearCuenta";
            BtnCrearCuenta.Size = new Size(166, 58);
            BtnCrearCuenta.TabIndex = 1;
            BtnCrearCuenta.Text = "Crear cuenta";
            BtnCrearCuenta.UseVisualStyleBackColor = false;
            // 
            // TbContraseñaJugador
            // 
            TbContraseñaJugador.Font = new Font("Segoe UI", 18F);
            TbContraseñaJugador.Location = new Point(81, 224);
            TbContraseñaJugador.Name = "TbContraseñaJugador";
            TbContraseñaJugador.Size = new Size(228, 39);
            TbContraseñaJugador.TabIndex = 3;
            // 
            // TbNombreJugador
            // 
            TbNombreJugador.Font = new Font("Segoe UI", 18F);
            TbNombreJugador.Location = new Point(81, 140);
            TbNombreJugador.Name = "TbNombreJugador";
            TbNombreJugador.Size = new Size(228, 39);
            TbNombreJugador.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Tijera;
            pictureBox2.Location = new Point(239, 32);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(70, 70);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Piedra;
            pictureBox1.Location = new Point(81, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Papel;
            pictureBox3.Location = new Point(170, 42);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(50, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.blanco;
            pictureBox4.Location = new Point(-5, 28);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(390, 94);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI Variable Display Semib", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(96, 102);
            label1.Name = "label1";
            label1.Size = new Size(41, 16);
            label1.TabIndex = 9;
            label1.Text = "Piedra";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI Variable Display Semib", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(254, 102);
            label2.Name = "label2";
            label2.Size = new Size(37, 16);
            label2.TabIndex = 10;
            label2.Text = "Tijera";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI Variable Display Semib", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(177, 102);
            label3.Name = "label3";
            label3.Size = new Size(36, 16);
            label3.TabIndex = 11;
            label3.Text = "Papel";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(381, 517);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(TbContraseñaJugador);
            Controls.Add(TbNombreJugador);
            Controls.Add(BtnCrearCuenta);
            Controls.Add(BtnIniciarSesion);
            Controls.Add(pictureBox4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnIniciarSesion;
        private Button BtnCrearCuenta;
        private TextBox TbContraseñaJugador;
        private TextBox TbNombreJugador;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
