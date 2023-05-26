using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Transparent;

        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            prsonel pr = new prsonel();
            pr.Show();
            this.Close();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Maaş ms = new Maaş();
            ms.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            DialogResult dg;
            dg = MessageBox.Show("Çıkış yapmak istediğinize emin misiniz?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                giris gs = new giris();
                gs.Show();
                this.Close();
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Avans sn = new Avans();
            sn.Show();
            this.Close();
        }

        
    }
}
