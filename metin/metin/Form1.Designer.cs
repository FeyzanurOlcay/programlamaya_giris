namespace metin
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
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(537, 32);
            button1.Name = "button1";
            button1.Size = new Size(122, 29);
            button1.TabIndex = 0;
            button1.Text = "Metini yaz";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(66, 32);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(420, 149);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 9);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 2;
            label1.Text = "Metin :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 230);
            label2.Name = "label2";
            label2.Size = new Size(136, 20);
            label2.TabIndex = 3;
            label2.Text = "Düzenlenmiş Metin";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(66, 253);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(420, 144);
            textBox2.TabIndex = 4;
            // 
            // button2
            // 
            button2.Location = new Point(537, 90);
            button2.Name = "button2";
            button2.Size = new Size(122, 53);
            button2.TabIndex = 5;
            button2.Text = "2 boşluk\r\nvarsa düzelt";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(537, 166);
            button3.Name = "button3";
            button3.Size = new Size(122, 57);
            button3.TabIndex = 6;
            button3.Text = "Küçük harfleri\r\ndüzelt";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(537, 252);
            button4.Name = "button4";
            button4.Size = new Size(122, 29);
            button4.TabIndex = 7;
            button4.Text = "Seda yap";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(537, 311);
            button5.Name = "button5";
            button5.Size = new Size(122, 29);
            button5.TabIndex = 8;
            button5.Text = "kaç kelime var";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(537, 368);
            button6.Name = "button6";
            button6.Size = new Size(122, 29);
            button6.TabIndex = 9;
            button6.Text = "boşluk ekle";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}
