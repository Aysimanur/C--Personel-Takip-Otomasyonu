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
using static System.ComponentModel.Design.ObjectSelectorEditor;
using Dapper;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Net.Mime.MediaTypeNames;


namespace WinFormsApp2
{
    public partial class prsonel : Form
    {


        public prsonel()
        {
            InitializeComponent();


        }
        SqlConnection baglanti = new SqlConnection(@"Data Source= LAPTOP-BQVJPLFS; Initial Catalog= pertakip_tomasyonu;Integrated Security=True");
        SqlDataAdapter dr;
        DataSet dss;


        private void verilerigörüntüle()
        {
            listView1.Items.Clear();
            baglanti.Open();



            SqlCommand komut = new SqlCommand("SELECT P.Id, P.kullaniciad, P.prstc, c.cinsiyet, P.prsdogum, k.kangrubuad, b.bolumad, d.birimad, t.turad, n.yetki FROM perbilgi P LEFT OUTER JOIN kangrubu K ON P.kanid = K.Id LEFT OUTER JOIN cinsiyet c ON c.Id = P.cinsiyetid LEFT OUTER JOIN prsbolum b ON b.Id = P.bolumid LEFT OUTER JOIN prsbirim d ON d.Id = P.birimid LEFT OUTER JOIN prstür t ON t.Id = P.prstürid LEFT OUTER JOIN peryetki n On n.Id= P.yetkiId  ", baglanti);

            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())

            {
                Console.WriteLine(oku.ToString());

                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Id"].ToString();
                ekle.SubItems.Add(oku["kullaniciad"].ToString());
                ekle.SubItems.Add(oku["prstc"].ToString());
                ekle.SubItems.Add(oku["cinsiyet"].ToString());
                ekle.SubItems.Add(oku["prsdogum"].ToString());
                ekle.SubItems.Add(oku["kangrubuad"].ToString());
                ekle.SubItems.Add(oku["bolumad"].ToString());
                ekle.SubItems.Add(oku["birimad"].ToString());
                ekle.SubItems.Add(oku["turad"].ToString());
                ekle.SubItems.Add(oku["yetki"].ToString());

                listView1.Items.Add(ekle);


            }

            baglanti.Close();


        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

            listView1.Columns.Add("Id", 40);
            listView1.Columns.Add("Ad-Soyad", 120);
            listView1.Columns.Add("Tc", 100);
            listView1.Columns.Add("Cinsiyet", 70);
            listView1.Columns.Add("Doğum Tarihi", 100);
            listView1.Columns.Add("Kan Grubu", 100);
            listView1.Columns.Add("Bölüm", 90);
            listView1.Columns.Add("Birim", 100);
            listView1.Columns.Add("Personel Türü", 120);
            listView1.Columns.Add("Yetki", 100);

            listView1.View = View.Details;

            listView1.FullRowSelect = true;


            verilerigörüntüle();

            SqlCommand komut = new SqlCommand("select * from cinsiyet", baglanti);


            SqlDataReader dr;
            baglanti.Open();

            dr = komut.ExecuteReader();

            Dictionary<int, string> cinsiyetList = new Dictionary<int, string>();


            while (dr.Read())
                cinsiyetList.Add((int)dr["Id"], (string)dr["cinsiyet"]);

            baglanti.Close();

            comboBox1.DataSource = new BindingSource(cinsiyetList, null);
            comboBox1.DisplayMember = "Value";
            comboBox1.ValueMember = "Key";
            comboBox1.SelectedIndex = -1;


            SqlCommand kmt = new SqlCommand("select * from prsbirim", baglanti);

            SqlDataReader rd;
            baglanti.Open();


            rd = kmt.ExecuteReader();

            Dictionary<int, string> prsbirimList = new Dictionary<int, string>();

            while (rd.Read())

                prsbirimList.Add((int)rd["Id"], (string)rd["birimad"]);


            baglanti.Close();

            cmbbirim.DataSource = new BindingSource(prsbirimList, null);
            cmbbirim.DisplayMember = "Value";
            cmbbirim.ValueMember = "Key";
            cmbbirim.SelectedIndex = -1;


            SqlCommand kt = new SqlCommand("select * from kangrubu", baglanti);
            SqlDataReader rt;
            baglanti.Open();

            rt = kt.ExecuteReader();

            Dictionary<int, string> kangrubuList = new Dictionary<int, string>();
            while (rt.Read())


                kangrubuList.Add((int)rt["Id"], (string)rt["kangrubuad"]);


            baglanti.Close();


            comboBox2.DataSource = new BindingSource(kangrubuList, null);
            comboBox2.DisplayMember = "Value";
            comboBox2.ValueMember = "Key";
            comboBox2.SelectedIndex = -1;


            SqlCommand nd = new SqlCommand("select * from prsbolum", baglanti);
            SqlDataReader d;
            baglanti.Open();
            d = nd.ExecuteReader();


            Dictionary<int, string> prsbolumList = new Dictionary<int, string>();
            while (d.Read())

