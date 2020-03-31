using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtobusOtomasyonHazirlanmasii.SubeIslemleri
{
    public partial class FrmSubeIslemleri : Form
    {
        public FrmSubeIslemleri()
        {
            InitializeComponent();
        }

        private void lstCalisan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmSubeIslemleri_Load(object sender, EventArgs e)
        {
            this.Top = 80;
            this.Left = 80;
            Face.Sube.SubeListesi(lsvSube);
            txtListelenenKayitSayisi.Text = Convert.ToString(lsvSube.Items.Count);
            gbSubeEkle.Visible = false;
            Face.Sube.SubeListele(cbSubeler);
            Face.Sehir.SehirListele(cbSehirler);
            btnGuncelle.Enabled = false;

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lsvSube_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem li = lsvSube.SelectedItems[0]; //sube listelede [0]subeID, [1]sehirId, [2]subeAdi, [3]sehirAdi 
            FrmSubeDetay frm = new FrmSubeDetay(li.Text);
            frm.Show();
        }

        private void lsvSube_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            btnGuncelle.Enabled = true;
            btnSil.Enabled = true;
            btnEkle.Enabled = true;
            Temizle();
        }

        private void Temizle()
        {
            txtSehirAdi.Clear();
            txtSehirID.Clear();
            txtEklenecekSubeAdi.Clear();
            txtArananSube.Clear();
            txtSubeID.Text="";
            txtSubeAdi.Clear();
        }

        private void txtArananSube_TextChanged(object sender, EventArgs e)
        {
            Face.Sube.SubeAra(lsvSube, txtArananSube.Text);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            gbSubeEkle.Visible = true;
            if ((txtEklenecekSubeAdi.Text=="") || (cbSehirler.SelectedItem.ToString()==""))
            {
                //MessageBox.Show("Eklenecek Şube Adı Boş Bırakılamaz ve Şehir Adı Boş Bırakılamaz", "Dikkat Eksik Bilgi!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //lblUyari.Text = "UYARI: Şube ekleyebilmek için öncelikle şehir seçiniz.";
            }
            else
            {
                bool sonuc = Face.Sube.SubeVarmi(txtEklenecekSubeAdi.Text);
                if (sonuc)
                {
                    MessageBox.Show("Var Olan Bir Şubeyi Eklemek İstemektesiniz!");
                }
                else
                {
                    Entity.Sube sb = new Entity.Sube();
                    sb.SubeAdi = Face.Kontrol.Temizle(txtEklenecekSubeAdi.Text);
                    sb.SehirID = Convert.ToInt32(Face.Kontrol.Temizle(txtSehirID.Text));

                    int etkilenensatirsayisi = Face.Sube.SubeEkle(sb);
                    if (etkilenensatirsayisi>0)
                    {
                        MessageBox.Show("Şube Ekleme İşlemi Başarılı");
                        Face.Sehir.SehirListele(cbSehirler);
                        Face.Sube.SubeListele(cbSubeler);
                        Face.Sube.SubeListesi(lsvSube);
                        btnEkle.Enabled = false;
                        btnYeni.Enabled = true;
                        Temizle();
                    }
                    else
                    {
                        MessageBox.Show("Şube Ekleme Sırasında Hata Meydana Geldi");
                    }
                }
            }
        }

        private void cbSehirler_SelectedIndexChanged(object sender, EventArgs e)
        {

            Entity.Sehir sh = (Entity.Sehir)(cbSehirler.SelectedItem);
            //Entity.Sehir sh = new Entity.Sehir();
            //sh = Entity.Sehir(cbSehirler.SelectedItem);
            txtSehirID.Text = Convert.ToString(sh.SehirID);
            txtSehirAdi.Text = Convert.ToString(sh.SehirAdi);
            txtSehirAdi.Focus();
            
        }
        //string guncellenecekSubeAd = "";
        private void cbSubeler_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            Entity.Sube sube = (Entity.Sube)(cbSubeler.SelectedItem);
            txtSubeID.Text = Convert.ToString(sube.SubeID);
            txtSubeAdi.Text = sube.SubeAdi;
            txtSehirAdi.Focus();
            txtSubeAdi.ReadOnly = false;
            btnGuncelle.Enabled = true;
            
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            
            if (txtSubeAdi.Text=="" || txtSubeID.Text=="")
            {
                MessageBox.Show("Şube Güncellemek İçin Şehir ve Şube Seçilmelidir","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
            else
            {
                //txtSubeAdi.ReadOnly = false;
                Entity.Sube sb = new Entity.Sube();
                sb.SubeID = Convert.ToInt32(txtSubeID.Text);
                sb.SehirID = Convert.ToInt32(txtSehirID.Text);
                sb.SubeAdi = Face.Kontrol.Temizle(txtSubeAdi.Text);
                int etkilenensatirsayisi= Face.Sube.SubeGuncelle(sb);
                if (etkilenensatirsayisi>0)
                {
                    MessageBox.Show("Şube Güncelleme İşlemi Tamamlandı");
                    
                    Face.Sube.SubeListesi(lsvSube);
                    Face.Sube.SubeListele(cbSubeler);
                    Face.Sehir.SehirListele(cbSehirler);
                    btnGuncelle.Enabled = false;
                    btnEkle.Enabled = false;
                    btnSil.Enabled = false;
                    btnYeni.Enabled = true;
                    Temizle();
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

            
            if (txtSubeAdi.Text=="")
            {
                MessageBox.Show("Şube Silmek İçin Mevcut Şubelerden Seçim Yapınız", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                if (MessageBox.Show("Silmek İstediğiniden Emin Misiniz", "Silinsin Mi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    Entity.Sube sb = new Entity.Sube();
                    sb.SubeID = Convert.ToInt32(txtSubeID.Text);
                    int etkinensayisi = Face.Sube.SubeSil(sb);
                    if (etkinensayisi>0)
                    {
                        MessageBox.Show("Silme İşlemi Başarılı");

                        Face.Sube.SubeListesi(lsvSube);
                        Face.Sube.SubeListele(cbSubeler);
                        Face.Sehir.SehirListele(cbSehirler);
                        btnGuncelle.Enabled = false;
                        btnEkle.Enabled = false;
                        btnSil.Enabled = false;
                        btnYeni.Enabled = true;
                        Temizle();
                    }
                    else
                    {
                        MessageBox.Show("Silme İşlemi Sırasında Hata Meydana Geldi");
                    }
                }
                else
                {
                    MessageBox.Show("Silme İşleminden Vazgeçildi");
                }

            }
        }
    }
}
