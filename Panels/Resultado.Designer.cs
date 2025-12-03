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
            label1 = new Label();
            lblNombreDer = new Label();
            lblNombreIzq = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureIzq).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureDer).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(73, 131);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(603, 162);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureIzq
            // 
            pictureIzq.Image = (Image)resources.GetObject("pictureIzq.Image");
            pictureIzq.Location = new Point(108, 163);
            pictureIzq.Margin = new Padding(3, 2, 3, 2);
            pictureIzq.Name = "pictureIzq";
            pictureIzq.Size = new Size(140, 115);
            pictureIzq.SizeMode = PictureBoxSizeMode.Zoom;
            pictureIzq.TabIndex = 2;
            pictureIzq.TabStop = false;
            // 
            // pictureDer
            // 
            pictureDer.Image = (Image)resources.GetObject("pictureDer.Image");
            pictureDer.Location = new Point(510, 163);
            pictureDer.Margin = new Padding(3, 2, 3, 2);
            pictureDer.Name = "pictureDer";
            pictureDer.Size = new Size(140, 115);
            pictureDer.SizeMode = PictureBoxSizeMode.Zoom;
            pictureDer.TabIndex = 3;
            pictureDer.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Text Semibold", 28F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(346, 195);
            label1.Name = "label1";
            label1.Size = new Size(57, 51);
            label1.TabIndex = 4;
            label1.Text = "vs";
            // 
            // lblNombreDer
            // 
            lblNombreDer.AutoSize = true;
            lblNombreDer.ForeColor = Color.White;
            lblNombreDer.Location = new Point(552, 86);
            lblNombreDer.Name = "lblNombreDer";
            lblNombreDer.Size = new Size(58, 15);
            lblNombreDer.TabIndex = 5;
            lblNombreDer.Text = "Jugador 2";
            // 
            // lblNombreIzq
            // 
            lblNombreIzq.AutoSize = true;
            lblNombreIzq.ForeColor = Color.White;
            lblNombreIzq.Location = new Point(142, 86);
            lblNombreIzq.Name = "lblNombreIzq";
            lblNombreIzq.Size = new Size(58, 15);
            lblNombreIzq.TabIndex = 6;
            lblNombreIzq.Text = "Jugador 1";
            lblNombreIzq.Click += label3_Click;
            // 
            // Resultado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            Controls.Add(lblNombreIzq);
            Controls.Add(lblNombreDer);
            Controls.Add(label1);
            Controls.Add(pictureDer);
            Controls.Add(pictureIzq);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Resultado";
            Size = new Size(759, 422);
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
        private Label label1;
        private Label lblNombreDer;
        private Label lblNombreIzq;
    }
}
