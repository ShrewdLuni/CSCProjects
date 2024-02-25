namespace HomeWork1
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


        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.resultTrapezoidalRule1 = new System.Windows.Forms.Label();
            this.resultMonteCarlo1 = new System.Windows.Forms.Label();
            this.resultTrapezoidalRule2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(104, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(77, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "a:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(104, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(104, 115);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(339, 74);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(339, 117);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 23);
            this.textBox4.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(77, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "b:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(312, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "a:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(312, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "b:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(347, 199);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Calculate";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(90, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Trapezoidal Rule:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(312, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Monte Carlo Method:";
            // 
            // resultTrapezoidalRule1
            // 
            this.resultTrapezoidalRule1.AutoSize = true;
            this.resultTrapezoidalRule1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resultTrapezoidalRule1.Location = new System.Drawing.Point(126, 241);
            this.resultTrapezoidalRule1.Name = "resultTrapezoidalRule1";
            this.resultTrapezoidalRule1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.resultTrapezoidalRule1.Size = new System.Drawing.Size(49, 21);
            this.resultTrapezoidalRule1.TabIndex = 12;
            this.resultTrapezoidalRule1.Text = "result";
            // 
            // resultMonteCarlo1
            // 
            this.resultMonteCarlo1.AutoSize = true;
            this.resultMonteCarlo1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resultMonteCarlo1.Location = new System.Drawing.Point(360, 243);
            this.resultMonteCarlo1.Name = "resultMonteCarlo1";
            this.resultMonteCarlo1.Size = new System.Drawing.Size(49, 21);
            this.resultMonteCarlo1.TabIndex = 13;
            this.resultMonteCarlo1.Text = "result";
            // 
            // resultTrapezoidalRule2
            // 
            this.resultTrapezoidalRule2.AutoSize = true;
            this.resultTrapezoidalRule2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resultTrapezoidalRule2.Location = new System.Drawing.Point(126, 277);
            this.resultTrapezoidalRule2.Name = "resultTrapezoidalRule2";
            this.resultTrapezoidalRule2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.resultTrapezoidalRule2.Size = new System.Drawing.Size(49, 21);
            this.resultTrapezoidalRule2.TabIndex = 14;
            this.resultTrapezoidalRule2.Text = "result";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(53, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 21);
            this.label7.TabIndex = 16;
            this.label7.Text = "Custom:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(287, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 21);
            this.label8.TabIndex = 17;
            this.label8.Text = "Custom:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(53, 277);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 21);
            this.label9.TabIndex = 18;
            this.label9.Text = "Default:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(536, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(186, 21);
            this.label11.TabIndex = 21;
            this.label11.Text = "Monte Carlo visualization";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.WindowText;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(494, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 210);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(339, 156);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 23);
            this.textBox5.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(312, 158);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(22, 21);
            this.label12.TabIndex = 23;
            this.label12.Text = "n:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.resultTrapezoidalRule2);
            this.Controls.Add(this.resultMonteCarlo1);
            this.Controls.Add(this.resultTrapezoidalRule1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button2;
        private Label label5;
        private Label label6;
        private Label resultTrapezoidalRule1;
        private Label resultMonteCarlo1;
        private Label resultTrapezoidalRule2;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label11;
        private PictureBox pictureBox1;
        private TextBox textBox5;
        private Label label12;
    }
}