namespace HuzureviOtomasyonu
{
    partial class YÖNETİCİ
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtmaas = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtis = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mtxtsno = new System.Windows.Forms.MaskedTextBox();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.button1Kaydet = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.rtxtadres = new System.Windows.Forms.RichTextBox();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.mtxttelno = new System.Windows.Forms.MaskedTextBox();
            this.mtxtdogumtarihi = new System.Windows.Forms.MaskedTextBox();
            this.mtxttc = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aYARLARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 317);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(906, 244);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtmaas);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtid);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtis);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.mtxtsno);
            this.groupBox1.Controls.Add(this.btnupdate);
            this.groupBox1.Controls.Add(this.btndelete);
            this.groupBox1.Controls.Add(this.button1Kaydet);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.rtxtadres);
            this.groupBox1.Controls.Add(this.txtsoyad);
            this.groupBox1.Controls.Add(this.txtad);
            this.groupBox1.Controls.Add(this.mtxttelno);
            this.groupBox1.Controls.Add(this.mtxtdogumtarihi);
            this.groupBox1.Controls.Add(this.mtxttc);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(906, 277);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kimlik ve Özel Bilgiler";
            // 
            // txtmaas
            // 
            this.txtmaas.Location = new System.Drawing.Point(110, 221);
            this.txtmaas.Name = "txtmaas";
            this.txtmaas.Size = new System.Drawing.Size(100, 20);
            this.txtmaas.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(295, 223);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 18);
            this.label9.TabIndex = 34;
            this.label9.Text = "ID";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(423, 218);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(22, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 18);
            this.label8.TabIndex = 32;
            this.label8.Text = "Maaş";
            // 
            // txtis
            // 
            this.txtis.Location = new System.Drawing.Point(110, 175);
            this.txtis.Name = "txtis";
            this.txtis.Size = new System.Drawing.Size(100, 20);
            this.txtis.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(22, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 18);
            this.label5.TabIndex = 30;
            this.label5.Text = "İş";
            // 
            // mtxtsno
            // 
            this.mtxtsno.Location = new System.Drawing.Point(423, 26);
            this.mtxtsno.Mask = "0000000000000000000000";
            this.mtxtsno.Name = "mtxtsno";
            this.mtxtsno.Size = new System.Drawing.Size(100, 20);
            this.mtxtsno.TabIndex = 29;
            this.mtxtsno.ValidatingType = typeof(int);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(706, 106);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 28;
            this.btnupdate.Text = "GÜNCELLE";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(769, 41);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 27;
            this.btndelete.Text = "SİL";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // button1Kaydet
            // 
            this.button1Kaydet.Location = new System.Drawing.Point(668, 41);
            this.button1Kaydet.Name = "button1Kaydet";
            this.button1Kaydet.Size = new System.Drawing.Size(75, 23);
            this.button1Kaydet.TabIndex = 26;
            this.button1Kaydet.Text = "KAYDET";
            this.button1Kaydet.UseVisualStyleBackColor = true;
            this.button1Kaydet.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(295, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "SİGORTA NO";
            // 
            // rtxtadres
            // 
            this.rtxtadres.Location = new System.Drawing.Point(423, 140);
            this.rtxtadres.Name = "rtxtadres";
            this.rtxtadres.Size = new System.Drawing.Size(100, 55);
            this.rtxtadres.TabIndex = 15;
            this.rtxtadres.Text = "";
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(110, 94);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(100, 20);
            this.txtsoyad.TabIndex = 13;
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(110, 56);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(100, 20);
            this.txtad.TabIndex = 12;
            // 
            // mtxttelno
            // 
            this.mtxttelno.Location = new System.Drawing.Point(423, 74);
            this.mtxttelno.Mask = "(999) 000-0000";
            this.mtxttelno.Name = "mtxttelno";
            this.mtxttelno.Size = new System.Drawing.Size(100, 20);
            this.mtxttelno.TabIndex = 11;
            // 
            // mtxtdogumtarihi
            // 
            this.mtxtdogumtarihi.Location = new System.Drawing.Point(110, 133);
            this.mtxtdogumtarihi.Mask = "00/00/0000";
            this.mtxtdogumtarihi.Name = "mtxtdogumtarihi";
            this.mtxtdogumtarihi.Size = new System.Drawing.Size(100, 20);
            this.mtxtdogumtarihi.TabIndex = 8;
            this.mtxtdogumtarihi.ValidatingType = typeof(System.DateTime);
            // 
            // mtxttc
            // 
            this.mtxttc.Location = new System.Drawing.Point(110, 23);
            this.mtxttc.Mask = "00000000000";
            this.mtxttc.Name = "mtxttc";
            this.mtxttc.Size = new System.Drawing.Size(100, 20);
            this.mtxttc.TabIndex = 7;
            this.mtxttc.ValidatingType = typeof(int);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(295, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "ADRES";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "DOĞUM TARİHİ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(295, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "TELEFON NO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "SOYADI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ADI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aYARLARToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(934, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aYARLARToolStripMenuItem
            // 
            this.aYARLARToolStripMenuItem.Name = "aYARLARToolStripMenuItem";
            this.aYARLARToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.aYARLARToolStripMenuItem.Text = "AYARLAR";
            this.aYARLARToolStripMenuItem.Click += new System.EventHandler(this.aYARLARToolStripMenuItem_Click);
            // 
            // YÖNETİCİ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 558);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "YÖNETİCİ";
            this.Text = "YÖNETİCİ";
            this.Load += new System.EventHandler(this.YÖNETİCİ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button button1Kaydet;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox rtxtadres;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.MaskedTextBox mtxttelno;
        private System.Windows.Forms.MaskedTextBox mtxtdogumtarihi;
        private System.Windows.Forms.MaskedTextBox mtxttc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtxtsno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtmaas;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtis;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aYARLARToolStripMenuItem;
    }
}
