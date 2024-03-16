namespace MonteCarlo
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.inputA = new System.Windows.Forms.TextBox();
            this.inputB = new System.Windows.Forms.TextBox();
            this.output = new System.Windows.Forms.Label();
            this.inputN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.image = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 162);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // inputA
            // 
            this.inputA.Location = new System.Drawing.Point(14, 25);
            this.inputA.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.inputA.Name = "inputA";
            this.inputA.Size = new System.Drawing.Size(116, 23);
            this.inputA.TabIndex = 1;
            // 
            // inputB
            // 
            this.inputB.Location = new System.Drawing.Point(14, 73);
            this.inputB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.inputB.Name = "inputB";
            this.inputB.Size = new System.Drawing.Size(116, 23);
            this.inputB.TabIndex = 2;
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.output.Location = new System.Drawing.Point(13, 206);
            this.output.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(45, 20);
            this.output.TabIndex = 3;
            this.output.Text = "none";
            // 
            // inputN
            // 
            this.inputN.Location = new System.Drawing.Point(14, 117);
            this.inputN.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.inputN.Name = "inputN";
            this.inputN.Size = new System.Drawing.Size(116, 23);
            this.inputN.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 247);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "none";
            // 
            // image
            // 
            this.image.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.image.Location = new System.Drawing.Point(349, 12);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(500, 500);
            this.image.TabIndex = 6;
            this.image.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.image);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputN);
            this.Controls.Add(this.output);
            this.Controls.Add(this.inputB);
            this.Controls.Add(this.inputA);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox inputA;
        private System.Windows.Forms.TextBox inputB;
        private System.Windows.Forms.Label output;
        private System.Windows.Forms.TextBox inputN;
        private Label label1;
        private PictureBox image;
    }
}
