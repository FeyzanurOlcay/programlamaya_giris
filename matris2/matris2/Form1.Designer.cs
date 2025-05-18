namespace matris2
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
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(131, 266);
            button1.Name = "button1";
            button1.Size = new Size(150, 29);
            button1.TabIndex = 0;
            button1.Text = "Tabloyu oluştur";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Items.AddRange(new object[] { "     ADI                               POZİSYONU       " });
            listBox1.Location = new Point(70, 68);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(293, 184);
            listBox1.TabIndex = 1;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(461, 68);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(218, 184);
            listBox2.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Büro Personeli", "Yazılım Geliştirici", "Pazarlama Uzmanı", "Mühendis", "Yönetici" });
            comboBox1.Location = new Point(492, 267);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(157, 28);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox1);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private ListBox listBox1;
        private ListBox listBox2;
        private ComboBox comboBox1;
    }
}
