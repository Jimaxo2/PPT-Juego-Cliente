namespace PPT_Juego_Cliente.Panels
{
    partial class Resultado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Resultado));
            pictureBox1 = new PictureBox();
            pictureIzq = new PictureBox();
            pictureDer = new PictureBox();
            lblNombreIzq = new Label();
            lblNombreDer = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureIzq).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureDer).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(179, 220);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(581, 254);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureIzq
            // 
            pictureIzq.Image = (Image)resources.GetObject("pictureIzq.Image");
            pictureIzq.Location = new Point(24, 220);
            pictureIzq.Margin = new Padding(3, 2, 3, 2);
            pictureIzq.Name = "pictureIzq";
            pictureIzq.Size = new Size(301, 254);
            pictureIzq.SizeMode = PictureBoxSizeMode.Zoom;
            pictureIzq.TabIndex = 2;
            pictureIzq.TabStop = false;
            // 
            // pictureDer
            // 
            pictureDer.Image = (Image)resources.GetObject("pictureDer.Image");
            pictureDer.Location = new Point(634, 220);
            pictureDer.Margin = new Padding(3, 2, 3, 2);
            pictureDer.Name = "pictureDer";
            pictureDer.Size = new Size(301, 254);
            pictureDer.SizeMode = PictureBoxSizeMode.Zoom;
            pictureDer.TabIndex = 3;
            pictureDer.TabStop = false;
            // 
            // lblNombreIzq
            // 
            lblNombreIzq.AutoSize = true;
            lblNombreIzq.Font = new Font("Segoe UI Variable Display Semib", 15.75F, FontStyle.Bold);
            lblNombreIzq.ForeColor = Color.White;
            lblNombreIzq.Location = new Point(109, 141);
            lblNombreIzq.Name = "lblNombreIzq";
            lblNombreIzq.Size = new Size(103, 28);
            lblNombreIzq.TabIndex = 31;
            lblNombreIzq.Text = "Jugador 1";
            // 
            // lblNombreDer
            // 
            lblNombreDer.AutoSize = true;
            lblNombreDer.Font = new Font("Segoe UI Variable Display Semib", 15.75F, FontStyle.Bold);
            lblNombreDer.ForeColor = Color.White;
            lblNombreDer.Location = new Point(715, 129);
            lblNombreDer.Name = "lblNombreDer";
            lblNombreDer.Size = new Size(107, 28);
            lblNombreDer.TabIndex = 32;
            lblNombreDer.Text = "Jugador 2";
            // 
            // Resultado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            Controls.Add(lblNombreDer);
            Controls.Add(lblNombreIzq);
            Controls.Add(pictureDer);
            Controls.Add(pictureIzq);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Resultado";
            Size = new Size(956, 631);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureIzq).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureDer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureIzq;
        private PictureBox pictureDer;
        private Label lblNombreIzq;
        private Label lblNombreDer;
    }
}
