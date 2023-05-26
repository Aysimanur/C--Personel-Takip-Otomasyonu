using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class giris : Form
    {

        public giris()
        {
            InitializeComponent();


        }
        SqlConnection baglanti = new SqlConnection(@"Data Source= LAPTOP-BQVJPLFS; Initial Catalog= pertakip_tomasyonu;Integrated Security=True");

        public static string userad, kullanicisifre, yetkiId;


        bool durumkontrol = false;
        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void textBox1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.CheckState == CheckState.Checked)
            {
                textBox2.UseSystemPasswordChar = true;
                checkBox1.Text = "Göster";
            }
            else if (checkBox1.CheckState == CheckState.Unchecked)
            {
                textBox2.UseSystemPasswordChar = false;
                checkBox1.Text = "Gizle";
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Lütfen sayısal değer girin!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş geçilemez.");
                return;
            }

            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT  P.Id, P.kullaniciad,P.userad, P.kullanicisifre, P.prstc, c.cinsiyet, P.prsdogum, k.kangrubuad, b.bolumad, d.birimad, t.turad, n.yetki FROM perbilgi P LEFT OUTER JOIN kangrubu K ON P.kanid = K.Id LEFT OUTER JOIN cinsiyet c ON c.Id = P.cinsiyetid LEFT OUTER JOIN prsbolum b ON b.Id = P.bolumid LEFT OUTER JOIN prsbirim d ON d.Id = P.birimid LEFT OUTER JOIN prstür t ON t.Id = P.prstürid  LEFT OUTER JOIN peryetki n On n.Id= P.yetkiId WHERE P.userad = @userad AND P.kullanicisifre = @kullanicisifre", baglanti);
            komut.Parameters.AddWithValue("@userad", textBox1.Text);
            komut.Parameters.AddWithValue("@kullanicisifre", textBox2.Text);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                durumkontrol = true;
                userad = oku.GetValue(2).ToString();
                kullanicisifre = oku.GetValue(3).ToString();
                yetkiId = oku.GetValue(11).ToString();

                if (yetkiId == "Kullanıcı")
                {

                    int Id = int.Parse(oku.GetValue(0).ToString());
                    this.Hide();
                    Kullanıcı ac = new Kullanıcı(Id);
                    ac.Show();
                }
                else if (yetkiId == "Yönetici")
                {
                    this.Hide();
                    Anasayfa asf = new Anasayfa();
                    asf.Show();
                }

                break;
            }

            if (durumkontrol == false)
            {
                MessageBox.Show("Girdiğiniz bilgilere göre böyle bir kullanıcı bulunamadı.");
            }

            baglanti.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
