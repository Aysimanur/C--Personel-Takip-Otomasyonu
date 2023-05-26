using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics.Eventing.Reader;

namespace WinFormsApp2
{
    public partial class Maaş : Form
    {
        private List<Maas> maaslar = new List<Maas>();

        public Maaş()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source= LAPTOP-BQVJPLFS; Initial Catalog= pertakip_tomasyonu;Integrated Security=True");

        private void verigörüntüle()
        {

            listView1.Items.Clear();
            baglanti.Open();


            SqlCommand komut = new SqlCommand("select p.Id, p.kullaniciad,m.maas,m.prshesapno,m.hesapbakiye,m.ibanno,m.isgiristarih,m.odemetarih,m.odemekurum from maas m LEFT outer join perbilgi p on p.Id=m.prsId ", baglanti);

            SqlDataReader oku = komut.ExecuteReader();
            maaslar.Clear();
            while (oku.Read())

            {
                Console.WriteLine(oku.ToString());
                Maas maas = new Maas();
                //maas.prsId = int.Parse(oku["Id"].ToString());  kodu hata verdiği için okunan veriler null mu değil mi kontrolü yapıldı.
                if (oku["Id"] != DBNull.Value)
                {
                    maas.prsId = Convert.ToInt32(oku["Id"]);
                }

                maas.ad = oku["kullaniciad"].ToString();
                maaslar.Add(maas);


                ListViewItem ekle = new ListViewItem();

                ekle.Text = oku["kullaniciad"].ToString();
                ekle.SubItems.Add(oku["maas"].ToString());
                ekle.SubItems.Add(oku["prshesapno"].ToString());             
                ekle.SubItems.Add(oku["ibanno"].ToString());
                ekle.SubItems.Add(oku["isgiristarih"].ToString());
                ekle.SubItems.Add(oku["odemetarih"].ToString());
                ekle.SubItems.Add(oku["odemekurum"].ToString());



                listView1.Items.Add(ekle);
            }

            baglanti.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listView1.SelectedItems.Count > 0)
            {
                int secim = listView1.SelectedItems[0].Index;
                cmbpersonel.Text = listView1.Items[secim].SubItems[0].Text;
                txtmaas.Text = listView1.Items[secim].SubItems[1].Text;
                txthesap.Text = listView1.Items[secim].SubItems[2].Text;              
                txtiban.Text = listView1.Items[secim].SubItems[3].Text;
                dtgiriş.Text = listView1.Items[secim].SubItems[4].Text;
                dtödeme.Text = listView1.Items[secim].SubItems[5].Text;
                txtkurum.Text = listView1.Items[secim].SubItems[6].Text;
            }
        }

        private void Maaş_Load(object sender, EventArgs e)
        {
            listView1.Columns.Clear();
            listView1.Columns.Add("Ad", 120);
            listView1.Columns.Add("Maaş", 70);
            listView1.Columns.Add("Hesap No", 80);
            listView1.Columns.Add("İban No", 150);
            listView1.Columns.Add("İş Giriş Tarih", 150);
            listView1.Columns.Add("Ödeme Tarihi", 120);
            listView1.Columns.Add("Ödemeyi Yapan Kurum", 150);


            listView1.View = View.Details;
            listView1.FullRowSelect = true;

            verigörüntüle();

            SqlCommand komut = new SqlCommand("SELECT * FROM perbilgi", baglanti);

            SqlDataReader dr;
            baglanti.Open();

            dr = komut.ExecuteReader();
            Dictionary<int, string> perList = new Dictionary<int, string>();


            while (dr.Read())
                perList.Add((int)dr["Id"], (string)dr["kullaniciad"]);
            baglanti.Close();

            cmbpersonel.DataSource = new BindingSource(perList, null);
            cmbpersonel.DisplayMember = "Value";
            cmbpersonel.ValueMember = "Key";
            cmbpersonel.SelectedIndex = -1;

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtkurum_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtgiriş_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtiban_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtgoruntule_Click(object sender, EventArgs e)
        {
            verigörüntüle();
        }

        private void txtmaas_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtkaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("INSERT INTO maas(prsId, maas, prshesapno, hesapbakiye, ibanno, isgiristarih, odemetarih, odemekurum) VALUES (@Id, @maas, @hesapno, 0, @iban, @isgiris, @odemetarih, @odemekurum)", baglanti);
            int kullaniciad = Convert.ToInt32(cmbpersonel.SelectedValue);

            komut.Parameters.AddWithValue("@Id", kullaniciad);
            komut.Parameters.AddWithValue("@maas", txtmaas.Text);
            komut.Parameters.AddWithValue("@hesapno", txthesap.Text);
            komut.Parameters.AddWithValue("@iban", txtiban.Text);
            komut.Parameters.AddWithValue("@isgiris", dtgiriş.Value.ToString("yyyy-MM-dd"));
            komut.Parameters.AddWithValue("@odemetarih", dtödeme.Value.ToString("yyyy-MM-dd"));
            komut.Parameters.AddWithValue("@odemekurum", txtkurum.Text);

            komut.ExecuteNonQuery();

            MessageBox.Show("Personel maaş bilgileri kaydı yapıldı.");

            baglanti.Close();
            verigörüntüle();

        }
        private void txtemizle_Click(object sender, EventArgs e)
        {

            cmbpersonel.SelectedIndex = -1;
            txtemizle.BackColor = Color.Transparent;
            foreach (Control item in this.Controls)
            {
                if (item.GetType().ToString() == "System.Windows.Forms.TextBox") item.Text = "";
            }
        }

