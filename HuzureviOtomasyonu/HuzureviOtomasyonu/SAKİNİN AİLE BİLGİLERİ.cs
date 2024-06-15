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
    public partial class SAKİNNİN_AİLE_BİLGİLERİ : Form
    {
        public SAKİNNİN_AİLE_BİLGİLERİ()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from yakinBilgileri", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void SAKİNNİN_AİLE_BİLGİLERİ_Load(object sender, EventArgs e)
        {
            listele();
        }


        private void SAKİNNİN_AİLE_BİLGİLERİ_Load_1(object sender, EventArgs e)
        {
            listele();
        }

        private void button1Kaydet_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into yakinBilgileri (yakinTc,yakinAd,yakinSoyad,dogumTarihi,yakinTel,cinsiyet,yakinAdres) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", mtxttc.Text);
            cmd.Parameters.AddWithValue("@p2", txtad.Text);
            cmd.Parameters.AddWithValue("@p3", txtsoyad.Text);
            cmd.Parameters.AddWithValue("@p4", mtxtdogumtarihi.Text);
            cmd.Parameters.AddWithValue("@p5", mtxttelno.Text);
            cmd.Parameters.AddWithValue("@p6", cmbcnsyt.Text.ToString());
            cmd.Parameters.AddWithValue("@p7", rtxtadres.Text);

            cmd.ExecuteNonQuery();
            bgl.baglanti().Close();
            listele();
        }

        private void btnupdate_Click_1(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update yakinBilgileri set yakinAd = @p2,yakinSoyad = @p3,dogumTarihi = @p4, yakinTel = @p5,cinsiyet = @p6,yakinAdres = @p7 where yakinTc = @p1", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p2", txtad.Text);
            cmd.Parameters.AddWithValue("@p3", txtsoyad.Text);
            cmd.Parameters.AddWithValue("@p4", mtxtdogumtarihi.Text);
            cmd.Parameters.AddWithValue("@p5", mtxttelno.Text);
            cmd.Parameters.AddWithValue("@p6", cmbcnsyt.Text);
            cmd.Parameters.AddWithValue("@p7", rtxtadres.Text);
            cmd.Parameters.Add("@p1", mtxttc.Text);
            cmd.ExecuteNonQuery();
            bgl.baglanti().Close();
            listele();
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            mtxttc.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtsoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            mtxtdogumtarihi.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            mtxttelno.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            cmbcnsyt.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            rtxtadres.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void btndelete_Click_1(object sender, EventArgs e)
        {
            SqlCommand sqlcommand = new SqlCommand("DELETE  FROM yakinBilgileri WHERE yakinTc = @p1", bgl.baglanti());
            sqlcommand.Parameters.AddWithValue("@p1", mtxttc.Text);
            sqlcommand.ExecuteNonQuery();
            bgl.baglanti().Close();
            listele();
        }
    }
}
