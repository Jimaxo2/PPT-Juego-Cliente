namespace PPT_Juego_Cliente.Panels
{
    partial class PanelEleccion
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
            pbPiedra = new PictureBox();
            pbPapel = new PictureBox();
            pbTijera = new PictureBox();
            lblEstadoEleccion = new Label();
            btnConfirmar = new Button();
            lbGanadas = new Label();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbPiedra).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPapel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbTijera).BeginInit();
            SuspendLayout();
            // 
            // pbPiedra
            // 
            pbPiedra.Image = Properties.Resources.Piedra;
            pbPiedra.Location = new Point(148, 187);
            pbPiedra.Name = "pbPiedra";
            pbPiedra.Size = new Size(189, 120);
            pbPiedra.SizeMode = PictureBoxSizeMode.Zoom;
            pbPiedra.TabIndex = 18;
            pbPiedra.TabStop = false;
            // 
            // pbPapel
            // 
            pbPapel.Image = Properties.Resources.Papel;
            pbPapel.Location = new Point(388, 187);
            pbPapel.Name = "pbPapel";
            pbPapel.Size = new Size(189, 120);
            pbPapel.SizeMode = PictureBoxSizeMode.Zoom;
            pbPapel.TabIndex = 19;
            pbPapel.TabStop = false;
            // 
            // pbTijera
            // 
            pbTijera.Image = Properties.Resources.Tijera;
            pbTijera.Location = new Point(642, 187);
            pbTijera.Name = "pbTijera";
            pbTijera.Size = new Size(189, 120);
            pbTijera.SizeMode = PictureBoxSizeMode.Zoom;
            pbTijera.TabIndex = 20;
            pbTijera.TabStop = false;
            // 
            // lblEstadoEleccion
            // 
            lblEstadoEleccion.AutoSize = true;
            lblEstadoEleccion.Font = new Font("Segoe UI Variable Display Semib", 15.75F, FontStyle.Bold);
            lblEstadoEleccion.ForeColor = Color.White;
            lblEstadoEleccion.Location = new Point(377, 77);
            lblEstadoEleccion.Name = "lblEstadoEleccion";
            lblEstadoEleccion.Size = new Size(213, 28);
            lblEstadoEleccion.TabIndex = 25;
            lblEstadoEleccion.Text = "Elige con que jugaras";
            lblEstadoEleccion.Click += lblEstadoEleccion_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.ForestGreen;
            btnConfirmar.FlatAppearance.BorderSize = 0;
            btnConfirmar.FlatStyle = FlatStyle.Flat;
            btnConfirmar.Font = new Font("Segoe UI Variable Display Semib", 15.75F, FontStyle.Bold);
            btnConfirmar.ForeColor = Color.White;
            btnConfirmar.Location = new Point(400, 409);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(151, 45);
            btnConfirmar.TabIndex = 27;
            btnConfirmar.Text = "Listo";
            btnConfirmar.UseVisualStyleBackColor = false;
            // 
            // lbGanadas
            // 
            lbGanadas.AutoSize = true;
            lbGanadas.Font = new Font("Segoe UI Variable Display Semib", 15.75F, FontStyle.Bold);
            lbGanadas.ForeColor = Color.White;
            lbGanadas.Location = new Point(205, 337);
            lbGanadas.Name = "lbGanadas";
            lbGanadas.Size = new Size(72, 28);
            lbGanadas.TabIndex = 28;
            lbGanadas.Text = "Piedra";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Display Semib", 15.75F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(456, 337);
            label1.Name = "label1";
            label1.Size = new Size(63, 28);
            label1.TabIndex = 29;
            label1.Text = "Papel";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Display Semib", 15.75F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(709, 337);
            label2.Name = "label2";
            label2.Size = new Size(63, 28);
            label2.TabIndex = 30;
            label2.Text = "Tijera";
            // 
            // PanelEleccion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbGanadas);
            Controls.Add(btnConfirmar);
            Controls.Add(lblEstadoEleccion);
            Controls.Add(pbTijera);
            Controls.Add(pbPapel);
            Controls.Add(pbPiedra);
            Margin = new Padding(3, 2, 3, 2);
            Name = "PanelEleccion";
            Size = new Size(947, 538);
            ((System.ComponentModel.ISupportInitialize)pbPiedra).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPapel).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbTijera).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbPiedra;
        private PictureBox pbPapel;
        private PictureBox pbTijera;
        private Label lblEstadoEleccion;
        private Button btnConfirmar;
        private Label lbGanadas;
        private Label label1;
        private Label label2;
    }
}
