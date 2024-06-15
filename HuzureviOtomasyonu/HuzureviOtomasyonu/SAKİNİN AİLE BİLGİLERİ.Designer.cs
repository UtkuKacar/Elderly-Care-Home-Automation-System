namespace HuzureviOtomasyonu
{
    partial class SAKİNNİN_AİLE_BİLGİLERİ
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
            this.cmbcnsyt = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.button1Kaydet = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.DarkBlue;
            this.dataGridView1.Location = new System.Drawing.Point(12, 283);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(917, 244);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.cmbcnsyt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnupdate);
            this.groupBox1.Controls.Add(this.btndelete);
            this.groupBox1.Controls.Add(this.button1Kaydet);
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
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(917, 265);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kimlik ve Özel Bilgiler";
            // 
            // cmbcnsyt
            // 
            this.cmbcnsyt.FormattingEnabled = true;
            this.cmbcnsyt.Items.AddRange(new object[] {
            "ERKEK",
            "KADIN"});
            this.cmbcnsyt.Location = new System.Drawing.Point(423, 31);
            this.cmbcnsyt.Name = "cmbcnsyt";
            this.cmbcnsyt.Size = new System.Drawing.Size(121, 21);
            this.cmbcnsyt.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(304, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "CİNSİYET";
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(710, 130);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 28;
            this.btnupdate.Text = "GÜNCELLE";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click_1);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(767, 81);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 21);
            this.btndelete.TabIndex = 27;
            this.btndelete.Text = "SİL";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click_1);
            // 
            // button1Kaydet
            // 
            this.button1Kaydet.Location = new System.Drawing.Point(650, 79);
            this.button1Kaydet.Name = "button1Kaydet";
            this.button1Kaydet.Size = new System.Drawing.Size(75, 23);
            this.button1Kaydet.TabIndex = 26;
            this.button1Kaydet.Text = "KAYDET";
            this.button1Kaydet.UseVisualStyleBackColor = true;
            this.button1Kaydet.Click += new System.EventHandler(this.button1Kaydet_Click);
            // 
            // rtxtadres
            // 
            this.rtxtadres.Location = new System.Drawing.Point(423, 143);
            this.rtxtadres.Name = "rtxtadres";
            this.rtxtadres.Size = new System.Drawing.Size(100, 55);
            this.rtxtadres.TabIndex = 15;
            this.rtxtadres.Text = "";
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(137, 109);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(100, 20);
            this.txtsoyad.TabIndex = 13;
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(137, 70);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(100, 20);
            this.txtad.TabIndex = 12;
            // 
            // mtxttelno
            // 
            this.mtxttelno.Location = new System.Drawing.Point(423, 78);
            this.mtxttelno.Mask = "(999) 000-0000";
            this.mtxttelno.Name = "mtxttelno";
            this.mtxttelno.Size = new System.Drawing.Size(100, 20);
            this.mtxttelno.TabIndex = 11;
            // 
            // mtxtdogumtarihi
            // 
            this.mtxtdogumtarihi.Location = new System.Drawing.Point(137, 157);
            this.mtxtdogumtarihi.Mask = "00/00/0000";
            this.mtxtdogumtarihi.Name = "mtxtdogumtarihi";
            this.mtxtdogumtarihi.Size = new System.Drawing.Size(100, 20);
            this.mtxtdogumtarihi.TabIndex = 8;
            this.mtxtdogumtarihi.ValidatingType = typeof(System.DateTime);
            // 
            // mtxttc
            // 
            this.mtxttc.Location = new System.Drawing.Point(137, 26);
            this.mtxttc.Mask = "00000000000";
            this.mtxttc.Name = "mtxttc";
            this.mtxttc.Size = new System.Drawing.Size(100, 20);
            this.mtxttc.TabIndex = 7;
            this.mtxttc.ValidatingType = typeof(int);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(304, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "ADRES";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "DOĞUM TARİHİ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(304, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "TELEFON NO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "SOYADI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ADI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC";
            // 
            // SAKİNNİN_AİLE_BİLGİLERİ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 530);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SAKİNNİN_AİLE_BİLGİLERİ";
            this.Text = "SAKİNİN_AİLE_BİLGİLERİ";
            this.Load += new System.EventHandler(this.SAKİNNİN_AİLE_BİLGİLERİ_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button button1Kaydet;
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
        private System.Windows.Forms.ComboBox cmbcnsyt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnupdate;
    }
}