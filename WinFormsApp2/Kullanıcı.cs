using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace WinFormsApp2
{
    public partial class Kullanıcı : Form
    {
        private int personId = 0;

        public Kullanıcı(int Id)
        {
            InitializeComponent();
            personId = Id;

            baglanti.Open();

            SqlCommand kmt = new SqlCommand("SELECT P.Id,  P.kullaniciad, P.prstc,c.cinsiyet, P.prsdogum, b.bolumad, d.birimad, t.turad,r.yetki FROM perbilgi P LEFT OUTER JOIN cinsiyet c ON c.Id = P.cinsiyetid  LEFT OUTER JOIN kangrubu K ON P.kanid = K.Id  LEFT OUTER JOIN prsbolum b ON b.Id = P.bolumid  LEFT OUTER JOIN prsbirim d ON d.Id = P.birimid  LEFT OUTER JOIN prstür t ON t.Id = P.prstürid  LEFT OUTER JOIN peryetki r on r.Id=p.yetkiId WHERE P.Id=@p1", baglanti);
            kmt.Parameters.AddWithValue("p1", Id);

            SqlDataReader read = kmt.ExecuteReader();


            while (read.Read())

            {
                namelabel.Text = read["kullaniciad"].ToString();
                labeltc.Text = read["prstc"].ToString();
                labelcinsiyet.Text = read["cinsiyet"].ToString();
                labeldogum.Text = read["prsdogum"].ToString();
                bolumlabel.Text = read["bolumad"].ToString();
                birimlabel.Text = read["birimad"].ToString();
                labeltur.Text = read["turad"].ToString();
                labelyetki.Text = read["yetki"].ToString();
            }

            baglanti.Close();
            baglanti.Open();

            SqlCommand komut = new SqlCommand("select * from maas where prsId=@p2", baglanti);
            komut.Parameters.AddWithValue("p2", Id);

            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())

            {

                namehesap.Text = oku["prshesapno"].ToString();
                nameiban.Text = oku["ibanno"].ToString();
                nametarih.Text = oku["isgiristarih"].ToString();

            }
            baglanti.Close();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source= LAPTOP-BQVJPLFS; Initial Catalog= pertakip_tomasyonu;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void labeldogum_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            AvansTalep asf = new AvansTalep(namelabel.Text);
            asf.Show();
            this.Close();
        }

        private void namelabel_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
        }
        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            string userad = txtad.Text;
            string kullanicisifre = txtsifre.Text;

            SqlCommand selectCommand = new SqlCommand("SELECT * FROM perbilgi WHERE userad=@userad", baglanti);
            selectCommand.Parameters.AddWithValue("@userad", userad);
            SqlDataReader reader = selectCommand.ExecuteReader();

            if (reader.Read())
            {
                reader.Close();

                SqlCommand updateCommand = new SqlCommand("UPDATE perbilgi SET kullanicisifre=@kullanicisifre WHERE userad=@userad", baglanti);
                updateCommand.Parameters.AddWithValue("@kullanicisifre", kullanicisifre);
                updateCommand.Parameters.AddWithValue("@userad", userad);

                int rowsAffected = updateCommand.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Şifreniz güncellendi");
                } 
                else
                {
                    MessageBox.Show("Şifre güncellenirken bir hata oluştu");
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı adı hatalı");
            }

            reader.Close();
            baglanti.Close();

            txtad.Text = "";
            txtsifre.Text = "";

        }
        private void txtsifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsifre_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Lütfen sayısal değer girin!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                if (txtsifre.TextLength >= 6 && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                    MessageBox.Show("En fazla 6 karakter girebilirsiniz!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
        private void label31_Click(object sender, EventArgs e)
        {
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }
    }
}