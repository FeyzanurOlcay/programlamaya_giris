namespace stok
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
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            listBox3 = new ListBox();
            listBox4 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 128);
            button1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(608, 304);
            button1.Name = "button1";
            button1.Size = new Size(161, 65);
            button1.TabIndex = 0;
            button1.Text = "STOK HESAPLA";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Items.AddRange(new object[] { "Yeme - İçme", "Ev Eşyası", "Yeme - İçme", "Teknoloji", "Teknoloji", "Yeme - İçme", "Ev Eşyası" });
            listBox1.Location = new Point(33, 48);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(167, 184);
            listBox1.TabIndex = 1;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Items.AddRange(new object[] { "Domates", "Bardak", "Patates", "Bilgisayar", "Kulaklık", "Elma", "Tabak" });
            listBox2.Location = new Point(240, 48);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(166, 184);
            listBox2.TabIndex = 2;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.Items.AddRange(new object[] { "35", "20", "18", "10", "20", "22", "10" });
            listBox3.Location = new Point(458, 48);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(170, 184);
            listBox3.TabIndex = 3;
            // 
            // listBox4
            // 
            listBox4.BackColor = Color.FromArgb(255, 255, 128);
            listBox4.FormattingEnabled = true;
            listBox4.Location = new Point(679, 48);
            listBox4.Name = "listBox4";
            listBox4.Size = new Size(174, 184);
            listBox4.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 20);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 5;
            label1.Text = "Ürün Grubu :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(240, 20);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 6;
            label2.Text = "Ürün Adı :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(458, 20);
            label3.Name = "label3";
            label3.Size = new Size(92, 20);
            label3.TabIndex = 7;
            label3.Text = "Şuanki Stok :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(679, 20);
            label4.Name = "label4";
            label4.Size = new Size(151, 20);
            label4.TabIndex = 8;
            label4.Text = "1 Hafta Sonraki Stok :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(202, 267);
            label5.Name = "label5";
            label5.Size = new Size(197, 20);
            label5.TabIndex = 9;
            label5.Text = "Haftalık Normal Satış Oranı :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(183, 304);
            label6.Name = "label6";
            label6.Size = new Size(216, 20);
            label6.TabIndex = 10;
            label6.Text = "Yeme - İçme Ekstra Satış Oranı :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(202, 349);
            label7.Name = "label7";
            label7.Size = new Size(194, 20);
            label7.TabIndex = 11;
            label7.Text = "Teknoloji Ekstra Satış Oranı :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(202, 398);
            label8.Name = "label8";
            label8.Size = new Size(186, 20);
            label8.TabIndex = 12;
            label8.Text = "Ev Eşyası Ektra Satış Oranı :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(409, 260);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 13;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(409, 301);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 14;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(409, 346);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 15;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(409, 395);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(927, 450);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox4);
            Controls.Add(listBox3);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ListBox listBox1;
        private ListBox listBox2;
        private ListBox listBox3;
        private ListBox listBox4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
    }
}
