namespace WinFormsApp2
{
    partial class Avans
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            label3 = new Label();
            txtad = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtavans = new TextBox();
            cbmay = new ComboBox();
            cbyıl = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            dtalep = new DateTimePicker();
            dtarih = new DateTimePicker();
            txtacıklama = new TextBox();
            label2 = new Label();
            txtdurum = new TextBox();
            bnprim = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Location = new Point(58, 216);
            listView1.Name = "listView1";
            listView1.Size = new Size(764, 230);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.LightGray;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(829, 14);
            button1.Name = "button1";
            button1.Size = new Size(86, 26);
            button1.TabIndex = 1;
            button1.Text = "Geri";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightGray;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(839, 477);
            button2.Name = "button2";
            button2.Size = new Size(86, 31);
            button2.TabIndex = 2;
            button2.Text = "Çıkış";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.LightGray;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(58, 452);
            button3.Name = "button3";
            button3.Size = new Size(121, 26);
            button3.TabIndex = 19;
            button3.Text = "Avans Öde";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(153, 26);
            label1.Name = "label1";
            label1.Size = new Size(0, 17);
            label1.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(59, 39);
            label3.Name = "label3";
            label3.Size = new Size(78, 17);
            label3.TabIndex = 24;
            label3.Text = "Ad - Soyad:";
            // 
            // txtad
            // 
            txtad.Location = new Point(166, 36);
            txtad.Name = "txtad";
            txtad.Size = new Size(166, 25);
            txtad.TabIndex = 25;
            txtad.TextChanged += textBox1_TextChanged_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(59, 85);
            label4.Name = "label4";
            label4.Size = new Size(94, 17);
            label4.TabIndex = 26;
            label4.Text = "Avans Miktarı:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(58, 173);
            label5.Name = "label5";
            label5.Size = new Size(55, 17);
            label5.TabIndex = 27;
            label5.Text = "Dönem:";
            // 
            // txtavans
            // 
            txtavans.Location = new Point(166, 82);
            txtavans.Name = "txtavans";
            txtavans.Size = new Size(166, 25);
            txtavans.TabIndex = 28;
            // 
            // cbmay
            // 
            cbmay.FormattingEnabled = true;
            cbmay.Location = new Point(163, 170);
            cbmay.Name = "cbmay";
            cbmay.Size = new Size(62, 25);
            cbmay.TabIndex = 29;
            cbmay.SelectedIndexChanged += comboBox1_SelectedIndexChanged_1;
            // 
            // cbyıl
            // 
            cbyıl.FormattingEnabled = true;
            cbyıl.Location = new Point(250, 170);
            cbyıl.Name = "cbyıl";
            cbyıl.Size = new Size(82, 25);
            cbyıl.TabIndex = 30;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Location = new Point(231, 173);
            label6.Name = "label6";
            label6.Size = new Size(13, 17);
            label6.TabIndex = 31;
            label6.Text = "/";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Location = new Point(493, 44);
            label7.Name = "label7";
            label7.Size = new Size(88, 17);
            label7.TabIndex = 32;
            label7.Text = "Ödeme Tarih:";
            label7.Click += label7_Click_1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Location = new Point(493, 85);
            label8.Name = "label8";
            label8.Size = new Size(65, 17);
            label8.TabIndex = 33;
            label8.Text = "Açıklama:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Location = new Point(58, 132);
            label9.Name = "label9";
            label9.Size = new Size(78, 17);
            label9.TabIndex = 34;
            label9.Text = "Talep Tarihi:";
            // 
            // dtalep
            // 
            dtalep.Location = new Point(163, 126);
            dtalep.Name = "dtalep";
            dtalep.Size = new Size(169, 25);
            dtalep.TabIndex = 35;
            // 
            // dtarih
            // 
            dtarih.Location = new Point(587, 39);
            dtarih.Name = "dtarih";
            dtarih.Size = new Size(187, 25);
            dtarih.TabIndex = 36;
            // 
            // txtacıklama
            // 
            txtacıklama.Location = new Point(587, 82);
            txtacıklama.Multiline = true;
            txtacıklama.Name = "txtacıklama";
            txtacıklama.Size = new Size(187, 67);
            txtacıklama.TabIndex = 37;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(472, 173);
            label2.Name = "label2";
            label2.Size = new Size(109, 17);
            label2.TabIndex = 38;
            label2.Text = "Ödeme Durumu:";
            // 
            // txtdurum
            // 
            txtdurum.Location = new Point(587, 170);
            txtdurum.Name = "txtdurum";
            txtdurum.Size = new Size(187, 25);
            txtdurum.TabIndex = 39;
            // 
            // bnprim
            // 
            bnprim.BackColor = Color.LightGray;
            bnprim.FlatStyle = FlatStyle.Flat;
            bnprim.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            bnprim.Location = new Point(198, 452);
            bnprim.Name = "bnprim";
            bnprim.Size = new Size(121, 26);
            bnprim.TabIndex = 40;
            bnprim.Text = "Prim Öde";
            bnprim.UseVisualStyleBackColor = false;
            bnprim.Click += bnprim_Click;
            // 
            // Avans
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.erzurum_orme_askeri_malzeme_slider_arka_plan_1024x453;
            ClientSize = new Size(938, 518);
            Controls.Add(bnprim);
            Controls.Add(txtdurum);
            Controls.Add(label2);
            Controls.Add(txtacıklama);
            Controls.Add(dtarih);
            Controls.Add(dtalep);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(cbyıl);
            Controls.Add(cbmay);
            Controls.Add(txtavans);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtad);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listView1);
            Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = SystemColors.ControlText;
            Name = "Avans";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Avans";
            Load += Avans_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Label label3;
        private TextBox txtad;
        private Label label4;
        private Label label5;
        private TextBox txtavans;
        private ComboBox cbmay;
        private ComboBox cbyıl;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private DateTimePicker dtalep;
        private DateTimePicker dtarih;
        private TextBox txtacıklama;
        private Label label2;
        private TextBox txtdurum;
        private Button bnprim;
    }
}