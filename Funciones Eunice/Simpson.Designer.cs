namespace Funciones_Eunice
{
    partial class Simpson
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            textBox4 = new TextBox();
            label6 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(138, 9);
            label1.Name = "label1";
            label1.Size = new Size(127, 36);
            label1.TabIndex = 0;
            label1.Text = "Funcion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(123, 127);
            label2.Name = "label2";
            label2.Size = new Size(175, 36);
            label2.TabIndex = 1;
            label2.Text = "Intervalo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(123, 310);
            label3.Name = "label3";
            label3.Size = new Size(191, 36);
            label3.TabIndex = 2;
            label3.Text = "Iteraciones";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Info;
            textBox1.Font = new Font("Consolas", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(53, 65);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(325, 39);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Info;
            textBox2.Font = new Font("Consolas", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.Location = new Point(100, 248);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(47, 39);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.Info;
            textBox3.Font = new Font("Consolas", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBox3.Location = new Point(314, 248);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(50, 39);
            textBox3.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(22, 194);
            label4.Name = "label4";
            label4.Size = new Size(168, 27);
            label4.TabIndex = 6;
            label4.Text = "Intervalo a:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Consolas", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(246, 194);
            label5.Name = "label5";
            label5.Size = new Size(168, 27);
            label5.TabIndex = 7;
            label5.Text = "Intervalo b:";
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.Info;
            textBox4.Font = new Font("Consolas", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBox4.Location = new Point(289, 370);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(110, 39);
            textBox4.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Consolas", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(22, 382);
            label6.Name = "label6";
            label6.Size = new Size(220, 27);
            label6.TabIndex = 9;
            label6.Text = "No. Iteraciones:";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Info;
            button1.FlatAppearance.BorderColor = Color.Coral;
            button1.FlatAppearance.BorderSize = 3;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(138, 445);
            button1.Name = "button1";
            button1.Size = new Size(173, 66);
            button1.TabIndex = 10;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Simpson
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(498, 535);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Simpson";
            Text = "Simpson";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label4;
        private Label label5;
        private TextBox textBox4;
        private Label label6;
        private Button button1;
    }
}