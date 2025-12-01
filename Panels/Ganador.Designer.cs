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
            pbPiedra.Location = new Point(127, 117);
            pbPiedra.Name = "pbPiedra";
            pbPiedra.Size = new Size(197, 164);
            pbPiedra.SizeMode = PictureBoxSizeMode.Zoom;
            pbPiedra.TabIndex = 20;
            pbPiedra.TabStop = false;
            // 
            // lblEsperando
            // 
            lblEsperando.AutoSize = true;
            lblEsperando.Font = new Font("Segoe UI Variable Display Semib", 15.75F, FontStyle.Bold);
            lblEsperando.ForeColor = Color.White;
            lblEsperando.Location = new Point(125, 284);
            lblEsperando.Name = "lblEsperando";
            lblEsperando.Size = new Size(206, 28);
            lblEsperando.TabIndex = 27;
            lblEsperando.Text = "Felicidades Ganaste!";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(127, 69);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(197, 23);
            textBox1.TabIndex = 28;
            textBox1.Text = "Nombre del jugador";
            // 
            // Ganador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            Controls.Add(textBox1);
            Controls.Add(lblEsperando);
            Controls.Add(pbPiedra);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Ganador";
            Size = new Size(482, 384);
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
