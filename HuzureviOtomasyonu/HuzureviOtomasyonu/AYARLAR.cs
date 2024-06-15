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
    public partial class AYARLAR : Form
    {
        public AYARLAR()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from girisEkrani", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }




        private void AYARLAR_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into girisEkrani (kullaniciAdi,sifre,guvenlikKelimesi) values (@p1,@p2,@p3)", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", txtusername.Text);
            cmd.Parameters.AddWithValue("@p2", txtsifre.Text);
            cmd.Parameters.AddWithValue("@p3", txtword.Text);

            cmd.ExecuteNonQuery();
            bgl.baglanti().Close();
            listele();

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update girisEkrani sifre = @p2 , guvenlikKelimesi = @p3 where kullaniciAdi = @p1",bgl.baglanti());
            cmd.Parameters.AddWithValue("@p2", txtsifre.Text);
            cmd.Parameters.AddWithValue("@p3", txtword.Text);
            cmd.Parameters.Add("@p1", txtusername.Text);

            cmd.ExecuteNonQuery();
            bgl.baglanti().Close();
            listele();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            SqlCommand sqlcommand = new SqlCommand("DELETE  FROM girisEkrani WHERE kullaniciAdi = @p1", bgl.baglanti());
            sqlcommand.Parameters.AddWithValue("@p1", txtusername.Text);
            sqlcommand.ExecuteNonQuery();
            bgl.baglanti().Close();
            listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtusername.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtsifre.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtword.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
