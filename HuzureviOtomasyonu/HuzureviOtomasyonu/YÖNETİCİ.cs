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
    public partial class YÖNETİCİ : Form
    {
        public YÖNETİCİ()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from calisan", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        
        

        private void YÖNETİCİ_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into calisan (tc,ad,soyad,telNo,sigortaNo,adres,iş,maaş) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bgl.baglanti());

            //cmd.Parameters.AddWithValue("@p1", txtid.Text);
            cmd.Parameters.AddWithValue("@p1", mtxttc.Text);
            cmd.Parameters.AddWithValue("@p2", txtad.Text);
            cmd.Parameters.AddWithValue("@p3", txtsoyad.Text);
            cmd.Parameters.AddWithValue("@p4", mtxttelno.Text);
            cmd.Parameters.AddWithValue("@p5", mtxtsno.Text);
            cmd.Parameters.AddWithValue("@p6", rtxtadres.Text);
            cmd.Parameters.AddWithValue("@p7", txtis.Text);
            cmd.Parameters.AddWithValue("@p8", txtmaas.Text);


            cmd.ExecuteNonQuery();
            bgl.baglanti().Close();
            listele();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update calisan set ad = @p2,soyad = @p3 ,telNo = @p4,sigortaNo = @p5,adres = @p6,iş = @p7,maaş = @p8 ,dogumTarihi = @p9 where tc = @p1", bgl.baglanti());
           // cmd.Parameters.AddWithValue("@p1", mtxttc.Text);
            cmd.Parameters.AddWithValue("@p2", txtad.Text);
            cmd.Parameters.AddWithValue("@p3", txtsoyad.Text);
            cmd.Parameters.AddWithValue("@p4", mtxttelno.Text);
            cmd.Parameters.AddWithValue("@p5", mtxtsno.Text);
            cmd.Parameters.AddWithValue("@p6", rtxtadres.Text);
            cmd.Parameters.AddWithValue("@p7", txtis.Text);
            cmd.Parameters.AddWithValue("@p8", txtmaas.Text);
            cmd.Parameters.AddWithValue("@p9", mtxtdogumtarihi.Text);

            cmd.Parameters.Add("@p1", mtxttc.Text);

            cmd.ExecuteNonQuery();
            bgl.baglanti().Close();
            listele();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            SqlCommand sqlcommand = new SqlCommand("DELETE  FROM calisan WHERE tc = @p1", bgl.baglanti());
            sqlcommand.Parameters.AddWithValue("@p1", mtxttc.Text);
            sqlcommand.ExecuteNonQuery();
            bgl.baglanti().Close();
            listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            mtxttc.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtsoyad.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            mtxtdogumtarihi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            mtxtsno.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            mtxtsno.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            rtxtadres.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtis.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txtmaas.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            
        }

        AYARLAR AYARLAR = new AYARLAR();

        private void aYARLARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AYARLAR = new AYARLAR();
            AYARLAR.Show();


        }
    }
}
