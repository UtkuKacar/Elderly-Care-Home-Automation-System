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
    public partial class Şifremi_Unuttum : Form
    {
        public Şifremi_Unuttum()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        private void btndisplay_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from girisEkrani where kullaniciAdi = @p1 and guvenlikKelimesi = @p2", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", txtuser.Text);
            cmd.Parameters.AddWithValue("@p2", txtword.Text);

            

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                SqlCommand command = new SqlCommand("update girisEkrani set sifre = @p1 where kullaniciAdi = @p2", bgl.baglanti());
                command.Parameters.AddWithValue("@p1", txtsifre.Text);
                command.Parameters.Add("@p2", txtuser.Text);

                command.ExecuteNonQuery();

                MessageBox.Show("şifre güncellendi");
                bgl.baglanti().Close();


                HUZUREVİ_OTOMASYONU form = new HUZUREVİ_OTOMASYONU();
                form.Show();
                this.Hide();

            }

            else
            {
                MessageBox.Show("giriş hatalı");
            }

            


        }

        private void Şifremi_Unuttum_Load(object sender, EventArgs e)
        {

        }
    }
}
