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
            pbPiedra.Location = new Point(96, 68);
            pbPiedra.Name = "pbPiedra";
            pbPiedra.Size = new Size(197, 164);
            pbPiedra.SizeMode = PictureBoxSizeMode.Zoom;
            pbPiedra.TabIndex = 19;
            pbPiedra.TabStop = false;
            // 
            // lblEsperando
            // 
            lblEsperando.AutoSize = true;
            lblEsperando.Font = new Font("Segoe UI Variable Display Semib", 15.75F, FontStyle.Bold);
            lblEsperando.ForeColor = Color.White;
            lblEsperando.Location = new Point(15, 235);
            lblEsperando.Name = "lblEsperando";
            lblEsperando.Size = new Size(374, 28);
            lblEsperando.TabIndex = 26;
            lblEsperando.Text = "En espera de la eleccion de (nombre)...";
            // 
            // EsperaConfirmacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            Controls.Add(lblEsperando);
            Controls.Add(pbPiedra);
            Margin = new Padding(3, 2, 3, 2);
            Name = "EsperaConfirmacion";
            Size = new Size(402, 368);
            ((System.ComponentModel.ISupportInitialize)pbPiedra).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbPiedra;
        private Label lblEsperando;
    }
}
