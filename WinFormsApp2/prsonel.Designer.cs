namespace WinFormsApp2
{
    partial class prsonel
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
            tabControl1 = new TabControl();
            tabPage2 = new TabPage();
            cmbyetki = new ComboBox();
            label1 = new Label();
            button1 = new Button();
            btçıkış = new Button();
            txtara = new Button();
            bttemizle = new Button();
            cmbtürü = new ComboBox();
            listView1 = new ListView();
            txtad = new TextBox();
            txtıd = new TextBox();
            txttc = new TextBox();
            label14 = new Label();
            button6 = new Button();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label11 = new Label();
            label17 = new Label();
            dtpdogum = new DateTimePicker();
            label16 = new Label();
            label15 = new Label();
            cmbbirim = new ComboBox();
            cmbbolum = new ComboBox();
            btnsil = new Button();
            btnguncelle = new Button();
            label13 = new Label();
            label12 = new Label();
            label10 = new Label();
            label8 = new Label();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.AllowDrop = true;
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 4);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(914, 502);
            tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Silver;
            tabPage2.BackgroundImage = Properties.Resources.erzurum_orme_askeri_malzeme_slider_arka_plan_1024x453;
            tabPage2.Controls.Add(cmbyetki);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(btçıkış);
            tabPage2.Controls.Add(txtara);
            tabPage2.Controls.Add(bttemizle);
            tabPage2.Controls.Add(cmbtürü);
            tabPage2.Controls.Add(listView1);
            tabPage2.Controls.Add(txtad);
            tabPage2.Controls.Add(txtıd);
            tabPage2.Controls.Add(txttc);
            tabPage2.Controls.Add(label14);
            tabPage2.Controls.Add(button6);
            tabPage2.Controls.Add(comboBox2);
            tabPage2.Controls.Add(comboBox1);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(label17);
            tabPage2.Controls.Add(dtpdogum);
            tabPage2.Controls.Add(label16);
            tabPage2.Controls.Add(label15);
            tabPage2.Controls.Add(cmbbirim);
            tabPage2.Controls.Add(cmbbolum);
            tabPage2.Controls.Add(btnsil);
            tabPage2.Controls.Add(btnguncelle);
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(label8);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(906, 474);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Personel İşlemleri";
            tabPage2.Click += tabPage2_Click;
            // 
            // cmbyetki
            // 
            cmbyetki.FormattingEnabled = true;
            cmbyetki.Location = new Point(658, 143);
            cmbyetki.Name = "cmbyetki";
            cmbyetki.Size = new Size(136, 23);
            cmbyetki.TabIndex = 49;
            cmbyetki.SelectedIndexChanged += cmbyetki_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(559, 143);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 48;
            label1.Text = "Yetki:";
            // 
            // button1
            // 
            button1.BackColor = Color.LightGray;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(827, 6);
            button1.Name = "button1";
            button1.Size = new Size(64, 24);
            button1.TabIndex = 47;
            button1.Text = "Geri";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // btçıkış
            // 
            btçıkış.BackColor = Color.LightGray;
            btçıkış.FlatStyle = FlatStyle.Flat;
            btçıkış.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btçıkış.Location = new Point(836, 434);
            btçıkış.Name = "btçıkış";
            btçıkış.Size = new Size(64, 26);
            btçıkış.TabIndex = 46;
            btçıkış.Text = "Çıkış";
            btçıkış.UseVisualStyleBackColor = false;
            btçıkış.Click += btçıkış_Click;
            // 
            // txtara
            // 
            txtara.BackColor = Color.LightGray;
            txtara.FlatStyle = FlatStyle.Flat;
            txtara.Location = new Point(294, 12);
            txtara.Name = "txtara";
            txtara.Size = new Size(44, 23);
            txtara.TabIndex = 45;
            txtara.Text = "ARA";
            txtara.UseVisualStyleBackColor = false;
            txtara.Click += txtara_Click;
            // 
            // bttemizle
            // 
            bttemizle.BackColor = Color.LightGray;
            bttemizle.FlatStyle = FlatStyle.Flat;
            bttemizle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            bttemizle.Location = new Point(298, 379);
            bttemizle.Name = "bttemizle";
            bttemizle.Size = new Size(86, 29);
            bttemizle.TabIndex = 44;
            bttemizle.Text = "TEMİZLE";
            bttemizle.UseVisualStyleBackColor = false;
            bttemizle.Click += bttemizle_Click;
            // 
            // cmbtürü
            // 
            cmbtürü.FormattingEnabled = true;
            cmbtürü.Location = new Point(658, 113);
            cmbtürü.Name = "cmbtürü";
            cmbtürü.Size = new Size(136, 23);
            cmbtürü.TabIndex = 43;
            cmbtürü.SelectedIndexChanged += cmbtürü_SelectedIndexChanged;
            // 
            // listView1
            // 
            listView1.Location = new Point(22, 189);
            listView1.Name = "listView1";
            listView1.Size = new Size(772, 183);
            listView1.TabIndex = 42;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged_2;
            // 
            // txtad
            // 
            txtad.Location = new Point(150, 48);
            txtad.Name = "txtad";
            txtad.Size = new Size(135, 23);
            txtad.TabIndex = 40;
            txtad.TextChanged += txtad_TextChanged;
            // 
            // txtıd
            // 
            txtıd.Location = new Point(149, 13);
            txtıd.Name = "txtıd";
            txtıd.Size = new Size(135, 23);
            txtıd.TabIndex = 39;
            txtıd.TextChanged += txtıd_TextChanged;
            // 
            // txttc
            // 
            txttc.Location = new Point(150, 79);
            txttc.Multiline = true;
            txttc.Name = "txttc";
            txttc.Size = new Size(135, 23);
            txttc.TabIndex = 11;
            txttc.TextChanged += textBox9_TextChanged;
            txttc.KeyPress += txttc_KeyPress;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(30, 20);
            label14.Name = "label14";
            label14.Size = new Size(21, 15);
            label14.TabIndex = 38;
            label14.Text = "Id:";
            // 
            // button6
            // 
            button6.BackColor = Color.LightGray;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(22, 378);
            button6.Name = "button6";
            button6.Size = new Size(86, 30);
            button6.TabIndex = 37;
            button6.Text = "KAYDET";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click_3;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(658, 20);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(136, 23);
            comboBox2.TabIndex = 36;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(150, 108);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(135, 23);
            comboBox1.TabIndex = 35;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(30, 116);
            label11.Name = "label11";
            label11.Size = new Size(51, 15);
            label11.TabIndex = 34;
            label11.Text = "Cinsiyet:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.Transparent;
            label17.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label17.Location = new Point(560, 111);
            label17.Name = "label17";
            label17.Size = new Size(34, 15);
            label17.TabIndex = 30;
            label17.Text = "Türü:";
            // 
            // dtpdogum
            // 
            dtpdogum.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dtpdogum.Format = DateTimePickerFormat.Short;
            dtpdogum.Location = new Point(149, 137);
            dtpdogum.Name = "dtpdogum";
            dtpdogum.Size = new Size(136, 23);
            dtpdogum.TabIndex = 28;
            dtpdogum.Value = new DateTime(2023, 4, 17, 11, 50, 25, 0);
            dtpdogum.ValueChanged += dtpdogum_ValueChanged;
            dtpdogum.KeyDown += dtpdogum_KeyDown;
            dtpdogum.Validating += dtpdogum_Validating;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(29, 143);
            label16.Name = "label16";
            label16.Size = new Size(83, 15);
            label16.TabIndex = 27;
            label16.Text = "Doğum Tarihi:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(559, 23);
            label15.Name = "label15";
            label15.Size = new Size(66, 15);
            label15.TabIndex = 23;
            label15.Text = "Kan Grubu:";
            // 
            // cmbbirim
            // 
            cmbbirim.FormattingEnabled = true;
            cmbbirim.Location = new Point(658, 48);
            cmbbirim.Name = "cmbbirim";
            cmbbirim.Size = new Size(136, 23);
            cmbbirim.TabIndex = 19;
            cmbbirim.SelectedIndexChanged += cmbbirim_SelectedIndexChanged;
            // 
            // cmbbolum
            // 
            cmbbolum.FormattingEnabled = true;
            cmbbolum.Location = new Point(658, 79);
            cmbbolum.Name = "cmbbolum";
            cmbbolum.Size = new Size(136, 23);
            cmbbolum.TabIndex = 18;
            cmbbolum.SelectedIndexChanged += cmbbolum_SelectedIndexChanged;
            // 
            // btnsil
            // 
            btnsil.BackColor = Color.LightGray;
            btnsil.FlatStyle = FlatStyle.Flat;
            btnsil.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnsil.Location = new Point(206, 379);
            btnsil.Name = "btnsil";
            btnsil.Size = new Size(86, 29);
            btnsil.TabIndex = 16;
            btnsil.Text = "SİL";
            btnsil.UseVisualStyleBackColor = false;
            btnsil.Click += btnsil_Click;
            // 
            // btnguncelle
            // 
            btnguncelle.BackColor = Color.LightGray;
            btnguncelle.FlatStyle = FlatStyle.Flat;
            btnguncelle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnguncelle.Location = new Point(114, 378);
            btnguncelle.Name = "btnguncelle";
            btnguncelle.Size = new Size(86, 30);
            btnguncelle.TabIndex = 15;
            btnguncelle.Text = "GÜNCELLE";
            btnguncelle.UseVisualStyleBackColor = false;
            btnguncelle.Click += btnguncelle_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(559, 51);
            label13.Name = "label13";
            label13.Size = new Size(38, 15);
            label13.TabIndex = 6;
            label13.Text = "Birim:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(559, 82);
            label12.Name = "label12";
            label12.Size = new Size(45, 15);
            label12.TabIndex = 5;
            label12.Text = "Bölüm:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(30, 82);
            label10.Name = "label10";
            label10.Size = new Size(22, 15);
            label10.TabIndex = 3;
            label10.Text = "Tc:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(29, 48);
            label8.Name = "label8";
            label8.Size = new Size(72, 15);
            label8.TabIndex = 1;
            label8.Text = " Ad / Soyad:";
            label8.Click += label8_Click;
            // 
            // prsonel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 518);
            Controls.Add(tabControl1);
            Name = "prsonel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "prsonel";
            Load += Form2_Load;
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControl1;
        private TabPage tabPage2;
        private ComboBox cmbyetki;
        private Label label1;
        private Button button1;
        private Button btçıkış;
        private Button txtara;
        private Button bttemizle;
        private ComboBox cmbtürü;
        private ListView listView1;
        private TextBox txtad;
        private TextBox txtıd;
        private TextBox txttc;
        private Label label14;
        private Button button6;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label11;
        private Label label17;
        private DateTimePicker dtpdogum;
        private Label label16;
        private Label label15;
        private ComboBox cmbbirim;
        private ComboBox cmbbolum;
        private Button btnsil;
        private Button btnguncelle;
        private Label label13;
        private Label label12;
        private Label label10;
        private Label label8;
    }
}