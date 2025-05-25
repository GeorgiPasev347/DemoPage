namespace test25_5
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic);
            textBox1.Location = new Point(249, 90);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(157, 38);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic);
            textBox2.Location = new Point(249, 141);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(157, 38);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic);
            textBox3.Location = new Point(249, 198);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(157, 38);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic);
            textBox4.Location = new Point(249, 259);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(157, 38);
            textBox4.TabIndex = 3;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic);
            button1.Location = new Point(211, 332);
            button1.Name = "button1";
            button1.Size = new Size(81, 58);
            button1.TabIndex = 4;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(124, 93);
            label1.Name = "label1";
            label1.Size = new Size(79, 31);
            label1.TabIndex = 5;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(120, 144);
            label2.Name = "label2";
            label2.Size = new Size(102, 31);
            label2.TabIndex = 6;
            label2.Text = "Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(120, 198);
            label3.Name = "label3";
            label3.Size = new Size(85, 31);
            label3.TabIndex = 7;
            label3.Text = "Adress";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(120, 259);
            label4.Name = "label4";
            label4.Size = new Size(98, 31);
            label4.TabIndex = 8;
            label4.Text = "Product";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic);
            label5.Location = new Point(124, 29);
            label5.Name = "label5";
            label5.Size = new Size(253, 31);
            label5.TabIndex = 9;
            label5.Text = "Demo for Saving Data";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
