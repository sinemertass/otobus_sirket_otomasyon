using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtobusOtomasyonHazirlanmasii
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        private void FrmGiris_Load(object sender, EventArgs e)
        {

        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            Entity.Calisan Kullanici = new Entity.Calisan();
            Kullanici.KullaniciAdi = Face.Kontrol.Temizle(txtKullaniciAdi.Text);
            Kullanici.Sifre = Face.Kontrol.Temizle(txtSifre.Text);
            Entity.Calisan calisanbilgi = Face.Calisan.Login(Kullanici);

            if (calisanbilgi!=null)
            {
                Entity.PersonelGirisCikis girisbilgileri = new Entity.PersonelGirisCikis();
                girisbilgileri.PersonelID = calisanbilgi.PersonelID;
                girisbilgileri.IslemTipi = true;
                Face.PersonelGirisCikis.PersonelGirisCikisEkle(girisbilgileri);

                /* oturum bilgileri almak için */
                FrmMain.calisan = calisanbilgi;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı yada Sifresi Hatalı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnKullaniciEkle_Click(object sender, EventArgs e)
        {
            CalisanIslemleri.FrmYeniCalisan frmYeni = new CalisanIslemleri.FrmYeniCalisan();
            //this.Hide();
            frmYeni.ShowDialog();
            this.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
