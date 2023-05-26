namespace WinFormsApp2
{
    partial class Anasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anasayfa));
            panelmenü = new Panel();
            button4 = new Button();
            pictureBox1 = new PictureBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panelmenü.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelmenü
            // 
            panelmenü.BackColor = Color.Gainsboro;
            panelmenü.Controls.Add(button4);
            panelmenü.Controls.Add(pictureBox1);
            panelmenü.Controls.Add(button3);
            panelmenü.Controls.Add(button2);
            panelmenü.Controls.Add(button1);
            panelmenü.Dock = DockStyle.Left;
            panelmenü.Location = new Point(0, 0);
            panelmenü.Name = "panelmenü";
            panelmenü.Size = new Size(519, 391);
            panelmenü.TabIndex = 0;
            panelmenü.Paint += panel1_Paint;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Popup;
            button4.ForeColor = Color.DimGray;
            button4.ImageAlign = ContentAlignment.TopCenter;
            button4.Location = new Point(443, 354);
            button4.Name = "button4";
            button4.Size = new Size(58, 25);
            button4.TabIndex = 5;
            button4.Text = "Çıkış";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(193, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 132);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Popup;
            button3.ForeColor = Color.DimGray;
            button3.ImageAlign = ContentAlignment.TopCenter;
            button3.Location = new Point(154, 260);
            button3.Name = "button3";
            button3.Size = new Size(173, 46);
            button3.TabIndex = 4;
            button3.Text = "Personel Avans İşlemleri";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Popup;
            button2.ForeColor = Color.DimGray;
            button2.ImageAlign = ContentAlignment.TopCenter;
            button2.Location = new Point(291, 190);
            button2.Name = "button2";
            button2.Size = new Size(173, 46);
            button2.TabIndex = 2;
            button2.Text = "Personel Maaş İşlemleri";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = Color.DimGray;
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.Location = new Point(57, 190);
            button1.Name = "button1";
            button1.Size = new Size(173, 49);
            button1.TabIndex = 1;
            button1.Text = "Personel Bilgileri";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_2;
            // 
            // Anasayfa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(513, 391);
            Controls.Add(panelmenü);
            ForeColor = Color.Gainsboro;
            Name = "Anasayfa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Anasayfa";
            Load += Anasayfa_Load;
            panelmenü.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelmenü;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}