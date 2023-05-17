namespace ProyectoFinal
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
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            label4 = new Label();
            textBox3 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            label5 = new Label();
            label6 = new Label();
            button8 = new Button();
            button9 = new Button();
            textBox4 = new TextBox();
            button7 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(306, 28);
            label1.Name = "label1";
            label1.Size = new Size(182, 48);
            label1.TabIndex = 0;
            label1.Text = "Comandos";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(86, 170);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 29);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(98, 134);
            label2.Name = "label2";
            label2.Size = new Size(70, 25);
            label2.TabIndex = 2;
            label2.Text = "Valor1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(220, 134);
            label3.Name = "label3";
            label3.Size = new Size(70, 25);
            label3.TabIndex = 4;
            label3.Text = "Valor2";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(220, 170);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 29);
            textBox2.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Location = new Point(86, 228);
            button1.Name = "button1";
            button1.Size = new Size(90, 65);
            button1.TabIndex = 5;
            button1.Text = "Sumar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(418, 408);
            label4.Name = "label4";
            label4.Size = new Size(89, 21);
            label4.TabIndex = 6;
            label4.Text = "Resultado";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(513, 404);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(228, 25);
            textBox3.TabIndex = 7;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Location = new Point(86, 287);
            button2.Name = "button2";
            button2.Size = new Size(90, 65);
            button2.TabIndex = 8;
            button2.Text = "Resta";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Location = new Point(211, 228);
            button3.Name = "button3";
            button3.Size = new Size(90, 65);
            button3.TabIndex = 9;
            button3.Text = "Multiplicar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.Location = new Point(211, 287);
            button4.Name = "button4";
            button4.Size = new Size(90, 65);
            button4.TabIndex = 10;
            button4.Text = "Division";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.White;
            button5.Location = new Point(212, 349);
            button5.Name = "button5";
            button5.Size = new Size(89, 58);
            button5.TabIndex = 11;
            button5.Text = "> ---Que";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.White;
            button6.Location = new Point(337, 287);
            button6.Name = "button6";
            button6.Size = new Size(80, 50);
            button6.TabIndex = 12;
            button6.Text = "Cantidades";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(98, 88);
            label5.Name = "label5";
            label5.Size = new Size(158, 25);
            label5.TabIndex = 13;
            label5.Text = "Valores de Texto";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(513, 134);
            label6.Name = "label6";
            label6.Size = new Size(159, 25);
            label6.TabIndex = 14;
            label6.Text = "Cadena de Texto";
            // 
            // button8
            // 
            button8.BackColor = Color.White;
            button8.Location = new Point(86, 342);
            button8.Name = "button8";
            button8.Size = new Size(90, 65);
            button8.TabIndex = 17;
            button8.Text = "Raiz Cuadrada";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.Transparent;
            button9.Location = new Point(684, 28);
            button9.Name = "button9";
            button9.Size = new Size(80, 50);
            button9.TabIndex = 18;
            button9.Text = "Salir";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(513, 187);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(191, 23);
            textBox4.TabIndex = 15;
            // 
            // button7
            // 
            button7.BackColor = Color.White;
            button7.Location = new Point(513, 228);
            button7.Name = "button7";
            button7.Size = new Size(80, 50);
            button7.TabIndex = 16;
            button7.Text = "Contar Texto";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen;
            ClientSize = new Size(800, 455);
            Controls.Add(button7);
            Controls.Add(textBox4);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Form1";
            ShowInTaskbar = false;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private Button button1;
        private Label label4;
        private TextBox textBox3;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Label label5;
        private Label label6;
        private Button button8;
        private Button button9;
        private TextBox textBox4;
        private Button button7;
    }
}