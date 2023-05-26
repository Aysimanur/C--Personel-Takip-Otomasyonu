using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Prim : Form
    {
        public Prim()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source= LAPTOP-BQVJPLFS; Initial Catalog= pertakip_tomasyonu;Integrated Security=True");

        List<int> IdList = new List<int>();
        int selectedIndex = 0;
        private void verigoruntule()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select vs.Id, vs.prsId, p.kullaniciad,vs.primMiktar,d.ay,y.yıl,vs.odemeTarih,vs.aciklama,vs.durum from prsPrim vs LEFT outer join perbilgi p on p.Id=vs.prsId LEFT OUTER JOIN tbay d on d.Id=vs.donemAy LEFT OUTER JOIN tbyıl y on y.Id=vs.donemyil", baglanti);

            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())

            {

                ListViewItem ekle = new ListViewItem();

                ekle.Text = oku["kullaniciad"].ToString();
                ekle.SubItems.Add(oku["primMiktar"].ToString());
                ekle.SubItems.Add(oku["ay"].ToString());
                ekle.SubItems.Add(oku["yıl"].ToString());
                ekle.SubItems.Add(oku["odemeTarih"].ToString());
                ekle.SubItems.Add(oku["aciklama"].ToString());
                ekle.SubItems.Add(oku["durum"].ToString());
                listView1.Items.Add(ekle);

            }

            baglanti.Close();
        }

        private void Prim_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("Ad-Soyad", 120);
            listView1.Columns.Add("Prim Miktarı", 120);
            listView1.Columns.Add("Ay", 100);
            listView1.Columns.Add("Yıl", 70);
            listView1.Columns.Add("Ödeme Tarihi", 120);
            listView1.Columns.Add("Açıklama", 130);
            listView1.Columns.Add("Ödeme Durumu", 100);

            listView1.View = View.Details;

            listView1.FullRowSelect = true;

            verigoruntule();

            SqlCommand kmt = new SqlCommand("Select * from tbay", baglanti);

            SqlDataReader rd;
            baglanti.Open();

            rd = kmt.ExecuteReader();
            Dictionary<int, string> ayList = new Dictionary<int, string>();

            while (rd.Read())
                ayList.Add((int)rd["Id"], (string)rd["ay"]);
            baglanti.Close();
            tay.DataSource = new BindingSource(ayList, null);
            tay.DisplayMember = "Value";
            tay.ValueMember = "Key";
            tay.SelectedIndex = -1;



            SqlCommand mt = new SqlCommand("Select * from tbyıl", baglanti);

            SqlDataReader drr;
            baglanti.Open();

            drr = mt.ExecuteReader();
            Dictionary<int, string> yılList = new Dictionary<int, string>();

            while (drr.Read())
                yılList.Add((int)drr["Id"], (string)drr["yıl"]);
            baglanti.Close();
            tyil.DataSource = new BindingSource(yılList, null);
            tyil.DisplayMember = "Value";
            tyil.ValueMember = "Key";
            tyil.SelectedIndex = -1;

            SqlCommand komut = new SqlCommand("SELECT * FROM perbilgi", baglanti);

            SqlDataReader dr;
            baglanti.Open();

            dr = komut.ExecuteReader();
            Dictionary<int, string> perList = new Dictionary<int, string>();


            while (dr.Read())
            {
                perList.Add((int)dr["Id"], (string)dr["kullaniciad"]);
                IdList.Add((int)dr["Id"]);

            }
            baglanti.Close();

            cmbad.DataSource = new BindingSource(perList, null);
            cmbad.DisplayMember = "Value";
            cmbad.ValueMember = "Key";
            cmbad.SelectedIndex = -1;

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Avans sn = new Avans();
            sn.Show();
            this.Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dg;
            dg = MessageBox.Show("Çıkış yapmak istediğinize emin misiniz", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                giris gs = new giris();
                gs.Show();
                this.Close();
            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                int secim = listView1.SelectedItems[0].Index;
                selectedIndex = secim;
                cmbad.Text = listView1.Items[secim].SubItems[0].Text;
                tprim.Text = listView1.Items[secim].SubItems[1].Text;
                tay.Text = listView1.Items[secim].SubItems[2].Text;
                tyil.Text = listView1.Items[secim].SubItems[3].Text;
                dtarih.Text = listView1.Items[secim].SubItems[4].Text;
                taciklama.Text = listView1.Items[secim].SubItems[5].Text;
                txtodeme.Text = listView1.Items[secim].SubItems[6].Text;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            string durum = txtodeme.Text;
            if (durum != "Ödendi")
            {
                string ts = tprim.Text.ToString();
                int tutar = int.Parse(ts);
                int pId = -1;


                if (selectedIndex >= 0 && selectedIndex < IdList.Count)

                {
                    pId = IdList[selectedIndex]; // Geçerli indeksi alıyoruz


                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("SELECT * FROM maas WHERE prsId = @p1", baglanti);
                    komut.Parameters.AddWithValue("@p1", pId);

                    SqlDataReader oku = komut.ExecuteReader();
                    int maas = 0;
                    int bakiye = 0;

                    if (oku.Read())
                    {
                        maas = int.Parse(oku["maas"].ToString());
                        bakiye = int.Parse(oku["hesapbakiye"].ToString());
                    }
                    oku.Close();

                    if (tutar < maas)
                    {
                        bakiye += tutar; 

                        SqlCommand k = new SqlCommand("UPDATE maas SET hesapbakiye = @p1 WHERE prsId = @p2", baglanti);
                        k.Parameters.AddWithValue("@p1", bakiye);
                        k.Parameters.AddWithValue("@p2", pId);
                        k.ExecuteNonQuery();

                        SqlCommand km = new SqlCommand("UPDATE prsPrim SET durum = @p1 WHERE prsId = @p2", baglanti);
                        km.Parameters.AddWithValue("@p1", "Ödendi");
                        km.Parameters.AddWithValue("@p2", pId);
                        km.ExecuteNonQuery();

                        decimal vergiOrani = 0.02m;
                        decimal kesintiOrani = 0.01m;
                        decimal sigortaPrimOrani = 0.01m;
                        decimal brütMaas = tutar + (tutar * vergiOrani) + (tutar * kesintiOrani) + (tutar * sigortaPrimOrani);
                        decimal netMaas = tutar;

                        SqlCommand m = new SqlCommand("INSERT INTO maasDetay (userID, odemeTarih, odenenTutar, vergiler, kesintiler, sigortaPrim, brütMaas, netMaas, odemeTipi) VALUES (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9)", baglanti);
                        m.Parameters.AddWithValue("@p1", pId);
                        m.Parameters.AddWithValue("@p2", DateTime.Now);
                        m.Parameters.AddWithValue("@p3", tutar);
                        m.Parameters.AddWithValue("@p4", tutar * vergiOrani);
                        m.Parameters.AddWithValue("@p5", tutar * kesintiOrani);
                        m.Parameters.AddWithValue("@p6", tutar * sigortaPrimOrani);
                        m.Parameters.AddWithValue("@p7", brütMaas);
                        m.Parameters.AddWithValue("@p8", netMaas);
                        m.Parameters.AddWithValue("@p9", "Prim");
                        m.ExecuteNonQuery();

                        baglanti.Close();


                        MessageBox.Show("Prim ödeme işlemi yapıldı");

                    }

                    baglanti.Close();
                    verigoruntule();
                }
            }

        }

        private void tprim_TextChanged(object sender, EventArgs e)
        {

        }

        private void tprim_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Lütfen sayısal değer girin!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}