        private void txtsil_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Kaydı silmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Delete from maas where prsId=@Id", baglanti);
                int kullaniciad = Convert.ToInt32(cmbpersonel.SelectedValue);
                komut.Parameters.AddWithValue("@Id", kullaniciad);
                komut.ExecuteNonQuery();
                MessageBox.Show("Kayıt silindi");
                baglanti.Close();
                verigörüntüle();
            }
        }

        private void prsId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtgüncelle_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Kaydı güncellemek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand(" Update maas Set maas=@p1,prshesapno=@p3,ibanno=@p5,isgiristarih=@p6,odemetarih=@p7, odemekurum=@p8  where prsId=@p9 ", baglanti);
                int kullaniciad = Convert.ToInt32(cmbpersonel.SelectedValue);

                komut.Parameters.AddWithValue("p9", kullaniciad);
                komut.Parameters.AddWithValue("p1", txtmaas.Text);
                komut.Parameters.AddWithValue("p3", txthesap.Text);             
                komut.Parameters.AddWithValue("p5", txtiban.Text);
                komut.Parameters.AddWithValue("p6", dtgiriş.Value.ToString("yyyy-MM-dd"));
                komut.Parameters.AddWithValue("p7", dtödeme.Value.ToString("yyyy-MM-dd"));
                komut.Parameters.AddWithValue("p8", txtkurum.Text);

                komut.ExecuteNonQuery();
                MessageBox.Show("Güncelleme işlemi yapıldı");
                baglanti.Close();
                verigörüntüle();
            }
         

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnöde_Click(object sender, EventArgs e)
        {
            int secilenPersonelId = Int32.Parse(cmbpersonel.SelectedValue.ToString()); // Combobox'tan personel seçme işlemi

            DateTime simdikiZaman = DateTime.Now;
            int simdikiAy = simdikiZaman.Month;
            int simdikiYil = simdikiZaman.Year;

            baglanti.Open();
            SqlCommand maasKontrolKomut = new SqlCommand("SELECT COUNT(*) FROM maasDetay WHERE userID = @p1 AND YEAR(odemeTarih) = @p2 AND MONTH(odemeTarih) = @p3", baglanti);
            maasKontrolKomut.Parameters.AddWithValue("@p1", secilenPersonelId);
            maasKontrolKomut.Parameters.AddWithValue("@p2", simdikiYil);
            maasKontrolKomut.Parameters.AddWithValue("@p3", simdikiAy);
            int maasDetaySayisi = (int)maasKontrolKomut.ExecuteScalar();
            baglanti.Close();

            if (maasDetaySayisi > 0)
            {
                MessageBox.Show("Bu personele ait maaş ödemesi bu ay için  zaten yapılmıştır.");
                return;
            }

            bool maasOdendi = false;

            List<Maas> maaslar = new List<Maas>(); 

            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * from maas WHERE prsId=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", secilenPersonelId);
            SqlDataReader oku = komut.ExecuteReader();

            maaslar.Clear();
            while (oku.Read())
            {
                Maas ms = new Maas();

                ms.id = Int32.Parse(oku["prsId"].ToString());
                ms.maas = Int32.Parse(oku["maas"].ToString());
                ms.hesapbakiye = Int32.Parse(oku["hesapbakiye"].ToString());

                int anaMaas;
                if (Int32.TryParse(oku["maas"]?.ToString(), out anaMaas))
                {
                    ms.anaMaas = anaMaas;
                }
                else
                {
                    ms.anaMaas = 2300;
                }
                maaslar.Add(ms);
            }
            baglanti.Close();

            List<int> odemeYapilanAylar = new List<int>();

            for (int i = 0; i < maaslar.Count; i++)
            {
                baglanti.Open();
                int id = maaslar[i].id;
                decimal vergiOrani = 0.01m;
                decimal kesintiOrani = 0.01m;
                decimal sigortaPrimOrani = 0.01m;

                decimal brütMaas = maaslar[i].maas + (maaslar[i].maas * vergiOrani) + (maaslar[i].maas * kesintiOrani) + (maaslar[i].maas * sigortaPrimOrani);

                decimal netMaas = maaslar[i].maas;

                SqlCommand k = new SqlCommand("UPDATE maas SET hesapbakiye = @p1, maas=@p3 WHERE prsId = @p2", baglanti);
                k.Parameters.AddWithValue("p1", maaslar[i].hesapbakiye + netMaas);
                k.Parameters.AddWithValue("p2", id);
                k.Parameters.AddWithValue("p3", maaslar[i].anaMaas);
                k.ExecuteNonQuery();

                SqlCommand m = new SqlCommand("INSERT INTO maasDetay (userID, odemeTarih, odenenTutar, vergiler, kesintiler, sigortaPrim, brütMaas, netMaas,odemeTipi) VALUES (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8,@p9)", baglanti);
                m.Parameters.AddWithValue("p1", id);
                m.Parameters.AddWithValue("p2", DateTime.Now);
                m.Parameters.AddWithValue("p3", maaslar[i].maas);
                m.Parameters.AddWithValue("p4", maaslar[i].maas * vergiOrani);
                m.Parameters.AddWithValue("p5", (maaslar[i].maas * kesintiOrani));
                m.Parameters.AddWithValue("p6", (maaslar[i].maas * sigortaPrimOrani));
                m.Parameters.AddWithValue("p7", brütMaas);
                m.Parameters.AddWithValue("p8", netMaas);
                m.Parameters.AddWithValue("p9", "Maaş");

                m.ExecuteNonQuery();

                baglanti.Close();
            }
            verigörüntüle();

            MessageBox.Show("Maaş ödeme işlemi yapıldı.");

        }
        private void dtödeme_ValueChanged(object sender, EventArgs e)
        {
        }

        private void dtgiriş_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void txthesap_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdönem_Click(object sender, EventArgs e)
        {

        }

        private void dtdönem_ValueChanged(object sender, EventArgs e)
        {

        }
        class Maas
        {
            public int id { get; set; }
            public string ad { get; set; }
            public int prsId { get; set; }
            public int maas { get; set; }
            public string prshesapno { get; set; }
            public int hesapbakiye { get; set; }
            public string ibanno { get; set; }
            public DateTime isgiristarih { get; set; }
            public DateTime odemetarih { get; set; }
            public string odemekurum { get; set; }
            public decimal kesintiler { get; set; }
            public decimal vergiler { get; set; }
            public decimal sigortaPrimleri { get; set; }
            public decimal brütmaas { get; set; }
            public decimal netMaas { get; set; }
            public decimal anaMaas { get; set; }

        }
        class Avans
        {
            public int personelId { get; set; }
            public int maas { get; set; }
            public float hesapbakiye { get; set; }
            public DateTime personeldonem { get; set; }
            public DateTime ödemetarih { get; set; }
        }

        private void button1_Click_2(object sender, EventArgs e)
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtavans_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbakiye_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtçıkış_MouseLeave(object sender, EventArgs e)
        {

        }

        private void txtçıkış_BackgroundImageChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            int secim = listView1.SelectedItems[0].Index;


            int Id = maaslar[secim].prsId;

            Form3 f2 = new Form3(Id);
            f2.Show();
            this.Hide();

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void cmbpersonel_SelectedIndexChanged(object sender, EventArgs e)
        {

            using (SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-BQVJPLFS;Initial Catalog=pertakip_tomasyonu;Integrated Security=True"))
            {
                baglanti.Open();

                string personelAdi = cmbpersonel.Text;

                string sorgu = "SELECT * FROM maas WHERE prsId=(SELECT Id FROM perbilgi WHERE kullaniciad=@personelAdi)";

                using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                {
                    komut.Parameters.AddWithValue("@personelAdi", personelAdi);

                    SqlDataAdapter adapter = new SqlDataAdapter(komut);
                    DataSet dataset = new DataSet();
                    adapter.Fill(dataset, "maas");

                    if (dataset.Tables["maas"].Rows.Count > 0)
                    {
                        txtmaas.Text = dataset.Tables["maas"].Rows[0]["maas"].ToString();
                        txthesap.Text = dataset.Tables["maas"].Rows[0]["prshesapno"].ToString();                      
                        txtiban.Text = dataset.Tables["maas"].Rows[0]["ibanno"].ToString();
                        dtgiriş.Value = Convert.ToDateTime(dataset.Tables["maas"].Rows[0]["isgiristarih"]);
                        dtödeme.Value = Convert.ToDateTime(dataset.Tables["maas"].Rows[0]["odemetarih"]);
                        txtkurum.Text = dataset.Tables["maas"].Rows[0]["odemekurum"].ToString();
                    }
                    else
                    {
                        // Veri bulunamadığında TextBox'ların boşaltılması
                        txtmaas.Text = "";
                        txthesap.Text = "";                    
                        txtiban.Text = "";
                        dtgiriş.Value = DateTime.Now;
                        dtödeme.Value = DateTime.Now;
                        txtkurum.Text = "";
                    }
                }

                baglanti.Close();
            }
        }

        private void txtbakiye_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Lütfen sayısal değer girin!", "", MessageBoxButtons.OK);
            }

        }

        private void txtmaas_KeyDown(object sender, KeyEventArgs e)
        {

        }
        private void txtmaas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Lütfen sayısal değer girin!", "", MessageBoxButtons.OK);
            }
        }

        private void txthesap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Lütfen sayısal değer girin!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                if (txthesap.TextLength >= 5 && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                    MessageBox.Show("En fazla 5 karakter girebilirsiniz!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txthesap_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtiban_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtkurum_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtvergi_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Anasayfa fr = new Anasayfa();
            fr.Show();
            this.Close();
        }
    }
}

