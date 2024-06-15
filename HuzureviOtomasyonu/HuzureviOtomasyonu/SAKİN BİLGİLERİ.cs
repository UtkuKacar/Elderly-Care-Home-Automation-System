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
    public partial class sakinbilgileri : Form
    {
        public sakinbilgileri()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from SakinBilgileri", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void sakinbilgileri_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into SakinBilgileri (tcNo,sakinAdi,sakinSoyadi,telNo,dogumYeri,dogumTarihi,cinsiyet,kanGrubu,saglikGuvencesi,adresi,rahatsizliklar) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)",bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", mtxttc.Text);
            cmd.Parameters.AddWithValue("@p2", txtad.Text);
            cmd.Parameters.AddWithValue("@p3", txtsoyad.Text);
            cmd.Parameters.AddWithValue("@p4", mtxttelno.Text);
            cmd.Parameters.AddWithValue("@p5", txtdogumyeri.Text);
            cmd.Parameters.AddWithValue("@p6", mtxtdogumtarihi.Text);
            cmd.Parameters.AddWithValue("@p7", cmbcinsiyet.Text.ToString());
            cmd.Parameters.AddWithValue("@p8", cmbkan.Text.ToString());
            cmd.Parameters.AddWithValue("@p9", cmbguvence.Text.ToString());
            cmd.Parameters.AddWithValue("@p10", rtxtadres.Text);
            cmd.Parameters.AddWithValue("@p11", rtxtproblem.Text);

            cmd.ExecuteNonQuery();
            bgl.baglanti().Close();
            listele();

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            SqlCommand sqlcommand = new SqlCommand("DELETE  FROM SakinBilgileri WHERE tcNo = @p1", bgl.baglanti());
            sqlcommand.Parameters.AddWithValue("@p1", mtxttc.Text);
            sqlcommand.ExecuteNonQuery();
            bgl.baglanti().Close();
            listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            mtxttc.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtsoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            mtxttelno.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtdogumyeri.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            mtxtdogumtarihi.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            cmbcinsiyet.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            cmbkan.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            cmbguvence.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            rtxtadres.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            rtxtproblem.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update SakinBilgileri set sakinAdi = @p2,sakinSoyadi = @p3,telNo = @p4,dogumYeri = @p5,dogumTarihi = @p6,cinsiyet = @p7,kanGrubu = @p8,saglikGuvencesi = @p9, adresi = @p10,rahatsizliklar = @p11 where tcNo = @p1", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p2", txtad.Text);
            cmd.Parameters.AddWithValue("@p3", txtsoyad.Text);
            cmd.Parameters.AddWithValue("@p4", mtxttelno.Text);
            cmd.Parameters.AddWithValue("@p5", txtdogumyeri.Text);
            cmd.Parameters.AddWithValue("@p6", mtxtdogumtarihi.Text);
            cmd.Parameters.AddWithValue("@p7", cmbcinsiyet.Text);
            cmd.Parameters.AddWithValue("@p8", cmbkan.Text);
            cmd.Parameters.AddWithValue("@p9", cmbguvence.Text);
            cmd.Parameters.AddWithValue("@p10", rtxtadres.Text);
            cmd.Parameters.AddWithValue("@p11", rtxtproblem.Text);
            cmd.Parameters.Add("@p1", mtxttc.Text);
            cmd.ExecuteNonQuery();
            bgl.baglanti().Close();
            listele();
        }
    }
}
