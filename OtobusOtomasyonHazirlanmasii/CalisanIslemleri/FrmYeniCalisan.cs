using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtobusOtomasyonHazirlanmasii.CalisanIslemleri
{
    public partial class FrmYeniCalisan : Form
    {
        public FrmYeniCalisan()
        {
            InitializeComponent();
        }

        private void btnGiriseDon_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            FrmGiris frm = new FrmGiris();
            FrmGiris.ActiveForm.AddOwnedForm(frm);
            this.Close();
        }
         
        private void FrmYeniCalisan_Load(object sender, EventArgs e)
        {
            this.Top = 150;
            this.Left = 100;
            Face.Calisan.CalisanListesi(lstCalisan);
            //txtSubeID.Visible = false;
            Face.Sube.SubeListele(cbSubeAdi);
            Face.CalisanTip.CalisanTipGetir(cbCalisanTip);
            txtCalisanSayisi.Text=Convert.ToString(Face.Calisan.CalisanSayisi());

        }

        private void cbSubeAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            Entity.Sube sube = (Entity.Sube)cbSubeAdi.SelectedItem;
            txtSubeID.Text = (sube.SubeID).ToString();
            txtSubeAdi.Text = (sube.SubeAdi).ToString();
            

        }

        private void cbCalisanTip_SelectedIndexChanged(object sender, EventArgs e)
        {
            Entity.CalisanTip clt = (Entity.CalisanTip)cbCalisanTip.SelectedItem;
            txtCalisanTipID.Text = Convert.ToString(clt.CalisanTipID);
            txtCalisanTipAdi.Text = Convert.ToString(clt.CalisanTipAdi);

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void Temizle()
        {
            
            txtCalisanAd.Text="";
            txtCalisanSoyad.Text = "";
            txtCalisanTipAdi.Text = "";
            txtCalisanTipID.Text = "";
            txtCalisanEmail.Text = "";
            txtCalisanEvAdresi.Text = "";
            txtCalisanTelefon.Text = "";
            txtCalisanKullaniciAdi.Text = "";
            txtSifre.Text = "";
            txtSubeAdi.Text = "";
            txtSubeID.Text = "";
            txtSifre.ReadOnly = true; //sifre sadece okunabiliyor.
            txtCalisanAd.Focus();
            lstCalisan.FullRowSelect = false; 
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if ((txtCalisanAd.Text=="") || (txtCalisanSoyad.Text=="") || (txtCalisanTelefon.Text=="") || (txtCalisanEmail.Text=="") || (txtCalisanEvAdresi.Text=="") || (txtCalisanKullaniciAdi.Text=="") || (txtCalisanTipAdi.Text=="") || (txtCalisanTipID.Text=="") || (txtSubeAdi.Text=="") || (txtSubeID.Text=="") || (txtSifre.Text=="")  || (rbYonetici.Checked==false && rbCalisan.Checked == false))
            {
                MessageBox.Show("Tüm Alanlar Doldurulmalıdır!","Hata",MessageBoxButtons.OK,MessageBoxIcon.Information);
                lstCalisan.FullRowSelect = true;
            }
            else
            {
                
                bool sonuc = Face.Calisan.CalisanVarMi(Face.Kontrol.Temizle(txtCalisanAd.Text), Face.Kontrol.Temizle(txtCalisanSoyad.Text));

                if (sonuc) //sonuc true ise
                {
                    MessageBox.Show("Bu çalışan sistemde bulunmaktadır!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lstCalisan.FullRowSelect = true;
                }
                
                else
                {
                    Entity.Calisan gnccl = new Entity.Calisan();
                    //gnccl.PersonelID = Convert.ToInt32(txtPersonelID.Text);
                    gnccl.PersonelAdi = Face.Kontrol.Temizle(txtCalisanAd.Text);
                    gnccl.PersonelSoyadi = Face.Kontrol.Temizle(txtCalisanSoyad.Text);
                    gnccl.PersonelEmail = Face.Kontrol.Temizle(txtCalisanEmail.Text);
                    gnccl.PersonelTelefon = Face.Kontrol.Temizle(txtCalisanTelefon.Text);
                    gnccl.SubeID = Convert.ToInt32(Face.Kontrol.Temizle(txtSubeID.Text));
                    gnccl.EvAdresi = Face.Kontrol.Temizle(txtCalisanEvAdresi.Text);
                    gnccl.KullaniciAdi = Face.Kontrol.Temizle(txtCalisanKullaniciAdi.Text);

                    gnccl.CalisanTipiID = Convert.ToInt32(Face.Kontrol.Temizle(txtCalisanTipID.Text));

                    if (rbYonetici.Checked)
                    {
                        gnccl.YoneticiMi = true;
                    }
                    else if (rbCalisan.Checked)
                    {
                        gnccl.YoneticiMi = false;
                    }
                    
                    gnccl.Sifre = Face.Kontrol.Temizle(txtSifre.Text);
                  
                    if (Face.Calisan.CalisanEkle(gnccl) > 0) //çalışan güncelleme oldu
                    {
                        MessageBox.Show("Çalışan EKLENDİ");
                        Face.Calisan.CalisanListesi(lstCalisan);
                        Face.Sube.SubeListele(cbSubeAdi);
                        Face.CalisanTip.CalisanTipGetir(cbCalisanTip);
                        Temizle();

                    }
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtPersonelID.Text=="")
            {
                MessageBox.Show("Lütfen silinecek çalışanı listeden seçiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information); ;

            }
            else
            {
                if (MessageBox.Show("Silmek istediğinizden Emin Misiniz?", "Uyarı silinen data geri alınamaz", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    Entity.Calisan silinecekCalisan = new Entity.Calisan();
                    silinecekCalisan.PersonelID = Convert.ToInt32(txtPersonelID.Text);
                    if (Face.Calisan.CalisanSil(silinecekCalisan) >0)
                    {
                        MessageBox.Show("Çalışan Kaydı Silindi");
                        Temizle();
                        Face.Calisan.CalisanListesi(lstCalisan); //list view'de son çalışanları güncel görebilmeyi saglar
                        txtCalisanSayisi.Text= (Face.Calisan.CalisanSayisi()).ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Silme İşlemi İptal Edildi");
                }
            }
        }

        private void lstCalisan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCalisan.SelectedItems.Count >0)
            {
                txtPersonelID.Text = lstCalisan.SelectedItems[0].SubItems[0].Text;
                txtCalisanAd.Text = lstCalisan.SelectedItems[0].SubItems[1].Text;
                txtCalisanSoyad.Text = lstCalisan.SelectedItems[0].SubItems[2].Text;
                txtCalisanEmail.Text = lstCalisan.SelectedItems[0].SubItems[3].Text;
                txtCalisanTelefon.Text = lstCalisan.SelectedItems[0].SubItems[4].Text;
                txtSubeID.Text = lstCalisan.SelectedItems[0].SubItems[5].Text;
                txtSubeAdi.Text = lstCalisan.SelectedItems[0].SubItems[6].Text;
                txtCalisanEvAdresi.Text = lstCalisan.SelectedItems[0].SubItems[7].Text;
                txtCalisanKullaniciAdi.Text = lstCalisan.SelectedItems[0].SubItems[8].Text;
                txtCalisanTipID.Text = lstCalisan.SelectedItems[0].SubItems[9].Text;
                txtCalisanTipAdi.Text = lstCalisan.SelectedItems[0].SubItems[10].Text;

                if (lstCalisan.SelectedItems[0].SubItems[11].Text=="Evet")
                {
                    rbYonetici.Checked = true;
                    rbCalisan.Checked = false;
                }
                else if (lstCalisan.SelectedItems[0].SubItems[11].Text=="Hayır")
                {
                    rbCalisan.Checked = true;
                    rbYonetici.Checked = false;
                }
                txtSifre.Text = lstCalisan.SelectedItems[0].SubItems[12].Text;
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if ((txtCalisanAd.Text == "") || (txtCalisanSoyad.Text == "") || (txtCalisanTelefon.Text == "") || (txtCalisanEmail.Text == "") || (txtCalisanEvAdresi.Text == "") || (txtCalisanKullaniciAdi.Text == "") || (txtCalisanTipAdi.Text == "") || (txtCalisanTipID.Text == "") || (txtSubeAdi.Text == "") || (txtSubeID.Text == "") || (txtSifre.Text == "") || (rbYonetici.Checked == false && rbCalisan.Checked == false))
            {
                MessageBox.Show("Tüm Alanlar Doldurulmalıdır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lstCalisan.FullRowSelect = true;
            }
            else
            {
                if (txtPersonelID.Text=="")
                {
                    MessageBox.Show("Lütfen seçiminizi liste üzerine tıklayarak yapınız!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Entity.Calisan gnccl = new Entity.Calisan();
                    gnccl.PersonelID = Convert.ToInt32(txtPersonelID.Text);
                    gnccl.PersonelAdi = Face.Kontrol.Temizle(txtCalisanAd.Text);
                    gnccl.PersonelSoyadi = Face.Kontrol.Temizle(txtCalisanSoyad.Text);
                    gnccl.PersonelEmail = Face.Kontrol.Temizle(txtCalisanEmail.Text);
                    gnccl.PersonelTelefon = Face.Kontrol.Temizle(txtCalisanTelefon.Text);
                    gnccl.SubeID = Convert.ToInt32(Face.Kontrol.Temizle(txtSubeID.Text));
                    gnccl.EvAdresi = Face.Kontrol.Temizle(txtCalisanEvAdresi.Text);
                    gnccl.KullaniciAdi = Face.Kontrol.Temizle(txtCalisanKullaniciAdi.Text);

                    gnccl.CalisanTipiID = Convert.ToInt32(Face.Kontrol.Temizle(txtCalisanTipID.Text));

                    if (rbYonetici.Checked)
                    {
                        gnccl.YoneticiMi = true;
                    }
                    else if (rbCalisan.Checked)
                    {
                        gnccl.YoneticiMi = false;
                    }
                    
                    gnccl.Sifre = Face.Kontrol.Temizle(txtSifre.Text);
                    
                    if (Face.Calisan.CalisanGuncelle(gnccl) > 0) 
                    {
                        MessageBox.Show("Çalışan Güncellendi");
                        Temizle();
                        lstCalisan.FullRowSelect = true; 
                        Face.Calisan.CalisanListesi(lstCalisan);
                        Face.Sube.SubeListele(cbSubeAdi);
                        Face.CalisanTip.CalisanTipGetir(cbCalisanTip);

                    }
                }
                
            }
        }

        private void txtAranacakCalisan_TextChanged(object sender, EventArgs e)
        {
            Face.Calisan.AdaGoreCalisanGetir(lstCalisan, txtAranacakCalisan.Text);
        }

        private void txtAranacakSube_TextChanged(object sender, EventArgs e)
        {
            Face.Calisan.SubeAdinaGoreCalisanGetir(lstCalisan, txtAranacakSube.Text);            
        }
    }
}
