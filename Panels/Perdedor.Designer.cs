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
            lblEsperando = new Label();
            pbPiedra = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbPiedra).BeginInit();
            SuspendLayout();
            // 
            // lblEsperando
            // 
            lblEsperando.AutoSize = true;
            lblEsperando.Font = new Font("Segoe UI Variable Display Semib", 15.75F, FontStyle.Bold);
            lblEsperando.ForeColor = Color.White;
            lblEsperando.Location = new Point(318, 438);
            lblEsperando.Name = "lblEsperando";
            lblEsperando.Size = new Size(217, 28);
            lblEsperando.TabIndex = 30;
            lblEsperando.Text = "Que pendejo perdiste";
            // 
            // pbPiedra
            // 
            pbPiedra.Image = (Image)resources.GetObject("pbPiedra.Image");
            pbPiedra.Location = new Point(289, 153);
            pbPiedra.Name = "pbPiedra";
            pbPiedra.Size = new Size(260, 229);
            pbPiedra.SizeMode = PictureBoxSizeMode.Zoom;
            pbPiedra.TabIndex = 31;
            pbPiedra.TabStop = false;
            // 
            // Perdedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            Controls.Add(pbPiedra);
            Controls.Add(lblEsperando);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Perdedor";
            Size = new Size(914, 675);
            ((System.ComponentModel.ISupportInitialize)pbPiedra).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblEsperando;
        private PictureBox pbPiedra;
    }
}
