namespace HuzureviOtomasyonu
{
    partial class HUZUREVİ_OTOMASYONU
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sAKİNBİLGİLERİToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sAKİNAİLESİToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sAKİNBİLGİLERİToolStripMenuItem,
            this.sAKİNAİLESİToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(971, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sAKİNBİLGİLERİToolStripMenuItem
            // 
            this.sAKİNBİLGİLERİToolStripMenuItem.Name = "sAKİNBİLGİLERİToolStripMenuItem";
            this.sAKİNBİLGİLERİToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.sAKİNBİLGİLERİToolStripMenuItem.Text = "SAKİN BİLGİLERİ";
            this.sAKİNBİLGİLERİToolStripMenuItem.Click += new System.EventHandler(this.sAKİNBİLGİLERİToolStripMenuItem_Click);
            // 
            // sAKİNAİLESİToolStripMenuItem
            // 
            this.sAKİNAİLESİToolStripMenuItem.Name = "sAKİNAİLESİToolStripMenuItem";
            this.sAKİNAİLESİToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.sAKİNAİLESİToolStripMenuItem.Text = "SAKİN AİLE BİLGİLERİ";
            this.sAKİNAİLESİToolStripMenuItem.Click += new System.EventHandler(this.sAKİNAİLESİToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(971, 527);
            this.panel1.TabIndex = 1;
            // 
            // HUZUREVİ_OTOMASYONU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 556);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HUZUREVİ_OTOMASYONU";
            this.Text = "HUZUREVİ_OTOMASYONU";
            this.Load += new System.EventHandler(this.HUZUREVİ_OTOMASYONU_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sAKİNBİLGİLERİToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sAKİNAİLESİToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
    }
}