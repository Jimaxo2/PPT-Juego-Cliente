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
            textBox1.Location = new Point(108, 71);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(197, 23);
            textBox1.TabIndex = 31;
            textBox1.Text = "Nombre del jugador";
            // 
            // lblEsperando
            // 
            lblEsperando.AutoSize = true;
            lblEsperando.Font = new Font("Segoe UI Variable Display Semib", 15.75F, FontStyle.Bold);
            lblEsperando.ForeColor = Color.White;
            lblEsperando.Location = new Point(99, 285);
            lblEsperando.Name = "lblEsperando";
            lblEsperando.Size = new Size(217, 28);
            lblEsperando.TabIndex = 30;
            lblEsperando.Text = "Que pendejo perdiste";
            // 
            // pbPiedra
            // 
            pbPiedra.Image = (Image)resources.GetObject("pbPiedra.Image");
            pbPiedra.Location = new Point(108, 118);
            pbPiedra.Name = "pbPiedra";
            pbPiedra.Size = new Size(197, 164);
            pbPiedra.SizeMode = PictureBoxSizeMode.Zoom;
            pbPiedra.TabIndex = 29;
            pbPiedra.TabStop = false;
            // 
            // Perdedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            Controls.Add(textBox1);
            Controls.Add(lblEsperando);
            Controls.Add(pbPiedra);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Perdedor";
            Size = new Size(423, 402);
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
