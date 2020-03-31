namespace OtobusOtomasyonHazirlanmasii
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnsIslemler = new System.Windows.Forms.ToolStripMenuItem();
            this.biletSatışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsYonetimAraclar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSeferIslemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSubeIslemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.mnPersonelIslemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.mnOtobüsİşlemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.mnMusteriIslemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.mnMarkaIslemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.mnMasrafIslemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsRaporlar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnTarihBazliRapor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSeferBazliRapor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsYardım = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsCikis = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsIslemler,
            this.mnsYonetimAraclar,
            this.mnsRaporlar,
            this.mnsYardım,
            this.mnsCikis});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(948, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnsIslemler
            // 
            this.mnsIslemler.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.biletSatışToolStripMenuItem});
            this.mnsIslemler.Image = ((System.Drawing.Image)(resources.GetObject("mnsIslemler.Image")));
            this.mnsIslemler.Name = "mnsIslemler";
            this.mnsIslemler.Size = new System.Drawing.Size(93, 24);
            this.mnsIslemler.Text = "Islemler";
            // 
            // biletSatışToolStripMenuItem
            // 
            this.biletSatışToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("biletSatışToolStripMenuItem.BackgroundImage")));
            this.biletSatışToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.biletSatışToolStripMenuItem.Name = "biletSatışToolStripMenuItem";
            this.biletSatışToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.biletSatışToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.biletSatışToolStripMenuItem.Text = "Bilet Satış";
            this.biletSatışToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.biletSatışToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // mnsYonetimAraclar
            // 
            this.mnsYonetimAraclar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnSeferIslemleri,
            this.mnSubeIslemleri,
            this.mnPersonelIslemleri,
            this.mnOtobüsİşlemleri,
            this.mnMusteriIslemleri,
            this.mnMarkaIslemleri,
            this.mnMasrafIslemleri});
            this.mnsYonetimAraclar.Image = ((System.Drawing.Image)(resources.GetObject("mnsYonetimAraclar.Image")));
            this.mnsYonetimAraclar.Name = "mnsYonetimAraclar";
            this.mnsYonetimAraclar.Size = new System.Drawing.Size(164, 24);
            this.mnsYonetimAraclar.Text = "Yönetimsel Araçlar";
            // 
            // mnSeferIslemleri
            // 
            this.mnSeferIslemleri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mnSeferIslemleri.BackgroundImage")));
            this.mnSeferIslemleri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mnSeferIslemleri.Name = "mnSeferIslemleri";
            this.mnSeferIslemleri.Size = new System.Drawing.Size(216, 26);
            this.mnSeferIslemleri.Text = "Sefer Işlemleri";
            this.mnSeferIslemleri.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.mnSeferIslemleri.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // mnSubeIslemleri
            // 
            this.mnSubeIslemleri.Image = ((System.Drawing.Image)(resources.GetObject("mnSubeIslemleri.Image")));
            this.mnSubeIslemleri.Name = "mnSubeIslemleri";
            this.mnSubeIslemleri.Size = new System.Drawing.Size(216, 26);
            this.mnSubeIslemleri.Text = "Şube İşlemler";
            this.mnSubeIslemleri.Click += new System.EventHandler(this.mnSubeIslemleri_Click);
            // 
            // mnPersonelIslemleri
            // 
            this.mnPersonelIslemleri.Image = ((System.Drawing.Image)(resources.GetObject("mnPersonelIslemleri.Image")));
            this.mnPersonelIslemleri.Name = "mnPersonelIslemleri";
            this.mnPersonelIslemleri.Size = new System.Drawing.Size(216, 26);
            this.mnPersonelIslemleri.Text = "Personel İşlemleri";
            // 
            // mnOtobüsİşlemleri
            // 
            this.mnOtobüsİşlemleri.Image = ((System.Drawing.Image)(resources.GetObject("mnOtobüsİşlemleri.Image")));
            this.mnOtobüsİşlemleri.Name = "mnOtobüsİşlemleri";
            this.mnOtobüsİşlemleri.Size = new System.Drawing.Size(216, 26);
            this.mnOtobüsİşlemleri.Text = "Otobüs İşlemleri";
            // 
            // mnMusteriIslemleri
            // 
            this.mnMusteriIslemleri.Image = ((System.Drawing.Image)(resources.GetObject("mnMusteriIslemleri.Image")));
            this.mnMusteriIslemleri.Name = "mnMusteriIslemleri";
            this.mnMusteriIslemleri.Size = new System.Drawing.Size(216, 26);
            this.mnMusteriIslemleri.Text = "Müşteri İşlemleri";
            // 
            // mnMarkaIslemleri
            // 
            this.mnMarkaIslemleri.Image = ((System.Drawing.Image)(resources.GetObject("mnMarkaIslemleri.Image")));
            this.mnMarkaIslemleri.Name = "mnMarkaIslemleri";
            this.mnMarkaIslemleri.Size = new System.Drawing.Size(216, 26);
            this.mnMarkaIslemleri.Text = "Marka İşlemleri";
            // 
            // mnMasrafIslemleri
            // 
            this.mnMasrafIslemleri.Image = ((System.Drawing.Image)(resources.GetObject("mnMasrafIslemleri.Image")));
            this.mnMasrafIslemleri.Name = "mnMasrafIslemleri";
            this.mnMasrafIslemleri.Size = new System.Drawing.Size(216, 26);
            this.mnMasrafIslemleri.Text = "Masraf İşlemleri";
            // 
            // mnsRaporlar
            // 
            this.mnsRaporlar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnTarihBazliRapor,
            this.mnSeferBazliRapor});
            this.mnsRaporlar.Image = ((System.Drawing.Image)(resources.GetObject("mnsRaporlar.Image")));
            this.mnsRaporlar.Name = "mnsRaporlar";
            this.mnsRaporlar.Size = new System.Drawing.Size(98, 24);
            this.mnsRaporlar.Text = "Raporlar";
            // 
            // mnTarihBazliRapor
            // 
            this.mnTarihBazliRapor.Name = "mnTarihBazliRapor";
            this.mnTarihBazliRapor.Size = new System.Drawing.Size(195, 26);
            this.mnTarihBazliRapor.Text = "Tarih Bazlı Rapor";
            // 
            // mnSeferBazliRapor
            // 
            this.mnSeferBazliRapor.Name = "mnSeferBazliRapor";
            this.mnSeferBazliRapor.Size = new System.Drawing.Size(195, 26);
            this.mnSeferBazliRapor.Text = "Sefer Bazlı";
            // 
            // mnsYardım
            // 
            this.mnsYardım.Image = ((System.Drawing.Image)(resources.GetObject("mnsYardım.Image")));
            this.mnsYardım.Name = "mnsYardım";
            this.mnsYardım.Size = new System.Drawing.Size(87, 24);
            this.mnsYardım.Text = "Yardım";
            // 
            // mnsCikis
            // 
            this.mnsCikis.Image = ((System.Drawing.Image)(resources.GetObject("mnsCikis.Image")));
            this.mnsCikis.Name = "mnsCikis";
            this.mnsCikis.Size = new System.Drawing.Size(71, 24);
            this.mnsCikis.Text = "Çıkış";
            this.mnsCikis.Click += new System.EventHandler(this.mnsCikis_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(948, 582);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "Ana Menü";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnsIslemler;
        private System.Windows.Forms.ToolStripMenuItem biletSatışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnsYonetimAraclar;
        private System.Windows.Forms.ToolStripMenuItem mnSeferIslemleri;
        private System.Windows.Forms.ToolStripMenuItem mnSubeIslemleri;
        private System.Windows.Forms.ToolStripMenuItem mnPersonelIslemleri;
        private System.Windows.Forms.ToolStripMenuItem mnOtobüsİşlemleri;
        private System.Windows.Forms.ToolStripMenuItem mnMusteriIslemleri;
        private System.Windows.Forms.ToolStripMenuItem mnMarkaIslemleri;
        private System.Windows.Forms.ToolStripMenuItem mnMasrafIslemleri;
        private System.Windows.Forms.ToolStripMenuItem mnsRaporlar;
        private System.Windows.Forms.ToolStripMenuItem mnTarihBazliRapor;
        private System.Windows.Forms.ToolStripMenuItem mnSeferBazliRapor;
        private System.Windows.Forms.ToolStripMenuItem mnsYardım;
        private System.Windows.Forms.ToolStripMenuItem mnsCikis;
    }
}