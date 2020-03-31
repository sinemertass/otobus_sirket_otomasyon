namespace OtobusOtomasyonHazirlanmasii.CalisanIslemleri
{
    partial class FrmYeniCalisan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmYeniCalisan));
            this.lstCalisan = new System.Windows.Forms.ListView();
            this.chPersonelID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSoyad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTelefon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSubeID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSubeAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEvAdresi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chKullaniciAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCalisanTipID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCalisanUnvani = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chYoneticiMi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSifre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbYeniCalisanIslem = new System.Windows.Forms.GroupBox();
            this.txtPersonelID = new System.Windows.Forms.TextBox();
            this.lblUyari = new System.Windows.Forms.Label();
            this.txtCalisanTipID = new System.Windows.Forms.TextBox();
            this.txtSubeID = new System.Windows.Forms.TextBox();
            this.cbCalisanTip = new System.Windows.Forms.ComboBox();
            this.cbSubeAdi = new System.Windows.Forms.ComboBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.rbCalisan = new System.Windows.Forms.RadioButton();
            this.rbYonetici = new System.Windows.Forms.RadioButton();
            this.txtCalisanTipAdi = new System.Windows.Forms.TextBox();
            this.txtCalisanKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtCalisanEvAdresi = new System.Windows.Forms.TextBox();
            this.txtSubeAdi = new System.Windows.Forms.TextBox();
            this.txtCalisanTelefon = new System.Windows.Forms.TextBox();
            this.txtCalisanEmail = new System.Windows.Forms.TextBox();
            this.txtCalisanSoyad = new System.Windows.Forms.TextBox();
            this.txtCalisanAd = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbIslemInfo = new System.Windows.Forms.GroupBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnYeni = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCalisanSayisi = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtAranacakSube = new System.Windows.Forms.TextBox();
            this.btnSubeAra = new System.Windows.Forms.Button();
            this.btnGiriseDon = new System.Windows.Forms.Button();
            this.txtAranacakCalisan = new System.Windows.Forms.TextBox();
            this.btnCalisanAra = new System.Windows.Forms.Button();
            this.gbYeniCalisanIslem.SuspendLayout();
            this.gbIslemInfo.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstCalisan
            // 
            this.lstCalisan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chPersonelID,
            this.chAd,
            this.chSoyad,
            this.chEmail,
            this.chTelefon,
            this.chSubeID,
            this.chSubeAdi,
            this.chEvAdresi,
            this.chKullaniciAdi,
            this.chCalisanTipID,
            this.chCalisanUnvani,
            this.chYoneticiMi,
            this.chSifre});
            this.lstCalisan.FullRowSelect = true;
            this.lstCalisan.GridLines = true;
            this.lstCalisan.HoverSelection = true;
            this.lstCalisan.Location = new System.Drawing.Point(18, 160);
            this.lstCalisan.Name = "lstCalisan";
            this.lstCalisan.Size = new System.Drawing.Size(755, 456);
            this.lstCalisan.TabIndex = 0;
            this.lstCalisan.UseCompatibleStateImageBehavior = false;
            this.lstCalisan.View = System.Windows.Forms.View.Details;
            this.lstCalisan.SelectedIndexChanged += new System.EventHandler(this.lstCalisan_SelectedIndexChanged);
            // 
            // chPersonelID
            // 
            this.chPersonelID.Tag = "";
            this.chPersonelID.Text = "PersonelID";
            this.chPersonelID.Width = 1;
            // 
            // chAd
            // 
            this.chAd.Text = "Ad";
            this.chAd.Width = 72;
            // 
            // chSoyad
            // 
            this.chSoyad.Text = "Soyad";
            this.chSoyad.Width = 70;
            // 
            // chEmail
            // 
            this.chEmail.Text = "Email";
            this.chEmail.Width = 70;
            // 
            // chTelefon
            // 
            this.chTelefon.Text = "Telefon";
            this.chTelefon.Width = 67;
            // 
            // chSubeID
            // 
            this.chSubeID.Tag = "";
            this.chSubeID.Text = "Şube ID";
            this.chSubeID.Width = 1;
            // 
            // chSubeAdi
            // 
            this.chSubeAdi.Text = "Şube Adi";
            this.chSubeAdi.Width = 87;
            // 
            // chEvAdresi
            // 
            this.chEvAdresi.Text = "Ev Adresi";
            this.chEvAdresi.Width = 91;
            // 
            // chKullaniciAdi
            // 
            this.chKullaniciAdi.Text = "Kullanıcı Adı";
            this.chKullaniciAdi.Width = 90;
            // 
            // chCalisanTipID
            // 
            this.chCalisanTipID.Tag = "";
            this.chCalisanTipID.Text = "Çalışan Tip ID";
            this.chCalisanTipID.Width = 1;
            // 
            // chCalisanUnvani
            // 
            this.chCalisanUnvani.Text = "Çalışan Unvanı";
            this.chCalisanUnvani.Width = 116;
            // 
            // chYoneticiMi
            // 
            this.chYoneticiMi.Text = "Yönetici Mi";
            this.chYoneticiMi.Width = 88;
            // 
            // chSifre
            // 
            this.chSifre.Text = "Sifre";
            this.chSifre.Width = 1;
            // 
            // gbYeniCalisanIslem
            // 
            this.gbYeniCalisanIslem.Controls.Add(this.txtPersonelID);
            this.gbYeniCalisanIslem.Controls.Add(this.lblUyari);
            this.gbYeniCalisanIslem.Controls.Add(this.txtCalisanTipID);
            this.gbYeniCalisanIslem.Controls.Add(this.txtSubeID);
            this.gbYeniCalisanIslem.Controls.Add(this.cbCalisanTip);
            this.gbYeniCalisanIslem.Controls.Add(this.cbSubeAdi);
            this.gbYeniCalisanIslem.Controls.Add(this.txtSifre);
            this.gbYeniCalisanIslem.Controls.Add(this.label10);
            this.gbYeniCalisanIslem.Controls.Add(this.rbCalisan);
            this.gbYeniCalisanIslem.Controls.Add(this.rbYonetici);
            this.gbYeniCalisanIslem.Controls.Add(this.txtCalisanTipAdi);
            this.gbYeniCalisanIslem.Controls.Add(this.txtCalisanKullaniciAdi);
            this.gbYeniCalisanIslem.Controls.Add(this.txtCalisanEvAdresi);
            this.gbYeniCalisanIslem.Controls.Add(this.txtSubeAdi);
            this.gbYeniCalisanIslem.Controls.Add(this.txtCalisanTelefon);
            this.gbYeniCalisanIslem.Controls.Add(this.txtCalisanEmail);
            this.gbYeniCalisanIslem.Controls.Add(this.txtCalisanSoyad);
            this.gbYeniCalisanIslem.Controls.Add(this.txtCalisanAd);
            this.gbYeniCalisanIslem.Controls.Add(this.label9);
            this.gbYeniCalisanIslem.Controls.Add(this.label8);
            this.gbYeniCalisanIslem.Controls.Add(this.label7);
            this.gbYeniCalisanIslem.Controls.Add(this.label6);
            this.gbYeniCalisanIslem.Controls.Add(this.label5);
            this.gbYeniCalisanIslem.Controls.Add(this.label4);
            this.gbYeniCalisanIslem.Controls.Add(this.label3);
            this.gbYeniCalisanIslem.Controls.Add(this.label2);
            this.gbYeniCalisanIslem.Controls.Add(this.label1);
            this.gbYeniCalisanIslem.Controls.Add(this.gbIslemInfo);
            this.gbYeniCalisanIslem.Location = new System.Drawing.Point(12, 12);
            this.gbYeniCalisanIslem.Name = "gbYeniCalisanIslem";
            this.gbYeniCalisanIslem.Size = new System.Drawing.Size(450, 679);
            this.gbYeniCalisanIslem.TabIndex = 1;
            this.gbYeniCalisanIslem.TabStop = false;
            this.gbYeniCalisanIslem.Text = "Yeni Çalışan İşlemleri";
            // 
            // txtPersonelID
            // 
            this.txtPersonelID.Location = new System.Drawing.Point(317, 34);
            this.txtPersonelID.Name = "txtPersonelID";
            this.txtPersonelID.ReadOnly = true;
            this.txtPersonelID.Size = new System.Drawing.Size(100, 22);
            this.txtPersonelID.TabIndex = 29;
            this.txtPersonelID.Visible = false;
            // 
            // lblUyari
            // 
            this.lblUyari.AutoSize = true;
            this.lblUyari.Location = new System.Drawing.Point(165, 11);
            this.lblUyari.Name = "lblUyari";
            this.lblUyari.Size = new System.Drawing.Size(0, 17);
            this.lblUyari.TabIndex = 28;
            // 
            // txtCalisanTipID
            // 
            this.txtCalisanTipID.Location = new System.Drawing.Point(309, 403);
            this.txtCalisanTipID.Name = "txtCalisanTipID";
            this.txtCalisanTipID.Size = new System.Drawing.Size(26, 22);
            this.txtCalisanTipID.TabIndex = 27;
            this.txtCalisanTipID.Visible = false;
            // 
            // txtSubeID
            // 
            this.txtSubeID.Location = new System.Drawing.Point(133, 199);
            this.txtSubeID.Name = "txtSubeID";
            this.txtSubeID.Size = new System.Drawing.Size(26, 22);
            this.txtSubeID.TabIndex = 26;
            this.txtSubeID.Visible = false;
            // 
            // cbCalisanTip
            // 
            this.cbCalisanTip.FormattingEnabled = true;
            this.cbCalisanTip.Location = new System.Drawing.Point(323, 403);
            this.cbCalisanTip.Name = "cbCalisanTip";
            this.cbCalisanTip.Size = new System.Drawing.Size(121, 24);
            this.cbCalisanTip.TabIndex = 25;
            this.cbCalisanTip.SelectedIndexChanged += new System.EventHandler(this.cbCalisanTip_SelectedIndexChanged);
            // 
            // cbSubeAdi
            // 
            this.cbSubeAdi.FormattingEnabled = true;
            this.cbSubeAdi.Location = new System.Drawing.Point(316, 199);
            this.cbSubeAdi.Name = "cbSubeAdi";
            this.cbSubeAdi.Size = new System.Drawing.Size(121, 24);
            this.cbSubeAdi.TabIndex = 24;
            this.cbSubeAdi.SelectedIndexChanged += new System.EventHandler(this.cbSubeAdi_SelectedIndexChanged);
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(165, 496);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(146, 22);
            this.txtSifre.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 501);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 17);
            this.label10.TabIndex = 22;
            this.label10.Text = "Şifre:";
            // 
            // rbCalisan
            // 
            this.rbCalisan.AutoSize = true;
            this.rbCalisan.Location = new System.Drawing.Point(266, 451);
            this.rbCalisan.Name = "rbCalisan";
            this.rbCalisan.Size = new System.Drawing.Size(75, 21);
            this.rbCalisan.TabIndex = 21;
            this.rbCalisan.TabStop = true;
            this.rbCalisan.Text = "Çalışan";
            this.rbCalisan.UseVisualStyleBackColor = true;
            // 
            // rbYonetici
            // 
            this.rbYonetici.AutoSize = true;
            this.rbYonetici.Location = new System.Drawing.Point(165, 453);
            this.rbYonetici.Name = "rbYonetici";
            this.rbYonetici.Size = new System.Drawing.Size(79, 21);
            this.rbYonetici.TabIndex = 20;
            this.rbYonetici.TabStop = true;
            this.rbYonetici.Text = "Yönetici";
            this.rbYonetici.UseVisualStyleBackColor = true;
            // 
            // txtCalisanTipAdi
            // 
            this.txtCalisanTipAdi.Location = new System.Drawing.Point(165, 403);
            this.txtCalisanTipAdi.Name = "txtCalisanTipAdi";
            this.txtCalisanTipAdi.Size = new System.Drawing.Size(146, 22);
            this.txtCalisanTipAdi.TabIndex = 19;
            // 
            // txtCalisanKullaniciAdi
            // 
            this.txtCalisanKullaniciAdi.Location = new System.Drawing.Point(165, 361);
            this.txtCalisanKullaniciAdi.Name = "txtCalisanKullaniciAdi";
            this.txtCalisanKullaniciAdi.Size = new System.Drawing.Size(146, 22);
            this.txtCalisanKullaniciAdi.TabIndex = 18;
            // 
            // txtCalisanEvAdresi
            // 
            this.txtCalisanEvAdresi.Location = new System.Drawing.Point(165, 248);
            this.txtCalisanEvAdresi.Multiline = true;
            this.txtCalisanEvAdresi.Name = "txtCalisanEvAdresi";
            this.txtCalisanEvAdresi.Size = new System.Drawing.Size(234, 76);
            this.txtCalisanEvAdresi.TabIndex = 17;
            // 
            // txtSubeAdi
            // 
            this.txtSubeAdi.Location = new System.Drawing.Point(165, 199);
            this.txtSubeAdi.Name = "txtSubeAdi";
            this.txtSubeAdi.Size = new System.Drawing.Size(146, 22);
            this.txtSubeAdi.TabIndex = 16;
            // 
            // txtCalisanTelefon
            // 
            this.txtCalisanTelefon.Location = new System.Drawing.Point(165, 157);
            this.txtCalisanTelefon.Name = "txtCalisanTelefon";
            this.txtCalisanTelefon.Size = new System.Drawing.Size(146, 22);
            this.txtCalisanTelefon.TabIndex = 15;
            // 
            // txtCalisanEmail
            // 
            this.txtCalisanEmail.Location = new System.Drawing.Point(165, 117);
            this.txtCalisanEmail.Name = "txtCalisanEmail";
            this.txtCalisanEmail.Size = new System.Drawing.Size(146, 22);
            this.txtCalisanEmail.TabIndex = 14;
            // 
            // txtCalisanSoyad
            // 
            this.txtCalisanSoyad.Location = new System.Drawing.Point(165, 72);
            this.txtCalisanSoyad.Name = "txtCalisanSoyad";
            this.txtCalisanSoyad.Size = new System.Drawing.Size(146, 22);
            this.txtCalisanSoyad.TabIndex = 13;
            // 
            // txtCalisanAd
            // 
            this.txtCalisanAd.Location = new System.Drawing.Point(165, 34);
            this.txtCalisanAd.Name = "txtCalisanAd";
            this.txtCalisanAd.Size = new System.Drawing.Size(146, 22);
            this.txtCalisanAd.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 453);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "Yönetici Mi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 403);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "Çalışan Bölüm Adı: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 364);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Kullanıcı Adı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Ev Adresi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Şube Adı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telefon:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Çalışan Soyadı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Çalışan Adı:";
            // 
            // gbIslemInfo
            // 
            this.gbIslemInfo.Controls.Add(this.btnGuncelle);
            this.gbIslemInfo.Controls.Add(this.btnEkle);
            this.gbIslemInfo.Controls.Add(this.btnSil);
            this.gbIslemInfo.Controls.Add(this.btnYeni);
            this.gbIslemInfo.Location = new System.Drawing.Point(6, 561);
            this.gbIslemInfo.Name = "gbIslemInfo";
            this.gbIslemInfo.Size = new System.Drawing.Size(399, 112);
            this.gbIslemInfo.TabIndex = 2;
            this.gbIslemInfo.TabStop = false;
            this.gbIslemInfo.Text = "İşlemler İnfo";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.Image")));
            this.btnGuncelle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuncelle.Location = new System.Drawing.Point(303, 35);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(90, 58);
            this.btnGuncelle.TabIndex = 3;
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
            this.btnEkle.Location = new System.Drawing.Point(209, 35);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(88, 58);
            this.btnEkle.TabIndex = 2;
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
            this.btnSil.Location = new System.Drawing.Point(113, 35);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(90, 58);
            this.btnSil.TabIndex = 1;
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
            this.btnYeni.Location = new System.Drawing.Point(6, 35);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(101, 58);
            this.btnYeni.TabIndex = 0;
            this.btnYeni.Text = "Temizle";
            this.btnYeni.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.lstCalisan);
            this.groupBox3.Location = new System.Drawing.Point(468, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(786, 679);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mevcut Çalışan Listesi";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCalisanSayisi);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Location = new System.Drawing.Point(499, 622);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 57);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Çalışan Sayısı";
            // 
            // txtCalisanSayisi
            // 
            this.txtCalisanSayisi.Location = new System.Drawing.Point(207, 21);
            this.txtCalisanSayisi.Name = "txtCalisanSayisi";
            this.txtCalisanSayisi.ReadOnly = true;
            this.txtCalisanSayisi.Size = new System.Drawing.Size(32, 22);
            this.txtCalisanSayisi.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(33, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(168, 17);
            this.label12.TabIndex = 3;
            this.label12.Text = "Listelenen Çalışan Sayısı:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtAranacakSube);
            this.groupBox4.Controls.Add(this.btnSubeAra);
            this.groupBox4.Controls.Add(this.btnGiriseDon);
            this.groupBox4.Controls.Add(this.txtAranacakCalisan);
            this.groupBox4.Controls.Add(this.btnCalisanAra);
            this.groupBox4.Location = new System.Drawing.Point(18, 34);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(755, 117);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Çalışan Arama İşlemleri";
            // 
            // txtAranacakSube
            // 
            this.txtAranacakSube.Location = new System.Drawing.Point(166, 68);
            this.txtAranacakSube.Multiline = true;
            this.txtAranacakSube.Name = "txtAranacakSube";
            this.txtAranacakSube.Size = new System.Drawing.Size(189, 29);
            this.txtAranacakSube.TabIndex = 4;
            this.txtAranacakSube.TextChanged += new System.EventHandler(this.txtAranacakSube_TextChanged);
            // 
            // btnSubeAra
            // 
            this.btnSubeAra.Image = ((System.Drawing.Image)(resources.GetObject("btnSubeAra.Image")));
            this.btnSubeAra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubeAra.Location = new System.Drawing.Point(6, 68);
            this.btnSubeAra.Name = "btnSubeAra";
            this.btnSubeAra.Size = new System.Drawing.Size(154, 31);
            this.btnSubeAra.TabIndex = 3;
            this.btnSubeAra.Text = "Şube Ara";
            this.btnSubeAra.UseVisualStyleBackColor = true;
            // 
            // btnGiriseDon
            // 
            this.btnGiriseDon.Image = ((System.Drawing.Image)(resources.GetObject("btnGiriseDon.Image")));
            this.btnGiriseDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGiriseDon.Location = new System.Drawing.Point(580, 21);
            this.btnGiriseDon.Name = "btnGiriseDon";
            this.btnGiriseDon.Size = new System.Drawing.Size(160, 49);
            this.btnGiriseDon.TabIndex = 2;
            this.btnGiriseDon.Text = "Giriş Ekranına Dön";
            this.btnGiriseDon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGiriseDon.UseVisualStyleBackColor = true;
            this.btnGiriseDon.Click += new System.EventHandler(this.btnGiriseDon_Click);
            // 
            // txtAranacakCalisan
            // 
            this.txtAranacakCalisan.Location = new System.Drawing.Point(166, 33);
            this.txtAranacakCalisan.Multiline = true;
            this.txtAranacakCalisan.Name = "txtAranacakCalisan";
            this.txtAranacakCalisan.Size = new System.Drawing.Size(189, 29);
            this.txtAranacakCalisan.TabIndex = 1;
            this.txtAranacakCalisan.TextChanged += new System.EventHandler(this.txtAranacakCalisan_TextChanged);
            // 
            // btnCalisanAra
            // 
            this.btnCalisanAra.Image = ((System.Drawing.Image)(resources.GetObject("btnCalisanAra.Image")));
            this.btnCalisanAra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalisanAra.Location = new System.Drawing.Point(6, 31);
            this.btnCalisanAra.Name = "btnCalisanAra";
            this.btnCalisanAra.Size = new System.Drawing.Size(154, 31);
            this.btnCalisanAra.TabIndex = 0;
            this.btnCalisanAra.Text = "Çalışan Ara";
            this.btnCalisanAra.UseVisualStyleBackColor = true;
            // 
            // FrmYeniCalisan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 703);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbYeniCalisanIslem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmYeniCalisan";
            this.Text = "Çalışan İşlemleri";
            this.Load += new System.EventHandler(this.FrmYeniCalisan_Load);
            this.gbYeniCalisanIslem.ResumeLayout(false);
            this.gbYeniCalisanIslem.PerformLayout();
            this.gbIslemInfo.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstCalisan;
        private System.Windows.Forms.ColumnHeader chAd;
        private System.Windows.Forms.ColumnHeader chSoyad;
        private System.Windows.Forms.ColumnHeader chEmail;
        private System.Windows.Forms.ColumnHeader chTelefon;
        private System.Windows.Forms.ColumnHeader chSubeAdi;
        private System.Windows.Forms.ColumnHeader chEvAdresi;
        private System.Windows.Forms.ColumnHeader chKullaniciAdi;
        private System.Windows.Forms.ColumnHeader chCalisanUnvani;
        private System.Windows.Forms.ColumnHeader chYoneticiMi;
        private System.Windows.Forms.GroupBox gbYeniCalisanIslem;
        private System.Windows.Forms.TextBox txtCalisanTipAdi;
        private System.Windows.Forms.TextBox txtCalisanKullaniciAdi;
        private System.Windows.Forms.TextBox txtCalisanEvAdresi;
        private System.Windows.Forms.TextBox txtSubeAdi;
        private System.Windows.Forms.TextBox txtCalisanTelefon;
        private System.Windows.Forms.TextBox txtCalisanEmail;
        private System.Windows.Forms.TextBox txtCalisanSoyad;
        private System.Windows.Forms.TextBox txtCalisanAd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbIslemInfo;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtAranacakCalisan;
        private System.Windows.Forms.Button btnCalisanAra;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton rbCalisan;
        private System.Windows.Forms.RadioButton rbYonetici;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnGiriseDon;
        private System.Windows.Forms.ComboBox cbCalisanTip;
        private System.Windows.Forms.ComboBox cbSubeAdi;
        private System.Windows.Forms.ColumnHeader chPersonelID;
        private System.Windows.Forms.ColumnHeader chSubeID;
        private System.Windows.Forms.ColumnHeader chCalisanTipID;
        private System.Windows.Forms.TextBox txtSubeID;
        private System.Windows.Forms.TextBox txtCalisanTipID;
        private System.Windows.Forms.TextBox txtPersonelID;
        private System.Windows.Forms.Label lblUyari;
        private System.Windows.Forms.TextBox txtCalisanSayisi;
        private System.Windows.Forms.ColumnHeader chSifre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtAranacakSube;
        private System.Windows.Forms.Button btnSubeAra;
    }
}