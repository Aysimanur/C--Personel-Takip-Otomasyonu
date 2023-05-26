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
    public partial class Avans : Form
    {

        public Avans()
        {
            InitializeComponent();

        }
        SqlConnection baglanti = new SqlConnection(@"Data Source= LAPTOP-BQVJPLFS; Initial Catalog= pertakip_tomasyonu;Integrated Security=True");

        List<int> IdList = new List<int>();
        int selectedIndex = 0;
        private void verigörüntüle()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select vs.Id, personId, p.kullaniciad,vs.avansMiktar,vs.talepTarihi,d.ay,y.yıl,vs.odemetarih,vs.acıklama,durum  from prsAvans vs  LEFT outer join perbilgi p on p.Id=vs.personId  LEFT OUTER JOIN tbay d on d.Id=vs.donemay LEFT OUTER JOIN tbyıl y on y.Id=vs.donemyıl", baglanti);

            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                IdList.Add(int.Parse(oku["personId"].ToString()));
                Console.WriteLine(oku.ToString());


                ListViewItem ekle = new ListViewItem();

                ekle.Text = oku["kullaniciad"].ToString();
                ekle.SubItems.Add(oku["avansMiktar"].ToString());
                ekle.SubItems.Add(oku["talepTarihi"].ToString());
                ekle.SubItems.Add(oku["ay"].ToString());
                ekle.SubItems.Add(oku["yıl"].ToString());
                ekle.SubItems.Add(oku["odemetarih"].ToString());
                ekle.SubItems.Add(oku["acıklama"].ToString());
                ekle.SubItems.Add(oku["durum"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                int secim = listView1.SelectedItems[0].Index;
                selectedIndex = secim;
                txtad.Text = listView1.Items[secim].SubItems[0].Text;
                txtavans.Text = listView1.Items[secim].SubItems[1].Text;
                dtalep.Text = listView1.Items[secim].SubItems[2].Text;
                cbmay.Text = listView1.Items[secim].SubItems[3].Text;
                cbyıl.Text = listView1.Items[secim].SubItems[4].Text;
                dtarih.Text = listView1.Items[secim].SubItems[5].Text;
                txtacıklama.Text = listView1.Items[secim].SubItems[6].Text;
                txtdurum.Text = listView1.Items[secim].SubItems[7].Text;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Anasayfa fs = new Anasayfa();
            fs.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
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
        private void Avans_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("Ad-Soyad", 120);
            listView1.Columns.Add("Avans Miktarı", 120);
            listView1.Columns.Add("Talep Tarihi", 120);
            listView1.Columns.Add("Ay", 100);
            listView1.Columns.Add("Yıl", 70);
            listView1.Columns.Add("Ödeme Tarihi", 120);
            listView1.Columns.Add("Açıklama", 130);
            listView1.Columns.Add("Durum", 80);

            listView1.View = View.Details;

            listView1.FullRowSelect = true;


            verigörüntüle();

            SqlCommand kmt = new SqlCommand("Select * from tbay", baglanti);

            SqlDataReader rd;
            baglanti.Open();

            rd = kmt.ExecuteReader();
            Dictionary<int, string> ayList = new Dictionary<int, string>();

            while (rd.Read())
                ayList.Add((int)rd["Id"], (string)rd["ay"]);
            baglanti.Close();
            cbmay.DataSource = new BindingSource(ayList, null);
            cbmay.DisplayMember = "Value";
            cbmay.ValueMember = "Key";
            cbmay.SelectedIndex = -1;

            SqlCommand mt = new SqlCommand("Select * from tbyıl", baglanti);

            SqlDataReader drr;
            baglanti.Open();

            drr = mt.ExecuteReader();
            Dictionary<int, string> yılList = new Dictionary<int, string>();

            while (drr.Read())
                yılList.Add((int)drr["Id"], (string)drr["yıl"]);
            baglanti.Close();
            cbyıl.DataSource = new BindingSource(yılList, null);
            cbyıl.DisplayMember = "Value";
            cbyıl.ValueMember = "Key";
            cbyıl.SelectedIndex = -1;


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btkaydet_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtavans_TextChanged(object sender, EventArgs e)
        {

        }
        class Avanss
        {
            public int Id { get; set; }
            public int personelId { get; set; }
            public decimal avansMiktar { get; set; }
            public int ay { get; set; }
            public int yıl { get; set; }
            public string acıklama { get; set; }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string durum = txtdurum.Text; //değişken tanımlandı
            if (durum != "Ödendi")
            {
                string ts = txtavans.Text.ToString();
                int tutar = int.Parse(ts);
                int pId = IdList[selectedIndex]; //değişken kullanıldı diziden değer aldı
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select * from maas where prsId= @p1", baglanti);

                komut.Parameters.AddWithValue("p1", pId);

                SqlDataReader oku = komut.ExecuteReader();

                int maas = 0;
                int bakiye = 0;
                while (oku.Read())

                {
                    maas = int.Parse(oku["maas"].ToString());
                    bakiye = int.Parse(oku["hesapbakiye"].ToString());

                }
                baglanti.Close();

                baglanti.Open();
                if (tutar < maas)
                {

                    maas = maas - tutar;
                    SqlCommand k = new SqlCommand("UPDATE maas SET hesapbakiye = @p1, maas=@p3 WHERE prsId = @p2", baglanti); //maas ve hesapbakiye güncellendi
                    k.Parameters.AddWithValue("p1", (bakiye + tutar));
                    k.Parameters.AddWithValue("p2", pId);
                    k.Parameters.AddWithValue("p3", maas);
                    k.ExecuteNonQuery();
                    baglanti.Close();
                    baglanti.Open();
                    SqlCommand km = new SqlCommand("UPDATE prsAvans SET durum = @p1  WHERE personId = @p2", baglanti); //prsAvans tabosunda personId sütunu pId değerine eşit olan satırlarını durumunu güncelledi
                    km.Parameters.AddWithValue("p1", "Ödendi");
                    km.Parameters.AddWithValue("p2", pId);

                    km.ExecuteNonQuery();

                    decimal vergiOrani = 0.02m; 
                    decimal kesintiOrani = 0.01m;
                    decimal sigortaPrimOrani = 0.01m;
                    decimal brütMaas = tutar + (tutar * vergiOrani) + (tutar * kesintiOrani) + (tutar * sigortaPrimOrani);

                    decimal netMaas = tutar;
                    SqlCommand m = new SqlCommand("INSERT INTO maasDetay (userID, odemeTarih, odenenTutar, vergiler, kesintiler, sigortaPrim, brütMaas, netMaas,odemeTipi) VALUES (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8,@p9)", baglanti);
                    m.Parameters.AddWithValue("p1", pId);
                    m.Parameters.AddWithValue("p2", DateTime.Now);
                    m.Parameters.AddWithValue("p3", tutar);
                    m.Parameters.AddWithValue("p4", tutar * vergiOrani);
                    m.Parameters.AddWithValue("p5", tutar * kesintiOrani);
                    m.Parameters.AddWithValue("p6", tutar * sigortaPrimOrani);
                    m.Parameters.AddWithValue("p7", brütMaas);
                    m.Parameters.AddWithValue("p8", netMaas);
                    m.Parameters.AddWithValue("p9", "Avans");

                    m.ExecuteNonQuery();

                    MessageBox.Show("Avans ödeme işlemi yapıldı");
                }
                else
                {
                    MessageBox.Show("Maaşınız istediğiniz tutardan daha küçük olduğu için işlem yapılamıyor.");

                }
                baglanti.Close();
            }
            else
            {
                MessageBox.Show("Avans ödemesi daha önce yapıldı.");
            }
            verigörüntüle();
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void bnprim_Click(object sender, EventArgs e)
        {
            Prim sn = new Prim();
            sn.Show();
            this.Close();
        }
    }
}

