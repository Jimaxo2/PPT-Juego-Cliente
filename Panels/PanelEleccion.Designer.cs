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
            label6 = new Label();
            label4 = new Label();
            label5 = new Label();
            lblEstadoEleccion = new Label();
            btnConfirmar = new Button();
            ((System.ComponentModel.ISupportInitialize)pbPiedra).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPapel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbTijera).BeginInit();
            SuspendLayout();
            // 
            // pbPiedra
            // 
            pbPiedra.Image = Properties.Resources.Piedra;
            pbPiedra.Location = new Point(89, 123);
            pbPiedra.Name = "pbPiedra";
            pbPiedra.Size = new Size(125, 94);
            pbPiedra.SizeMode = PictureBoxSizeMode.Zoom;
            pbPiedra.TabIndex = 18;
            pbPiedra.TabStop = false;
            // 
            // pbPapel
            // 
            pbPapel.Image = Properties.Resources.Papel;
            pbPapel.Location = new Point(306, 123);
            pbPapel.Name = "pbPapel";
            pbPapel.Size = new Size(133, 94);
            pbPapel.SizeMode = PictureBoxSizeMode.Zoom;
            pbPapel.TabIndex = 19;
            pbPapel.TabStop = false;
            // 
            // pbTijera
            // 
            pbTijera.Image = Properties.Resources.Tijera;
            pbTijera.Location = new Point(518, 123);
            pbTijera.Name = "pbTijera";
            pbTijera.Size = new Size(159, 94);
            pbTijera.SizeMode = PictureBoxSizeMode.Zoom;
            pbTijera.TabIndex = 20;
            pbTijera.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Segoe UI Variable Display Semib", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(124, 229);
            label6.Name = "label6";
            label6.Size = new Size(41, 16);
            label6.TabIndex = 21;
            label6.Text = "Piedra";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI Variable Display Semib", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(349, 229);
            label4.Name = "label4";
            label4.Size = new Size(36, 16);
            label4.TabIndex = 23;
            label4.Text = "Papel";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI Variable Display Semib", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(575, 229);
            label5.Name = "label5";
            label5.Size = new Size(37, 16);
            label5.TabIndex = 24;
            label5.Text = "Tijera";
            // 
            // lblEstadoEleccion
            // 
            lblEstadoEleccion.AutoSize = true;
            lblEstadoEleccion.Font = new Font("Segoe UI Variable Display Semib", 15.75F, FontStyle.Bold);
            lblEstadoEleccion.ForeColor = Color.White;
            lblEstadoEleccion.Location = new Point(276, 58);
            lblEstadoEleccion.Name = "lblEstadoEleccion";
            lblEstadoEleccion.Size = new Size(213, 28);
            lblEstadoEleccion.TabIndex = 25;
            lblEstadoEleccion.Text = "Elige con que jugaras";
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(298, 290);
            btnConfirmar.Margin = new Padding(3, 2, 3, 2);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(152, 35);
            btnConfirmar.TabIndex = 26;
            btnConfirmar.Text = "Listo";
            btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // PanelEleccion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            Controls.Add(btnConfirmar);
            Controls.Add(lblEstadoEleccion);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(pbTijera);
            Controls.Add(pbPapel);
            Controls.Add(pbPiedra);
            Margin = new Padding(3, 2, 3, 2);
            Name = "PanelEleccion";
            Size = new Size(764, 353);
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
        private Label label6;
        private Label label4;
        private Label label5;
        private Label lblEstadoEleccion;
        private Button btnConfirmar;
    }
}
