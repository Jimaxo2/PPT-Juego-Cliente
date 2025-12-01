namespace PPT_Juego_Cliente.Panels
{
    partial class EsperaConfirmacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EsperaConfirmacion));
            pbPiedra = new PictureBox();
            lblEsperando = new Label();
            ((System.ComponentModel.ISupportInitialize)pbPiedra).BeginInit();
            SuspendLayout();
            // 
            // pbPiedra
            // 
            pbPiedra.Image = (Image)resources.GetObject("pbPiedra.Image");
            pbPiedra.Location = new Point(116, 82);
            pbPiedra.Margin = new Padding(3, 4, 3, 4);
            pbPiedra.Name = "pbPiedra";
            pbPiedra.Size = new Size(225, 219);
            pbPiedra.SizeMode = PictureBoxSizeMode.Zoom;
            pbPiedra.TabIndex = 19;
            pbPiedra.TabStop = false;
            // 
            // lblEsperando
            // 
            lblEsperando.AutoSize = true;
            lblEsperando.Location = new Point(95, 330);
            lblEsperando.Name = "lblEsperando";
            lblEsperando.Size = new Size(265, 20);
            lblEsperando.TabIndex = 26;
            lblEsperando.Text = "En espera de la eleccion de (nombre)...";
            // 
            // EsperaConfirmacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            Controls.Add(lblEsperando);
            Controls.Add(pbPiedra);
            Name = "EsperaConfirmacion";
            Size = new Size(459, 490);
            ((System.ComponentModel.ISupportInitialize)pbPiedra).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbPiedra;
        private Label lblEsperando;
    }
}
