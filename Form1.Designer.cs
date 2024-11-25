namespace WinFormsAppVariasImagenes
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Primavera = new Button();
            Verano = new Button();
            Invierno = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Primavera
            // 
            Primavera.Location = new Point(93, 264);
            Primavera.Name = "Primavera";
            Primavera.Size = new Size(163, 63);
            Primavera.TabIndex = 0;
            Primavera.Text = "Primavera";
            Primavera.UseVisualStyleBackColor = true;
            Primavera.Click += Primavera_Click;
            // 
            // Verano
            // 
            Verano.Location = new Point(328, 264);
            Verano.Name = "Verano";
            Verano.Size = new Size(163, 63);
            Verano.TabIndex = 1;
            Verano.Text = "Verano";
            Verano.UseVisualStyleBackColor = true;
            Verano.Click += Verano_Click;
            // 
            // Invierno
            // 
            Invierno.Location = new Point(544, 264);
            Invierno.Name = "Invierno";
            Invierno.Size = new Size(163, 63);
            Invierno.TabIndex = 2;
            Invierno.Text = "Invierno";
            Invierno.UseVisualStyleBackColor = true;
            Invierno.Click += Invierno_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.verano;
            pictureBox1.Location = new Point(254, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(320, 202);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 379);
            label1.Name = "label1";
            label1.Size = new Size(192, 20);
            label1.TabIndex = 4;
            label1.Text = "Nestor Gael Martínez Ibarra";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(Invierno);
            Controls.Add(Verano);
            Controls.Add(Primavera);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Primavera;
        private Button Verano;
        private Button Invierno;
        private PictureBox pictureBox1;
        private Label label1;
    }
}
