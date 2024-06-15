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

namespace HuzureviOtomasyonu
{
    public partial class Giriş : Form
    {
        public Giriş()
        {
            InitializeComponent();
        }
        YÖNETİCİ yoneticiform;
        private void button1_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("select * from yoneticiGiris where kullanciAdi = @p1 and sifre = @p2", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", txtusername.Text);
            cmd.Parameters.AddWithValue("@p2", txtsifre.Text);

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                yoneticiform = new YÖNETİCİ();
                yoneticiform.Show();
                this.Hide();
                bgl.baglanti().Close();
            }


            else
            {
                MessageBox.Show("Hatalı Giriş!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bgl.baglanti().Close();
            }

        }


        HUZUREVİ_OTOMASYONU HOFrom;

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from girisEkrani where kullaniciAdi = @p1 and sifre = @p2",bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", txtusername.Text);
            cmd.Parameters.AddWithValue("@p2",txtsifre.Text);

            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                HOFrom = new HUZUREVİ_OTOMASYONU();
                HOFrom.Show();
                this.Hide();
                bgl.baglanti().Close();
            }


            else
            {
                MessageBox.Show("Hatalı Giriş!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bgl.baglanti().Close();
            }

        }

        Şifremi_Unuttum sifreForm;
        private void button3_Click(object sender, EventArgs e)
        {
            sifreForm = new Şifremi_Unuttum();
            sifreForm.Show();
            this.Hide();
        }

        private void Giriş_Load(object sender, EventArgs e)
        {

        }
    }
}
