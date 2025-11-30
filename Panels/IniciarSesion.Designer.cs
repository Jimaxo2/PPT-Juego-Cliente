namespace PPT_Juego_Cliente.Panels
{
    partial class IniciarSesion
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            TbContraseñaJugador = new TextBox();
            TbNombreJugador = new TextBox();
            BtnCrearCuenta = new Button();
            BtnIniciarSesion = new Button();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(65, 65, 65);
            label5.Font = new Font("Segoe UI Variable Display Semib", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(370, 162);
            label5.Name = "label5";
            label5.Size = new Size(112, 16);
            label5.TabIndex = 26;
            label5.Text = "Nombre de Usuario";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(65, 65, 65);
            label4.Font = new Font("Segoe UI Variable Display Semib", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(370, 235);
            label4.Name = "label4";
            label4.Size = new Size(70, 16);
            label4.TabIndex = 25;
            label4.Text = "Contraseña";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI Variable Display Semib", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(466, 122);
            label3.Name = "label3";
            label3.Size = new Size(36, 16);
            label3.TabIndex = 24;
            label3.Text = "Papel";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI Variable Display Semib", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(543, 122);
            label2.Name = "label2";
            label2.Size = new Size(37, 16);
            label2.TabIndex = 23;
            label2.Text = "Tijera";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI Variable Display Semib", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(385, 122);
            label1.Name = "label1";
            label1.Size = new Size(41, 16);
            label1.TabIndex = 22;
            label1.Text = "Piedra";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Papel;
            pictureBox3.Location = new Point(459, 62);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(50, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 20;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Piedra;
            pictureBox1.Location = new Point(370, 52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Tijera;
            pictureBox2.Location = new Point(528, 52);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(70, 70);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // TbContraseñaJugador
            // 
            TbContraseñaJugador.BackColor = Color.FromArgb(65, 65, 65);
            TbContraseñaJugador.BorderStyle = BorderStyle.FixedSingle;
            TbContraseñaJugador.Font = new Font("Segoe UI", 18F);
            TbContraseñaJugador.ForeColor = Color.White;
            TbContraseñaJugador.Location = new Point(370, 254);
            TbContraseñaJugador.Name = "TbContraseñaJugador";
            TbContraseñaJugador.Size = new Size(228, 39);
            TbContraseñaJugador.TabIndex = 17;
            // 
            // TbNombreJugador
            // 
            TbNombreJugador.BackColor = Color.FromArgb(65, 65, 65);
            TbNombreJugador.BorderStyle = BorderStyle.FixedSingle;
            TbNombreJugador.Font = new Font("Segoe UI", 18F);
            TbNombreJugador.ForeColor = Color.White;
            TbNombreJugador.Location = new Point(370, 181);
            TbNombreJugador.Name = "TbNombreJugador";
            TbNombreJugador.Size = new Size(228, 39);
            TbNombreJugador.TabIndex = 16;
            // 
            // BtnCrearCuenta
            // 
            BtnCrearCuenta.BackColor = Color.ForestGreen;
            BtnCrearCuenta.Cursor = Cursors.Hand;
            BtnCrearCuenta.FlatAppearance.BorderColor = Color.Blue;
            BtnCrearCuenta.FlatAppearance.BorderSize = 0;
            BtnCrearCuenta.FlatStyle = FlatStyle.Flat;
            BtnCrearCuenta.Font = new Font("Segoe UI Variable Display Semib", 15.75F, FontStyle.Bold);
            BtnCrearCuenta.ForeColor = Color.White;
            BtnCrearCuenta.Location = new Point(401, 410);
            BtnCrearCuenta.Name = "BtnCrearCuenta";
            BtnCrearCuenta.Size = new Size(166, 58);
            BtnCrearCuenta.TabIndex = 15;
            BtnCrearCuenta.Text = "Crear cuenta";
            BtnCrearCuenta.UseVisualStyleBackColor = false;
            BtnCrearCuenta.Click += BtnCrearCuenta_Click;
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
            BtnIniciarSesion.Location = new Point(401, 327);
            BtnIniciarSesion.Name = "BtnIniciarSesion";
            BtnIniciarSesion.Size = new Size(166, 58);
            BtnIniciarSesion.TabIndex = 14;
            BtnIniciarSesion.Text = "Iniciar sesión";
            BtnIniciarSesion.UseVisualStyleBackColor = false;
            BtnIniciarSesion.Click += BtnIniciarSesion_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.blanco;
            pictureBox4.Location = new Point(-16, 43);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(1000, 101);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 21;
            pictureBox4.TabStop = false;
            // 
            // IniciarSesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            Controls.Add(label5);
            Controls.Add(label4);
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
            Name = "IniciarSesion";
            Size = new Size(960, 512);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox TbContraseñaJugador;
        private TextBox TbNombreJugador;
        private Button BtnCrearCuenta;
        private Button BtnIniciarSesion;
        private PictureBox pictureBox4;
    }
}
