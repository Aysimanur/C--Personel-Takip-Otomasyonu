namespace WinFormsApp2
{
    partial class Form3
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
            listView1 = new ListView();
            nameLabel = new Label();
            bolumlabel = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            birimlabel = new Label();
            labeltc = new Label();
            label6 = new Label();
            labeldogum = new Label();
            label7 = new Label();
            labeltur = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Location = new Point(36, 128);
            listView1.Name = "listView1";
            listView1.Size = new Size(856, 349);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.BackColor = Color.Transparent;
            nameLabel.ForeColor = SystemColors.ActiveCaptionText;
            nameLabel.Location = new Point(143, 24);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(37, 15);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "name";
            nameLabel.Click += nameLabel_Click;
            // 
            // bolumlabel
            // 
            bolumlabel.AutoSize = true;
            bolumlabel.BackColor = Color.Transparent;
            bolumlabel.ForeColor = SystemColors.ActiveCaptionText;
            bolumlabel.Location = new Point(368, 26);
            bolumlabel.Name = "bolumlabel";
            bolumlabel.Size = new Size(42, 15);
            bolumlabel.TabIndex = 3;
            bolumlabel.Text = "bolum";
            bolumlabel.Click += label1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(36, 22);
            label1.Name = "label1";
            label1.Size = new Size(28, 17);
            label1.TabIndex = 4;
            label1.Text = "Adı";
            label1.Click += label1_Click_2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(281, 26);
            label2.Name = "label2";
            label2.Size = new Size(47, 17);
            label2.TabIndex = 5;
            label2.Text = "Bölüm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(20, 77);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(281, 57);
            label4.Name = "label4";
            label4.Size = new Size(39, 17);
            label4.TabIndex = 7;
            label4.Text = "Birim";
            label4.Click += label4_Click;
            // 
            // birimlabel
            // 
            birimlabel.AutoSize = true;
            birimlabel.BackColor = Color.Transparent;
            birimlabel.ForeColor = SystemColors.ActiveCaptionText;
            birimlabel.Location = new Point(368, 59);
            birimlabel.Name = "birimlabel";
            birimlabel.Size = new Size(35, 15);
            birimlabel.TabIndex = 8;
            birimlabel.Text = "birim";
            // 
            // labeltc
            // 
            labeltc.AutoSize = true;
            labeltc.BackColor = Color.Transparent;
            labeltc.ForeColor = SystemColors.ActiveCaptionText;
            labeltc.Location = new Point(143, 55);
            labeltc.Name = "labeltc";
            labeltc.Size = new Size(17, 15);
            labeltc.TabIndex = 10;
            labeltc.Text = "tc";
            labeltc.Click += labeltc_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(36, 83);
            label6.Name = "label6";
            label6.Size = new Size(89, 17);
            label6.TabIndex = 11;
            label6.Text = "Doğum Tarihi";
            // 
            // labeldogum
            // 
            labeldogum.AutoSize = true;
            labeldogum.BackColor = Color.Transparent;
            labeldogum.ForeColor = SystemColors.ActiveCaptionText;
            labeldogum.Location = new Point(143, 85);
            labeldogum.Name = "labeldogum";
            labeldogum.Size = new Size(46, 15);
            labeldogum.TabIndex = 12;
            labeldogum.Text = "dogum";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(281, 85);
            label7.Name = "label7";
            label7.Size = new Size(27, 17);
            label7.TabIndex = 13;
            label7.Text = "Tür";
            // 
            // labeltur
            // 
            labeltur.AutoSize = true;
            labeltur.BackColor = Color.Transparent;
            labeltur.ForeColor = SystemColors.ActiveCaptionText;
            labeltur.Location = new Point(368, 87);
            labeltur.Name = "labeltur";
            labeltur.Size = new Size(22, 15);
            labeltur.TabIndex = 14;
            labeltur.Text = "tur";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(127, 85);
            label8.Name = "label8";
            label8.Size = new Size(10, 15);
            label8.TabIndex = 15;
            label8.Text = ":";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(127, 55);
            label9.Name = "label9";
            label9.Size = new Size(10, 15);
            label9.TabIndex = 16;
            label9.Text = ":";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.ForeColor = SystemColors.ActiveCaptionText;
            label10.Location = new Point(127, 26);
            label10.Name = "label10";
            label10.Size = new Size(10, 15);
            label10.TabIndex = 17;
            label10.Text = ":";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.ForeColor = SystemColors.ActiveCaptionText;
            label11.Location = new Point(352, 26);
            label11.Name = "label11";
            label11.Size = new Size(10, 15);
            label11.TabIndex = 18;
            label11.Text = ":";
            label11.Click += label11_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.ForeColor = SystemColors.ActiveCaptionText;
            label12.Location = new Point(352, 59);
            label12.Name = "label12";
            label12.Size = new Size(10, 15);
            label12.TabIndex = 19;
            label12.Text = ":";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.ForeColor = SystemColors.ActiveCaptionText;
            label13.Location = new Point(352, 85);
            label13.Name = "label13";
            label13.Size = new Size(10, 15);
            label13.TabIndex = 20;
            label13.Text = ":";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(36, 55);
            label5.Name = "label5";
            label5.Size = new Size(20, 17);
            label5.TabIndex = 21;
            label5.Text = "Tc";
            // 
            // button1
            // 
            button1.Location = new Point(870, 12);
            button1.Name = "button1";
            button1.Size = new Size(56, 23);
            button1.TabIndex = 22;
            button1.Text = "GERİ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(870, 483);
            button2.Name = "button2";
            button2.Size = new Size(56, 23);
            button2.TabIndex = 23;
            button2.Text = "ÇIKIŞ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.erzurum_orme_askeri_malzeme_slider_arka_plan_1024x453;
            ClientSize = new Size(938, 518);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(labeltur);
            Controls.Add(label7);
            Controls.Add(labeldogum);
            Controls.Add(label6);
            Controls.Add(labeltc);
            Controls.Add(birimlabel);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(nameLabel);
            Controls.Add(bolumlabel);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(listView1);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private Label nameLabel;
        private Label bolumlabel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label birimlabel;
        private Label labeltc;
        private Label label6;
        private Label labeldogum;
        private Label label7;
        private Label labeltur;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label5;
        private Button button1;
        private Button button2;
    }
}