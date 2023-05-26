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
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp2
{
    public partial class AvansTalep : Form
    {
        string pName;
        public AvansTalep(string name)
        {
            pName = name;

            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source= LAPTOP-BQVJPLFS; Initial Catalog= pertakip_tomasyonu;Integrated Security=True");

        private void AvansTalep_Load(object sender, EventArgs e)
        {
            lblad.Text = pName;
            SqlCommand kmt = new SqlCommand("Select * from tbay", baglanti);

            SqlDataReader rd;
            baglanti.Open();

            rd = kmt.ExecuteReader();
            Dictionary<int, string> ayList = new Dictionary<int, string>();

            while (rd.Read())
                ayList.Add((int)rd["Id"], (string)rd["ay"]);
            baglanti.Close();
            cmay.DataSource = new BindingSource(ayList, null);
            cmay.DisplayMember = "Value";
            cmay.ValueMember = "Key";
            cmay.SelectedIndex = -1;

            SqlCommand mt = new SqlCommand("Select * from tbyıl", baglanti);

            SqlDataReader drr;
            baglanti.Open();

            drr = mt.ExecuteReader();
            Dictionary<int, string> yılList = new Dictionary<int, string>();

            while (drr.Read())
                yılList.Add((int)drr["Id"], (string)drr["yıl"]);
            baglanti.Close();
            cmyıl.DataSource = new BindingSource(yılList, null);
            cmyıl.DisplayMember = "Value";
            cmyıl.ValueMember = "Key";
            cmyıl.SelectedIndex = -1;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label14_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e) //Gönder butonu
        {
            baglanti.Open();

            string kullaniciad = lblad.Text;
            int personId = 0;
            string sql = "SELECT Id FROM perbilgi WHERE kullaniciad = @kullaniciad ";

            using (SqlCommand cmd = new SqlCommand(sql, baglanti))
            {
                cmd.Parameters.AddWithValue("@kullaniciad", kullaniciad);


                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        personId = reader.GetInt32(0);
                    }
                }
            }

            if (personId != 0)
            {
                SqlCommand komut = new SqlCommand("insert into prsAvans(personId,avansMiktar,talepTarihi,donemay,donemyıl,odemetarih,acıklama) values (@Id,@avans,@talep,@ay,@yıl,@tarih,@acıklama)", baglanti);

                int ay = Convert.ToInt32(cmay.SelectedValue);
                int yıl = Convert.ToInt32(cmyıl.SelectedValue);

                komut.Parameters.AddWithValue("@Id", personId);
                komut.Parameters.AddWithValue("@avans", txtavans.Text);
                komut.Parameters.AddWithValue("@talep", dtarih.Value.ToString("yyyy-MM-dd"));
                komut.Parameters.AddWithValue("@ay", ay);
                komut.Parameters.AddWithValue("@yıl", yıl);
                komut.Parameters.AddWithValue("@tarih", dtarih.Value.ToString("yyyy-MM-dd"));
                komut.Parameters.AddWithValue("@acıklama", txtacıklama.Text);

                komut.ExecuteNonQuery();

                MessageBox.Show("Avans talep kaydınız başarıyla alınmıştır.");
            }
            else
            {
                MessageBox.Show("Kullanıcı Bulunamadı.");

            }
            baglanti.Close();

            lblad.Text = "";
            txtavans.Text = "";
            cmay.SelectedIndex = -1;
            cmyıl.SelectedIndex = -1;
            txtacıklama.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e) //Çıkış butonu
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dtarih_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblad_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