                prsbolumList.Add((int)d["Id"], (string)d["bolumad"]);


            baglanti.Close();

            cmbbolum.DataSource = new BindingSource(prsbolumList, null);
            cmbbolum.DisplayMember = "Value";
            cmbbolum.ValueMember = "Key";
            cmbbolum.SelectedIndex = -1;


            SqlCommand tr = new SqlCommand("select * from prstür", baglanti);
            SqlDataReader veri;
            baglanti.Open();
            veri = tr.ExecuteReader();
            Dictionary<int, string> prstürList = new Dictionary<int, string>();


            while (veri.Read())

                prstürList.Add((int)veri["Id"], (string)veri["turad"]);


            baglanti.Close();
            cmbtürü.DataSource = new BindingSource(prstürList, null);
            cmbtürü.DisplayMember = "Value";
            cmbtürü.ValueMember = "Key";
            cmbtürü.SelectedIndex = -1;


            SqlCommand yt = new SqlCommand("select * from peryetki", baglanti);
            SqlDataReader re;
            baglanti.Open();
            re = yt.ExecuteReader();
            Dictionary<int, string> yetkiList = new Dictionary<int, string>();
            while (re.Read())
                yetkiList.Add((int)re["Id"], (string)re["yetki"]);
            baglanti.Close();
            cmbyetki.DataSource = new BindingSource(yetkiList, null);
            cmbyetki.DisplayMember = "Value";
            cmbyetki.ValueMember = "Key";
            cmbyetki.SelectedIndex = -1;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {


        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            verilerigörüntüle();


        }

        private void button6_Click_1(object sender, EventArgs e)
        {

        }

        private void button6_Click_2(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {


        }

        private void button6_Click_3(object sender, EventArgs e)
        {


            baglanti.Open();

            SqlCommand komut = new SqlCommand("insert into perbilgi( kullaniciad, prstc, cinsiyetid, prsdogum, kanid, bolumid, birimid, prstürid, yetkiId) values (@kullaniciad, @tc, @cinsiyet, @tarih, @kan, @bolum, @birim, @tur, @yetki)", baglanti);

            komut.Parameters.AddWithValue("@kullaniciad", txtad.Text);
            komut.Parameters.AddWithValue("@tc", txttc.Text);
            komut.Parameters.AddWithValue("@cinsiyet", comboBox1.SelectedValue);
            komut.Parameters.AddWithValue("@tarih", dtpdogum.Value.ToString("yyyy-MM-dd"));
            komut.Parameters.AddWithValue("@kan", comboBox2.SelectedValue);
            komut.Parameters.AddWithValue("@bolum", cmbbolum.SelectedValue);
            komut.Parameters.AddWithValue("@birim", cmbbirim.SelectedValue);
            komut.Parameters.AddWithValue("@tur", cmbtürü.SelectedValue);
            komut.Parameters.AddWithValue("@yetki", cmbyetki.SelectedValue);


            komut.ExecuteNonQuery();

            MessageBox.Show("Personel kaydı yapıldı");
            baglanti.Close();
            verilerigörüntüle();



        }
        private void rbbeyaz_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void label18_TextChanged(object sender, EventArgs e)
        {


        }

        private void rbmavi_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                int secim = listView1.SelectedItems[0].Index;
                txtıd.Text = listView1.Items[secim].SubItems[0].Text;
                txtad.Text = listView1.Items[secim].SubItems[1].Text;
                txttc.Text = listView1.Items[secim].SubItems[2].Text;
                comboBox1.Text = listView1.Items[secim].SubItems[3].Text;
                dtpdogum.Text = listView1.Items[secim].SubItems[4].Text;
                comboBox2.Text = listView1.Items[secim].SubItems[5].Text;
                cmbbolum.Text = listView1.Items[secim].SubItems[6].Text;
                cmbbirim.Text = listView1.Items[secim].SubItems[7].Text;
                cmbtürü.Text = listView1.Items[secim].SubItems[8].Text;
                cmbyetki.Text = listView1.Items[secim].SubItems[9].Text;
            }
        }

        private void label18_Click_1(object sender, EventArgs e)
        {

        }

        private void txtad_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void txtıd_TextChanged(object sender, EventArgs e)
        {

        }


        private void dtpdogum_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnsil_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Kaydı silmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                baglanti.Open();

                SqlCommand komut = new SqlCommand("Delete from perbilgi where Id=@Id", baglanti);

                komut.Parameters.AddWithValue("@Id", txtıd.Text);


                komut.ExecuteNonQuery();
                MessageBox.Show("Kayıt silindi");

