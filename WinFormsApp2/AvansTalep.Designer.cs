namespace WinFormsApp2
{
    partial class AvansTalep
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
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtavans = new TextBox();
            txtacıklama = new TextBox();
            dtarih = new DateTimePicker();
            label8 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            txtgonder = new Button();
            label14 = new Label();
            label15 = new Label();
            cmay = new ComboBox();
            cmyıl = new ComboBox();
            label16 = new Label();
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
            dtodeme = new DateTimePicker();
            lblad = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(163, 32);
            label1.Name = "label1";
            label1.Size = new Size(206, 17);
            label1.TabIndex = 0;
            label1.Text = "PERSONEL AVANS TALEP FORMU";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(86, 97);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "Ad-Soyad";
            label2.Click += label2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(89, 202);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 4;
            label5.Text = "Talep Tarihi";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(90, 352);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 5;
            label6.Text = "Açıklama";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(86, 145);
            label7.Name = "label7";
            label7.Size = new Size(138, 15);
            label7.TabIndex = 6;
            label7.Text = "Talep Edilen Avans Tutarı";
            label7.Click += label7_Click;
            // 
            // txtavans
            // 
            txtavans.Location = new Point(271, 145);
            txtavans.Name = "txtavans";
            txtavans.Size = new Size(166, 23);
            txtavans.TabIndex = 11;
            txtavans.TextChanged += textBox5_TextChanged;
            // 
            // txtacıklama
            // 
            txtacıklama.Location = new Point(271, 349);
            txtacıklama.Multiline = true;
            txtacıklama.Name = "txtacıklama";
            txtacıklama.Size = new Size(201, 73);
            txtacıklama.TabIndex = 12;
            txtacıklama.TextChanged += textBox6_TextChanged;
            // 
            // dtarih
            // 
            dtarih.Location = new Point(271, 196);
            dtarih.Name = "dtarih";
            dtarih.Size = new Size(166, 23);
            dtarih.TabIndex = 13;
            dtarih.ValueChanged += dtarih_ValueChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(242, 97);
            label8.Name = "label8";
            label8.Size = new Size(10, 15);
            label8.TabIndex = 14;
            label8.Text = ":";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(242, 145);
            label11.Name = "label11";
            label11.Size = new Size(10, 15);
            label11.TabIndex = 17;
            label11.Text = ":";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(242, 197);
            label12.Name = "label12";
            label12.Size = new Size(10, 15);
            label12.TabIndex = 18;
            label12.Text = ":";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(242, 245);
            label13.Name = "label13";
            label13.Size = new Size(10, 15);
            label13.TabIndex = 19;
            label13.Text = ":";
            // 
            // txtgonder
            // 
            txtgonder.BackColor = Color.Silver;
            txtgonder.FlatStyle = FlatStyle.Flat;
            txtgonder.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtgonder.Location = new Point(208, 460);
            txtgonder.Name = "txtgonder";
            txtgonder.Size = new Size(86, 27);
            txtgonder.TabIndex = 20;
            txtgonder.Text = "GÖNDER";
            txtgonder.UseVisualStyleBackColor = false;
            txtgonder.Click += button1_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(89, 250);
            label14.Name = "label14";
            label14.Size = new Size(47, 15);
            label14.TabIndex = 21;
            label14.Text = "Dönem";
            label14.Click += label14_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(242, 349);
            label15.Name = "label15";
            label15.Size = new Size(10, 15);
            label15.TabIndex = 22;
            label15.Text = ":";
            // 
            // cmay
            // 
            cmay.FormattingEnabled = true;
            cmay.Location = new Point(271, 242);
            cmay.Name = "cmay";
            cmay.Size = new Size(61, 23);
            cmay.TabIndex = 23;
            cmay.SelectedIndexChanged += cmay_SelectedIndexChanged;
            // 
            // cmyıl
            // 
            cmyıl.FormattingEnabled = true;
            cmyıl.Location = new Point(356, 242);
            cmyıl.Name = "cmyıl";
            cmyıl.Size = new Size(81, 23);
            cmyıl.TabIndex = 24;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(338, 245);
            label16.Name = "label16";
            label16.Size = new Size(12, 15);
            label16.TabIndex = 25;
            label16.Text = "/";
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(450, 490);
            button1.Name = "button1";
            button1.Size = new Size(75, 27);
            button1.TabIndex = 26;
            button1.Text = "ÇIKIŞ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(90, 300);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 27;
            label3.Text = "Ödeme Tarih:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(242, 300);
            label4.Name = "label4";
            label4.Size = new Size(10, 15);
            label4.TabIndex = 28;
            label4.Text = ":";
            // 
            // dtodeme
            // 
            dtodeme.Location = new Point(271, 300);
            dtodeme.Name = "dtodeme";
            dtodeme.Size = new Size(166, 23);
            dtodeme.TabIndex = 29;
            // 
            // lblad
            // 
            lblad.AutoSize = true;
            lblad.Location = new Point(272, 94);
            lblad.Name = "lblad";
            lblad.Size = new Size(29, 15);
            lblad.TabIndex = 30;
            lblad.Text = "isim";
            lblad.Click += lblad_Click;
            // 
            // AvansTalep
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(537, 529);
            Controls.Add(lblad);
            Controls.Add(dtodeme);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label16);
            Controls.Add(cmyıl);
            Controls.Add(cmay);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(txtgonder);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label8);
            Controls.Add(dtarih);
            Controls.Add(txtacıklama);
            Controls.Add(txtavans);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AvansTalep";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Avans Talep Formu";
            Load += AvansTalep_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtavans;
        private TextBox txtacıklama;
        private DateTimePicker dtarih;
        private Label label8;
        private Label label11;
        private Label label12;
        private Label label13;
        private Button txtgonder;
        private Label label14;
        private Label label15;
        private ComboBox cmay;
        private ComboBox cmyıl;
        private Label label16;
        private Button button1;
        private Label label3;
        private Label label4;
        private DateTimePicker dtodeme;
        private Label lblad;
    }
}