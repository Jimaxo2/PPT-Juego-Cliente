namespace PPT_Juego_Cliente.Panels
{
    partial class Ganador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ganador));
            pbPiedra = new PictureBox();
            lblEsperando = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pbPiedra).BeginInit();
            SuspendLayout();
            // 
            // pbPiedra
            // 
            pbPiedra.Image = (Image)resources.GetObject("pbPiedra.Image");
            pbPiedra.Location = new Point(145, 156);
            pbPiedra.Margin = new Padding(3, 4, 3, 4);
            pbPiedra.Name = "pbPiedra";
            pbPiedra.Size = new Size(225, 219);
            pbPiedra.SizeMode = PictureBoxSizeMode.Zoom;
            pbPiedra.TabIndex = 20;
            pbPiedra.TabStop = false;
            // 
            // lblEsperando
            // 
            lblEsperando.AutoSize = true;
            lblEsperando.Location = new Point(183, 391);
            lblEsperando.Name = "lblEsperando";
            lblEsperando.Size = new Size(144, 20);
            lblEsperando.TabIndex = 27;
            lblEsperando.Text = "Felicidades Ganaste!";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(145, 92);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(225, 27);
            textBox1.TabIndex = 28;
            textBox1.Text = "Nombre del jugador";
            // 
            // Ganador
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            Controls.Add(textBox1);
            Controls.Add(lblEsperando);
            Controls.Add(pbPiedra);
            Name = "Ganador";
            Size = new Size(551, 512);
            ((System.ComponentModel.ISupportInitialize)pbPiedra).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbPiedra;
        private Label lblEsperando;
        private TextBox textBox1;
    }
}
