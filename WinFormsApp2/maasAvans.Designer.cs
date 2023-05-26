namespace WinFormsApp2
{
    partial class Maaş
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
            txtmaas = new TextBox();
            label6 = new Label();
            listView1 = new ListView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txthesap = new TextBox();
            txtiban = new TextBox();
            label7 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtkurum = new TextBox();
            dtgiriş = new DateTimePicker();
            dtödeme = new DateTimePicker();
            label1 = new Label();
            txtkaydet = new Button();
            txtemizle = new Button();
            txtsil = new Button();
            txtgüncelle = new Button();
            btnöde = new Button();
            txtçıkış = new Button();
            button1 = new Button();
            label12 = new Label();
            cmbpersonel = new ComboBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // txtmaas
            // 
            txtmaas.Location = new Point(152, 46);
            txtmaas.Multiline = true;
            txtmaas.Name = "txtmaas";
            txtmaas.Size = new Size(166, 23);
            txtmaas.TabIndex = 7;
            txtmaas.TextChanged += txtmaas_TextChanged;
            txtmaas.KeyDown += txtmaas_KeyDown;
            txtmaas.KeyPress += txtmaas_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(141, 217);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 10;
            // 
            // listView1
            // 
            listView1.Location = new Point(25, 152);
            listView1.Name = "listView1";
            listView1.Size = new Size(794, 229);
            listView1.TabIndex = 11;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(25, 81);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 14;
            label2.Text = "Hesap Numarası:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(25, 120);
            label3.Name = "label3";
            label3.Size = new Size(87, 15);
            label3.TabIndex = 15;
            label3.Text = "İban Numarası:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(25, 50);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 16;
            label4.Text = "Maaş:";
            // 
            // txthesap
            // 
            txthesap.Location = new Point(152, 78);
            txthesap.Multiline = true;
            txthesap.Name = "txthesap";
            txthesap.Size = new Size(166, 23);
            txthesap.TabIndex = 19;
            txthesap.TextChanged += txthesap_TextChanged;
            txthesap.KeyDown += txthesap_KeyDown;
            txthesap.KeyPress += txthesap_KeyPress;
            // 
            // txtiban
            // 
            txtiban.Location = new Point(152, 112);
            txtiban.Multiline = true;
            txtiban.Name = "txtiban";
            txtiban.Size = new Size(169, 23);
            txtiban.TabIndex = 20;
            txtiban.TextChanged += txtiban_TextChanged;
            txtiban.KeyPress += txtiban_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Location = new Point(474, 25);
            label7.Name = "label7";
            label7.Size = new Size(75, 15);
            label7.TabIndex = 27;
            label7.Text = "İş Giriş Tarihi:";
            label7.Click += label7_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Location = new Point(474, 54);
            label9.Name = "label9";
            label9.Size = new Size(142, 15);
            label9.TabIndex = 29;
            label9.Text = "Ödemenin Yapıldığı Tarih:";
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Location = new Point(474, 86);
            label10.Name = "label10";
            label10.Size = new Size(153, 15);
            label10.TabIndex = 30;
            label10.Text = "Ödemenin Yapıldığı Kurum:";
            label10.Click += label10_Click;
            // 
            // txtkurum
            // 
            txtkurum.Location = new Point(639, 83);
            txtkurum.Multiline = true;
            txtkurum.Name = "txtkurum";
            txtkurum.Size = new Size(169, 23);
            txtkurum.TabIndex = 31;
            txtkurum.TextChanged += txtkurum_TextChanged;
            txtkurum.KeyPress += txtkurum_KeyPress;
            // 
            // dtgiriş
            // 
            dtgiriş.Location = new Point(639, 17);
            dtgiriş.Name = "dtgiriş";
            dtgiriş.Size = new Size(169, 23);
            dtgiriş.TabIndex = 32;
            dtgiriş.ValueChanged += dtgiriş_ValueChanged;
            dtgiriş.KeyDown += dtgiriş_KeyDown;
            // 
            // dtödeme
            // 
            dtödeme.Location = new Point(639, 50);
            dtödeme.Name = "dtödeme";
            dtödeme.Size = new Size(169, 23);
            dtödeme.TabIndex = 34;
            dtödeme.ValueChanged += dtödeme_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(25, 20);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 39;
            label1.Text = "Personel Ad:";
            // 
            // txtkaydet
            // 
            txtkaydet.BackColor = Color.LightGray;
            txtkaydet.FlatStyle = FlatStyle.Flat;
            txtkaydet.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtkaydet.ImageAlign = ContentAlignment.MiddleLeft;
            txtkaydet.Location = new Point(25, 418);
            txtkaydet.Name = "txtkaydet";
            txtkaydet.Size = new Size(75, 31);
            txtkaydet.TabIndex = 43;
            txtkaydet.Text = "KAYDET";
            txtkaydet.UseVisualStyleBackColor = false;
            txtkaydet.Click += txtkaydet_Click;
            // 
            // txtemizle
            // 
            txtemizle.BackColor = Color.LightGray;
            txtemizle.FlatStyle = FlatStyle.Flat;
            txtemizle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtemizle.Location = new Point(191, 418);
            txtemizle.Name = "txtemizle";
            txtemizle.Size = new Size(75, 31);
            txtemizle.TabIndex = 44;
            txtemizle.Text = "TEMİZLE";
            txtemizle.UseVisualStyleBackColor = false;
            txtemizle.Click += txtemizle_Click;
            // 
            // txtsil
            // 
            txtsil.BackColor = Color.LightGray;
            txtsil.BackgroundImageLayout = ImageLayout.None;
            txtsil.FlatStyle = FlatStyle.Flat;
            txtsil.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtsil.ImageAlign = ContentAlignment.MiddleLeft;
            txtsil.Location = new Point(272, 418);
            txtsil.Name = "txtsil";
            txtsil.Size = new Size(79, 31);
            txtsil.TabIndex = 45;
            txtsil.Text = "SİL";
            txtsil.UseVisualStyleBackColor = false;
            txtsil.Click += txtsil_Click;
            // 
            // txtgüncelle
            // 
            txtgüncelle.BackColor = Color.LightGray;
            txtgüncelle.FlatStyle = FlatStyle.Flat;
            txtgüncelle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtgüncelle.ForeColor = SystemColors.Desktop;
            txtgüncelle.ImageAlign = ContentAlignment.MiddleLeft;
            txtgüncelle.Location = new Point(106, 418);
            txtgüncelle.Name = "txtgüncelle";
            txtgüncelle.Size = new Size(79, 31);
            txtgüncelle.TabIndex = 46;
            txtgüncelle.Text = "GÜNCELLE";
            txtgüncelle.UseVisualStyleBackColor = false;
            txtgüncelle.Click += txtgüncelle_Click;
            // 
            // btnöde
            // 
            btnöde.BackColor = Color.LightGray;
            btnöde.FlatStyle = FlatStyle.Flat;
            btnöde.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnöde.Location = new Point(727, 406);
            btnöde.Name = "btnöde";
            btnöde.Size = new Size(92, 30);
            btnöde.TabIndex = 47;
            btnöde.Text = "Maaş Öde";
            btnöde.UseVisualStyleBackColor = false;
            btnöde.Click += btnöde_Click;
            // 
            // txtçıkış
            // 
            txtçıkış.BackColor = Color.LightGray;
            txtçıkış.FlatStyle = FlatStyle.Flat;
            txtçıkış.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtçıkış.ForeColor = SystemColors.ActiveCaptionText;
            txtçıkış.ImageAlign = ContentAlignment.MiddleLeft;
            txtçıkış.Location = new Point(872, 480);
            txtçıkış.Name = "txtçıkış";
            txtçıkış.Size = new Size(54, 26);
            txtçıkış.TabIndex = 50;
            txtçıkış.Text = "Çıkış";
            txtçıkış.UseVisualStyleBackColor = false;
            txtçıkış.BackgroundImageChanged += txtçıkış_BackgroundImageChanged;
            txtçıkış.Click += button1_Click_2;
            txtçıkış.MouseLeave += txtçıkış_MouseLeave;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ScrollBar;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(727, 442);
            button1.Name = "button1";
            button1.Size = new Size(92, 31);
            button1.TabIndex = 55;
            button1.Text = "Maaş Detay";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_3;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(639, 448);
            label12.Name = "label12";
            label12.Size = new Size(82, 17);
            label12.TabIndex = 56;
            label12.Text = "Maaş Detay:";
            label12.Click += label12_Click;
            // 
            // cmbpersonel
            // 
            cmbpersonel.FormattingEnabled = true;
            cmbpersonel.Location = new Point(152, 17);
            cmbpersonel.Name = "cmbpersonel";
            cmbpersonel.Size = new Size(166, 23);
            cmbpersonel.TabIndex = 57;
            cmbpersonel.SelectedIndexChanged += cmbpersonel_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.BackColor = Color.LightGray;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(872, 12);
            button2.Name = "button2";
            button2.Size = new Size(59, 23);
            button2.TabIndex = 62;
            button2.Text = "Geri";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // Maaş
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.erzurum_orme_askeri_malzeme_slider_arka_plan_1024x453;
            ClientSize = new Size(938, 518);
            Controls.Add(button2);
            Controls.Add(cmbpersonel);
            Controls.Add(label12);
            Controls.Add(button1);
            Controls.Add(txtemizle);
            Controls.Add(txtçıkış);
            Controls.Add(btnöde);
            Controls.Add(txtgüncelle);
            Controls.Add(txtsil);
            Controls.Add(txtkaydet);
            Controls.Add(label1);
            Controls.Add(dtödeme);
            Controls.Add(dtgiriş);
            Controls.Add(txtkurum);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(txtiban);
            Controls.Add(txthesap);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(listView1);
            Controls.Add(label6);
            Controls.Add(txtmaas);
            Name = "Maaş";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Maaş_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtmaas;
        private Label label6;
        private ListView listView1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txthesap;
        private TextBox txtiban;
        private Label label7;
        private Label label9;
        private Label label10;
        private TextBox txtkurum;
        private DateTimePicker dtgiriş;
        private DateTimePicker dtödeme;
        private Label label1;
        private Button txtkaydet;
        private Button txtemizle;
        private Button txtsil;
        private Button txtgüncelle;
        private Button btnöde;
        private Button txtçıkış;
        private Button button1;
        private Label label12;
        private ComboBox cmbpersonel;
        private Button button2;
    }
}