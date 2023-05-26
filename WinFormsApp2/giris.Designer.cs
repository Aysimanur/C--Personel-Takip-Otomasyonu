namespace WinFormsApp2
{
    partial class giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(giris));
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            checkBox1 = new CheckBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(117, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(99, 110);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(117, 159);
            label5.Name = "label5";
            label5.Size = new Size(10, 15);
            label5.TabIndex = 23;
            label5.Text = ":";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(117, 187);
            label4.Name = "label4";
            label4.Size = new Size(10, 15);
            label4.TabIndex = 22;
            label4.Text = ":";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(41, 187);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 21;
            label2.Text = "Şifre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(41, 156);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 20;
            label1.Text = "Kullanıcı Ad";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Transparent;
            checkBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox1.ForeColor = Color.Black;
            checkBox1.Location = new Point(261, 192);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(60, 19);
            checkBox1.TabIndex = 19;
            checkBox1.Text = "Göster";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(133, 188);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(120, 23);
            textBox2.TabIndex = 18;
            textBox2.TextChanged += textBox2_TextChanged;
            textBox2.KeyPress += textBox2_KeyPress;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(133, 154);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(120, 23);
            textBox1.TabIndex = 17;
            textBox1.Click += textBox1_Click;
            textBox1.TextChanged += Form1_Load;
            // 
            // button1
            // 
            button1.BackColor = Color.Gainsboro;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Desktop;
            button1.Location = new Point(117, 259);
            button1.Name = "button1";
            button1.Size = new Size(99, 31);
            button1.TabIndex = 16;
            button1.Text = "GİRİŞ ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // giris
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.erzurum_orme_askeri_malzeme_slider_arka_plan_1024x453;
            ClientSize = new Size(327, 328);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(checkBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "giris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private CheckBox checkBox1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button1;
    }
}