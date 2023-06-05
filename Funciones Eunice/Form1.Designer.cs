namespace Funciones_Eunice
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
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(55, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1230, 650);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Thistle;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1348, 721);
            panel1.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Roboto", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(875, 262);
            label3.Name = "label3";
            label3.Size = new Size(374, 44);
            label3.TabIndex = 4;
            label3.Text = "REGLA DE TRAPECIO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(34, 262);
            label2.Name = "label2";
            label2.Size = new Size(391, 44);
            label2.TabIndex = 3;
            label2.Text = "REGLA DE SIMPSON'S";
            // 
            // button2
            // 
            button2.BackColor = Color.Thistle;
            button2.FlatAppearance.BorderColor = Color.Coral;
            button2.FlatAppearance.BorderSize = 3;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Cooper Black", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(907, 452);
            button2.Name = "button2";
            button2.Size = new Size(303, 121);
            button2.TabIndex = 2;
            button2.Text = "Entrar";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Thistle;
            button1.FlatAppearance.BorderColor = Color.Coral;
            button1.FlatAppearance.BorderSize = 3;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Cooper Black", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(72, 452);
            button1.Name = "button1";
            button1.Size = new Size(303, 121);
            button1.TabIndex = 1;
            button1.Text = "Entrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MidnightBlue;
            label1.Font = new Font("Roboto", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(174, 9);
            label1.Name = "label1";
            label1.Size = new Size(1025, 72);
            label1.TabIndex = 0;
            label1.Text = "Bienvenidos a nuestro proyecto Final";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleVioletRed;
            ClientSize = new Size(1348, 721);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
        private Label label3;
        private Label label2;
        private Button button2;
        private Button button1;
    }
}