using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HuzureviOtomasyonu
{
    public partial class HUZUREVİ_OTOMASYONU : Form
    {
        public HUZUREVİ_OTOMASYONU()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        sakinbilgileri sbform;
        private void sAKİNBİLGİLERİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sbform = new sakinbilgileri();
            formGetir(sbform);
            //sbform.Show();
            //this.Hide();
        }

        SAKİNNİN_AİLE_BİLGİLERİ sabform;

        private void sAKİNAİLESİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sabform = new SAKİNNİN_AİLE_BİLGİLERİ();
            formGetir(sabform);
        }

        private void formGetir(Form frm) {

            panel1.Controls.Clear();
            frm.MdiParent= this;
            panel1.Controls.Add(frm);
            frm.Show();
        
        }

        private void HUZUREVİ_OTOMASYONU_Load(object sender, EventArgs e)
        {
            sbform = new sakinbilgileri();
            formGetir(sbform);
        }
    }
}
