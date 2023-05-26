namespace WinFormsApp2
{
    partial class Prim
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
            lbad = new Label();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            label4 = new Label();
            tprim = new TextBox();
            cmbad = new ComboBox();
            tay = new ComboBox();
            tyil = new ComboBox();
            dtarih = new DateTimePicker();
            taciklama = new TextBox();
            listView1 = new ListView();
            button1 = new Button();
            button2 = new Button();
            btPrim = new Button();
            label5 = new Label();
            txtodeme = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // lbad
            // 
            lbad.AutoSize = true;
            lbad.BackColor = Color.Transparent;
            lbad.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbad.Location = new Point(44, 34);
            lbad.Name = "lbad";
            lbad.Size = new Size(63, 15);
            lbad.TabIndex = 0;
            lbad.Text = "Ad-Soyad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(40, 80);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 1;
            label2.Text = "Prim Miktarı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(44, 124);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 2;
            label3.Text = "Dönem:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(418, 34);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 3;
            label1.Text = "Ödeme Tarihi:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(418, 77);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 4;
            label4.Text = "Açıklama:";
            // 
            // tprim
            // 
            tprim.Location = new Point(133, 77);
            tprim.Name = "tprim";
            tprim.Size = new Size(157, 23);
            tprim.TabIndex = 6;
            tprim.TextChanged += tprim_TextChanged;
            tprim.KeyPress += tprim_KeyPress;
            // 
            // cmbad
            // 
            cmbad.FormattingEnabled = true;
            cmbad.Location = new Point(133, 31);
            cmbad.Name = "cmbad";
            cmbad.Size = new Size(157, 23);
            cmbad.TabIndex = 7;
            // 
            // tay
            // 
            tay.FormattingEnabled = true;
            tay.Location = new Point(133, 121);
            tay.Name = "tay";
            tay.Size = new Size(57, 23);
            tay.TabIndex = 8;
            // 
            // tyil
            // 
            tyil.FormattingEnabled = true;
            tyil.Location = new Point(214, 121);
            tyil.Name = "tyil";
            tyil.Size = new Size(76, 23);
            tyil.TabIndex = 9;
            // 
            // dtarih
            // 
            dtarih.Location = new Point(530, 34);
            dtarih.Name = "dtarih";
            dtarih.Size = new Size(168, 23);
            dtarih.TabIndex = 10;
            dtarih.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // taciklama
            // 
            taciklama.Location = new Point(530, 77);
            taciklama.Multiline = true;
            taciklama.Name = "taciklama";
            taciklama.Size = new Size(168, 36);
            taciklama.TabIndex = 11;
            // 
            // listView1
            // 
            listView1.Location = new Point(44, 185);
            listView1.Name = "listView1";
            listView1.Size = new Size(654, 198);
            listView1.TabIndex = 12;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.LightGray;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(771, 423);
            button1.Name = "button1";
            button1.Size = new Size(75, 26);
            button1.TabIndex = 13;
            button1.Text = "Çıkış";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightGray;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(771, 12);
            button2.Name = "button2";
            button2.Size = new Size(75, 26);
            button2.TabIndex = 14;
            button2.Text = "Geri";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btPrim
            // 
            btPrim.BackColor = Color.LightGray;
            btPrim.FlatStyle = FlatStyle.Flat;
            btPrim.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btPrim.Location = new Point(44, 414);
            btPrim.Name = "btPrim";
            btPrim.Size = new Size(75, 26);
            btPrim.TabIndex = 15;
            btPrim.Text = "Prim Öde";
            btPrim.UseVisualStyleBackColor = false;
            btPrim.Click += button3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(418, 129);
            label5.Name = "label5";
            label5.Size = new Size(93, 15);
            label5.TabIndex = 16;
            label5.Text = "Ödeme Durum:";
            // 
            // txtodeme
            // 
            txtodeme.Location = new Point(530, 129);
            txtodeme.Name = "txtodeme";
            txtodeme.Size = new Size(168, 23);
            txtodeme.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Location = new Point(196, 124);
            label6.Name = "label6";
            label6.Size = new Size(12, 15);
            label6.TabIndex = 18;
            label6.Text = "/";
            // 
            // Prim
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.erzurum_orme_askeri_malzeme_slider_arka_plan_1024x453;
            ClientSize = new Size(858, 461);
            Controls.Add(label6);
            Controls.Add(txtodeme);
            Controls.Add(label5);
            Controls.Add(btPrim);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listView1);
            Controls.Add(taciklama);
            Controls.Add(dtarih);
            Controls.Add(tyil);
            Controls.Add(tay);
            Controls.Add(cmbad);
            Controls.Add(tprim);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbad);
            Name = "Prim";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Prim";
            Load += Prim_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbad;
        private Label label2;
        private Label label3;
        private Label label1;
        private Label label4;
        private TextBox tprim;
        private ComboBox cmbad;
        private ComboBox tay;
        private ComboBox tyil;
        private DateTimePicker dtarih;
        private TextBox taciklama;
        private ListView listView1;
        private Button button1;
        private Button button2;
        private Button btPrim;
        private Label label5;
        private TextBox txtodeme;
        private Label label6;
    }
}