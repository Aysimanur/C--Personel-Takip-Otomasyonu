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
    public partial class Form3 : Form
    {
        private int personId = 0;

        public Form3(int personId)
        {
            InitializeComponent();
            this.personId = personId;

            listView1.Items.Clear();
            baglanti.Open();


            SqlCommand komut = new SqlCommand("SELECT * from maasDetay WHERE userId=@p1", baglanti);


            komut.Parameters.AddWithValue("p1", personId);

            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())

            {


                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Id"].ToString();
                ekle.SubItems.Add(oku["UserId"].ToString());
                ekle.SubItems.Add(oku["odemeTarih"].ToString());
                ekle.SubItems.Add(oku["odenenTutar"].ToString());
                ekle.SubItems.Add(oku["vergiler"].ToString());
                ekle.SubItems.Add(oku["kesintiler"].ToString());
                ekle.SubItems.Add(oku["sigortaPrim"].ToString());
                ekle.SubItems.Add(oku["brütMaas"].ToString());
                ekle.SubItems.Add(oku["netMaas"].ToString());
                ekle.SubItems.Add((oku["odemeTipi"] ?? "Maaş").ToString());

                listView1.Items.Add(ekle);

            }
            baglanti.Close();


            baglanti.Open();

            SqlCommand kmt = new SqlCommand("SELECT  P.kullaniciad, P.prstc, P.prsdogum, b.bolumad, d.birimad, t.turad FROM perbilgi P LEFT OUTER JOIN kangrubu K ON P.kanid = K.Id LEFT OUTER JOIN prsbolum b ON b.Id = P.bolumid LEFT OUTER JOIN prsbirim d ON d.Id = P.birimid LEFT OUTER JOIN prstür t ON t.Id = P.prstürid WHERE P.Id=@p1", baglanti);
            kmt.Parameters.AddWithValue("p1", personId);

            SqlDataReader read = kmt.ExecuteReader();


            while (read.Read())

            {
                Label name = this.Controls["nameLabel"] as Label;
                if (name != null)
                {
                    name.Text = read["kullaniciad"].ToString();
                }
                Label tc = this.Controls["labeltc"] as Label;

                if (tc != null)
                {
                    tc.Text = read["prstc"].ToString();
                }

                Label dogum = this.Controls["labeldogum"] as Label;
                if (dogum != null)
                {
                    dogum.Text = read["prsdogum"].ToString();
                }

                Label bolum = this.Controls["bolumlabel"] as Label;
                if (bolum != null)

                {
                    bolum.Text = read["bolumad"].ToString();

                }
                Label birim = this.Controls["birimlabel"] as Label;
                if (birim != null)
                {
                    birim.Text = read["birimad"].ToString();
                }
                Label tur = this.Controls["labeltur"] as Label;

                if (tur != null)
                {
                    tur.Text = read["turad"].ToString();
                }

            }


            baglanti.Close();


        }
        SqlConnection baglanti = new SqlConnection(@"Data Source= LAPTOP-BQVJPLFS; Initial Catalog= pertakip_tomasyonu;Integrated Security=True");


        private void Form3_Load(object sender, EventArgs e)
        {
            listView1.Columns.Clear();
            listView1.Columns.Add("Id", 50);
            listView1.Columns.Add("Kullanıcı Id", 80);
            listView1.Columns.Add("ÖdemeTarih", 60);
            listView1.Columns.Add("Ödenen Tutar", 90);
            listView1.Columns.Add("Vergiler", 90);
            listView1.Columns.Add("Kesintiler", 120);
            listView1.Columns.Add("Sigorta Prim", 80);
            listView1.Columns.Add("Brüt Maaş", 90);
            listView1.Columns.Add("Net Maaş", 100);
            listView1.Columns.Add("Ödeme tipi", 80);

            listView1.View = View.Details;
            listView1.FullRowSelect = true;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Maaş ff = new Maaş();
            ff.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            DialogResult dg;
            dg = MessageBox.Show("Çıkış yapmak istediğinize emin misiniz", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                Close();
            }
        }

        private void labeltc_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
