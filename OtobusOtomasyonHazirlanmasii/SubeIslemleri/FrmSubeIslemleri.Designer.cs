namespace OtobusOtomasyonHazirlanmasii.SubeIslemleri
{
    partial class FrmSubeIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSubeIslemleri));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtListelenenKayitSayisi = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtArananSube = new System.Windows.Forms.TextBox();
            this.lsvSube = new System.Windows.Forms.ListView();
            this.columnHeaderSubeID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSehirID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSube = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSehir = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtSubeAdi = new System.Windows.Forms.TextBox();
            this.btnCikis = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnYeni = new System.Windows.Forms.Button();
            this.gbSubeEkle = new System.Windows.Forms.GroupBox();
            this.lblUyari = new System.Windows.Forms.Label();
            this.txtEklenecekSubeAdi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbSubeler = new System.Windows.Forms.ComboBox();
            this.cbSehirler = new System.Windows.Forms.ComboBox();
            this.txtSehirID = new System.Windows.Forms.TextBox();
            this.txtSubeID = new System.Windows.Forms.TextBox();
            this.txtSehirAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSubedeCalisanSayisi = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.gbSubeEkle.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtListelenenKayitSayisi);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.lsvSube);
            this.groupBox3.Location = new System.Drawing.Point(40, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(403, 528);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Şube Listeleme ve Arama";
            // 
            // txtListelenenKayitSayisi
            // 
            this.txtListelenenKayitSayisi.Location = new System.Drawing.Point(184, 477);
            this.txtListelenenKayitSayisi.Name = "txtListelenenKayitSayisi";
            this.txtListelenenKayitSayisi.ReadOnly = true;
            this.txtListelenenKayitSayisi.Size = new System.Drawing.Size(32, 22);
            this.txtListelenenKayitSayisi.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(25, 479);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(153, 17);
            this.label12.TabIndex = 3;
            this.label12.Text = "Listelenen Kayıt Sayısı:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.txtArananSube);
            this.groupBox4.Location = new System.Drawing.Point(18, 34);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(372, 117);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Çalışan Arama İşlemleri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(315, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Şube Detayını Görmek İçin Lütfen Seçim Yapınız:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Aranacak Şube Adı:";
            // 
            // txtArananSube
            // 
            this.txtArananSube.Location = new System.Drawing.Point(146, 34);
            this.txtArananSube.Multiline = true;
            this.txtArananSube.Name = "txtArananSube";
            this.txtArananSube.Size = new System.Drawing.Size(189, 29);
            this.txtArananSube.TabIndex = 1;
            this.txtArananSube.TextChanged += new System.EventHandler(this.txtArananSube_TextChanged);
            // 
            // lsvSube
            // 
            this.lsvSube.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderSubeID,
            this.columnHeaderSehirID,
            this.columnHeaderSube,
            this.columnHeaderSehir});
            this.lsvSube.FullRowSelect = true;
            this.lsvSube.GridLines = true;
            this.lsvSube.HoverSelection = true;
            this.lsvSube.Location = new System.Drawing.Point(18, 174);
            this.lsvSube.Name = "lsvSube";
            this.lsvSube.Size = new System.Drawing.Size(305, 291);
            this.lsvSube.TabIndex = 0;
            this.lsvSube.UseCompatibleStateImageBehavior = false;
            this.lsvSube.View = System.Windows.Forms.View.Details;
            this.lsvSube.SelectedIndexChanged += new System.EventHandler(this.lsvSube_SelectedIndexChanged);
            this.lsvSube.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lsvSube_MouseDoubleClick);
            // 
            // columnHeaderSubeID
            // 
            this.columnHeaderSubeID.Text = "SubeID";
            this.columnHeaderSubeID.Width = 1;
            // 
            // columnHeaderSehirID
            // 
            this.columnHeaderSehirID.DisplayIndex = 3;
            this.columnHeaderSehirID.Text = "SehirID";
            this.columnHeaderSehirID.Width = 1;
            // 
            // columnHeaderSube
            // 
            this.columnHeaderSube.DisplayIndex = 1;
            this.columnHeaderSube.Text = "SubeAdi";
            this.columnHeaderSube.Width = 150;
            // 
            // columnHeaderSehir
            // 
            this.columnHeaderSehir.DisplayIndex = 2;
            this.columnHeaderSehir.Text = "SehirAdi";
            this.columnHeaderSehir.Width = 150;
            // 
            // txtSubeAdi
            // 
            this.txtSubeAdi.Location = new System.Drawing.Point(160, 202);
            this.txtSubeAdi.Multiline = true;
            this.txtSubeAdi.Name = "txtSubeAdi";
            this.txtSubeAdi.Size = new System.Drawing.Size(136, 29);
            this.txtSubeAdi.TabIndex = 4;
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnCikis.Image = ((System.Drawing.Image)(resources.GetObject("btnCikis.Image")));
            this.btnCikis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCikis.Location = new System.Drawing.Point(300, 22);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(83, 49);
            this.btnCikis.TabIndex = 2;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox7);
            this.groupBox2.Controls.Add(this.gbSubeEkle);
            this.groupBox2.Controls.Add(this.cbSubeler);
            this.groupBox2.Controls.Add(this.cbSehirler);
            this.groupBox2.Controls.Add(this.txtSehirID);
            this.groupBox2.Controls.Add(this.txtSubeID);
            this.groupBox2.Controls.Add(this.txtSehirAdi);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtSubeAdi);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Location = new System.Drawing.Point(462, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(447, 528);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Şube İşlemleri";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnGuncelle);
            this.groupBox7.Controls.Add(this.btnEkle);
            this.groupBox7.Controls.Add(this.btnSil);
            this.groupBox7.Controls.Add(this.btnYeni);
            this.groupBox7.Location = new System.Drawing.Point(33, 401);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(397, 113);
            this.groupBox7.TabIndex = 14;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "İŞLEMLER";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.Image")));
            this.btnGuncelle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuncelle.Location = new System.Drawing.Point(300, 39);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(84, 58);
            this.btnGuncelle.TabIndex = 7;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnEkle.Image")));
            this.btnEkle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEkle.Location = new System.Drawing.Point(206, 39);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 58);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.Image")));
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSil.Location = new System.Drawing.Point(110, 39);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 58);
            this.btnSil.TabIndex = 5;
            this.btnSil.Text = "Sil";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnYeni
            // 
            this.btnYeni.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnYeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeni.Image = ((System.Drawing.Image)(resources.GetObject("btnYeni.Image")));
            this.btnYeni.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnYeni.Location = new System.Drawing.Point(17, 39);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(75, 58);
            this.btnYeni.TabIndex = 4;
            this.btnYeni.Text = "Temizle";
            this.btnYeni.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // gbSubeEkle
            // 
            this.gbSubeEkle.Controls.Add(this.lblUyari);
            this.gbSubeEkle.Controls.Add(this.txtEklenecekSubeAdi);
            this.gbSubeEkle.Controls.Add(this.label6);
            this.gbSubeEkle.Location = new System.Drawing.Point(33, 262);
            this.gbSubeEkle.Name = "gbSubeEkle";
            this.gbSubeEkle.Size = new System.Drawing.Size(397, 108);
            this.gbSubeEkle.TabIndex = 6;
            this.gbSubeEkle.TabStop = false;
            this.gbSubeEkle.Text = "Şube Ekleme İşlemleri";
            // 
            // lblUyari
            // 
            this.lblUyari.AutoSize = true;
            this.lblUyari.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblUyari.Location = new System.Drawing.Point(7, 35);
            this.lblUyari.Name = "lblUyari";
            this.lblUyari.Size = new System.Drawing.Size(0, 17);
            this.lblUyari.TabIndex = 15;
            // 
            // txtEklenecekSubeAdi
            // 
            this.txtEklenecekSubeAdi.Location = new System.Drawing.Point(229, 60);
            this.txtEklenecekSubeAdi.Multiline = true;
            this.txtEklenecekSubeAdi.Name = "txtEklenecekSubeAdi";
            this.txtEklenecekSubeAdi.Size = new System.Drawing.Size(136, 29);
            this.txtEklenecekSubeAdi.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(212, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Eklenecek Şubenin Adını Giriniz:";
            // 
            // cbSubeler
            // 
            this.cbSubeler.FormattingEnabled = true;
            this.cbSubeler.Location = new System.Drawing.Point(302, 207);
            this.cbSubeler.Name = "cbSubeler";
            this.cbSubeler.Size = new System.Drawing.Size(121, 24);
            this.cbSubeler.TabIndex = 13;
            this.cbSubeler.SelectedIndexChanged += new System.EventHandler(this.cbSubeler_SelectedIndexChanged);
            // 
            // cbSehirler
            // 
            this.cbSehirler.FormattingEnabled = true;
            this.cbSehirler.Location = new System.Drawing.Point(302, 154);
            this.cbSehirler.Name = "cbSehirler";
            this.cbSehirler.Size = new System.Drawing.Size(121, 24);
            this.cbSehirler.TabIndex = 12;
            this.cbSehirler.SelectedIndexChanged += new System.EventHandler(this.cbSehirler_SelectedIndexChanged);
            // 
            // txtSehirID
            // 
            this.txtSehirID.Location = new System.Drawing.Point(115, 149);
            this.txtSehirID.Multiline = true;
            this.txtSehirID.Name = "txtSehirID";
            this.txtSehirID.Size = new System.Drawing.Size(39, 29);
            this.txtSehirID.TabIndex = 11;
            this.txtSehirID.Visible = false;
            // 
            // txtSubeID
            // 
            this.txtSubeID.Location = new System.Drawing.Point(115, 202);
            this.txtSubeID.Multiline = true;
            this.txtSubeID.Name = "txtSubeID";
            this.txtSubeID.Size = new System.Drawing.Size(39, 29);
            this.txtSubeID.TabIndex = 10;
            this.txtSubeID.Visible = false;
            // 
            // txtSehirAdi
            // 
            this.txtSehirAdi.Location = new System.Drawing.Point(160, 149);
            this.txtSehirAdi.Multiline = true;
            this.txtSehirAdi.Name = "txtSehirAdi";
            this.txtSehirAdi.Size = new System.Drawing.Size(136, 29);
            this.txtSehirAdi.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Şube Adı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Şehir Adı:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.txtSubedeCalisanSayisi);
            this.groupBox5.Controls.Add(this.btnCikis);
            this.groupBox5.Location = new System.Drawing.Point(33, 43);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(397, 77);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Şube İşlemleri Yönetim";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Şubedeki Çalışan Sayısı:";
            // 
            // txtSubedeCalisanSayisi
            // 
            this.txtSubedeCalisanSayisi.Location = new System.Drawing.Point(175, 34);
            this.txtSubedeCalisanSayisi.Multiline = true;
            this.txtSubedeCalisanSayisi.Name = "txtSubedeCalisanSayisi";
            this.txtSubedeCalisanSayisi.ReadOnly = true;
            this.txtSubedeCalisanSayisi.Size = new System.Drawing.Size(76, 29);
            this.txtSubedeCalisanSayisi.TabIndex = 1;
            // 
            // FrmSubeIslemleri
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 574);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "FrmSubeIslemleri";
            this.Text = "Şube İşlemleri";
            this.Load += new System.EventHandler(this.FrmSubeIslemleri_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.gbSubeEkle.ResumeLayout(false);
            this.gbSubeEkle.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtListelenenKayitSayisi;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtSubeAdi;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.TextBox txtArananSube;
        private System.Windows.Forms.ListView lsvSube;
        private System.Windows.Forms.ColumnHeader columnHeaderSehir;
        private System.Windows.Forms.ColumnHeader columnHeaderSube;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSubedeCalisanSayisi;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox gbSubeEkle;
        private System.Windows.Forms.Label lblUyari;
        private System.Windows.Forms.TextBox txtEklenecekSubeAdi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbSubeler;
        private System.Windows.Forms.ComboBox cbSehirler;
        private System.Windows.Forms.TextBox txtSehirID;
        private System.Windows.Forms.TextBox txtSubeID;
        private System.Windows.Forms.TextBox txtSehirAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.ColumnHeader columnHeaderSubeID;
        private System.Windows.Forms.ColumnHeader columnHeaderSehirID;
    }
}