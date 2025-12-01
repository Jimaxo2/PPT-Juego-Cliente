namespace PPT_Juego_Cliente.Panels
{
    partial class Perdedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Perdedor));
            textBox1 = new TextBox();
            lblEsperando = new Label();
            pbPiedra = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbPiedra).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(114, 95);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(225, 27);
            textBox1.TabIndex = 31;
            textBox1.Text = "Nombre del jugador";
            // 
            // lblEsperando
            // 
            lblEsperando.AutoSize = true;
            lblEsperando.Location = new Point(152, 392);
            lblEsperando.Name = "lblEsperando";
            lblEsperando.Size = new Size(153, 20);
            lblEsperando.TabIndex = 30;
            lblEsperando.Text = "Que pendejo perdiste";
            // 
            // pbPiedra
            // 
            pbPiedra.Image = (Image)resources.GetObject("pbPiedra.Image");
            pbPiedra.Location = new Point(114, 157);
            pbPiedra.Margin = new Padding(3, 4, 3, 4);
            pbPiedra.Name = "pbPiedra";
            pbPiedra.Size = new Size(225, 219);
            pbPiedra.SizeMode = PictureBoxSizeMode.Zoom;
            pbPiedra.TabIndex = 29;
            pbPiedra.TabStop = false;
            // 
            // Perdedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            Controls.Add(textBox1);
            Controls.Add(lblEsperando);
            Controls.Add(pbPiedra);
            Name = "Perdedor";
            Size = new Size(483, 536);
            ((System.ComponentModel.ISupportInitialize)pbPiedra).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label lblEsperando;
        private PictureBox pbPiedra;
    }
}