                baglanti.Close();
                verilerigörüntüle();
            }

        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Kaydı güncellemek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Update perbilgi Set kullaniciad=@p1,prstc=@p3,cinsiyetid=@p4,prsdogum=@p5,kanid=@p6, bolumid=@p7, birimid=@p8, prstürid=@p9, yetkiId=@p12 where Id=@p11", baglanti);
                komut.Parameters.AddWithValue("@p1", txtad.Text);
                komut.Parameters.AddWithValue("@p3", txttc.Text);
                komut.Parameters.AddWithValue("@p4", comboBox1.SelectedValue);
                komut.Parameters.AddWithValue("@p5", dtpdogum.Value.ToString("yyyy-MM-dd"));
                komut.Parameters.AddWithValue("@p6", comboBox2.SelectedValue);
                komut.Parameters.AddWithValue("@p7", cmbbolum.SelectedValue);
                komut.Parameters.AddWithValue("@p8", cmbbirim.SelectedValue);
                komut.Parameters.AddWithValue("@p9", cmbtürü.SelectedValue);
                komut.Parameters.AddWithValue("@p12", cmbyetki.SelectedValue);



                komut.Parameters.AddWithValue("@p11", txtıd.Text);


                komut.ExecuteNonQuery();
                MessageBox.Show("Güncelleme işlemi yapıldı");
                baglanti.Close();
                verilerigörüntüle();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }


        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbbirim_SelectedIndexChanged(object sender, EventArgs e)
        {

            int selectedBrmId = 0;
            if (cmbbirim.SelectedValue != null && int.TryParse(cmbbirim.SelectedValue.ToString(), out selectedBrmId))
            {
                string query = "SELECT * FROM prsbolum WHERE [brmId] = @brmId";
                using (SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-BQVJPLFS;Initial Catalog=pertakip_tomasyonu;Integrated Security=True"))
                {
                    SqlDataAdapter da = new SqlDataAdapter();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.Add(new SqlParameter("@brmId", selectedBrmId));
                    da.SelectCommand = cmd;
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbbolum.DataSource = dt;
                    cmbbolum.DisplayMember = "bolumad";
                    cmbbolum.ValueMember = "Id";
                }
            }


        }
        private void bttemizle_Click(object sender, EventArgs e)
        {

            txtıd.Clear();
            txtad.Clear();
            txttc.Clear();
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            cmbbolum.SelectedIndex = -1;
            cmbbirim.SelectedIndex = -1;
            cmbtürü.SelectedIndex = -1;

        }

        private void dtpdogum_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }


        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtara_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT P.Id, P.kullaniciad, P.kullanicisifre, P.prstc, c.cinsiyet, P.prsdogum,k.kangrubuad, b.bolumad, d.birimad,t.turad,n.yetki FROM perbilgi P LEFT outer JOIN kangrubu K ON P.kanid = K.Id left outer join cinsiyet c on c.Id = p.cinsiyetid left outer join prsbolum b on b.Id=p.bolumid left outer join prsbirim d on d.Id=p.birimid left outer join prstür t on t.Id=p.prstürid  LEFT OUTER JOIN peryetki n On n.Id= P.yetkiId  where P.Id like '%" + txtıd.Text + "%'", baglanti);

            SqlDataReader oku = komut.ExecuteReader();
            if (!oku.HasRows)
            {
                MessageBox.Show("Girilen değere ait bir kayıt bulunamamıştır.");
            }
            else
            {
                while (oku.Read())
                {

                    ListViewItem ekle = new ListViewItem();
                    ekle.Text = oku["Id"].ToString();
                    ekle.SubItems.Add(oku["kullaniciad"].ToString());
                    ekle.SubItems.Add(oku["prstc"].ToString());
                    ekle.SubItems.Add(oku["cinsiyet"].ToString());
                    ekle.SubItems.Add(oku["prsdogum"].ToString());
                    ekle.SubItems.Add(oku["kangrubuad"].ToString());
                    ekle.SubItems.Add(oku["bolumad"].ToString());
                    ekle.SubItems.Add(oku["birimad"].ToString());
                    ekle.SubItems.Add(oku["turad"].ToString());
                    ekle.SubItems.Add(oku["yetki"].ToString());


                    listView1.Items.Add(ekle);
                }
            }
            baglanti.Close();


        }

        private void txtçıkış_Click(object sender, EventArgs e)
        {
            DialogResult dg;
            dg = MessageBox.Show("Çıkış yapmak istediğinize emin misiniz", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btçıkış_Click(object sender, EventArgs e)
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

        private void txtsifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttc_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Lütfen sayısal değer girin!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                if (txttc.TextLength >= 11 && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                    MessageBox.Show("En fazla 11 karakter girebilirsiniz!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void dtpdogum_Validating(object sender, CancelEventArgs e)
        {
            ErrorProvider errorProvider1 = new ErrorProvider();
            DateTimePicker dtp = dtpdogum;
            if (dtp.Value == DateTimePicker.MinimumDateTime)
            {
                errorProvider1.SetError(dtp, "Lütfen bir tarih seçin.");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(dtp, "");
                e.Cancel = false;
            }

        }

        private void txtsifre_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void cmbbolum_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Anasayfa fr = new Anasayfa();
            fr.Show();
            this.Close();
        }

        private void cmbyetki_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbtürü_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}







