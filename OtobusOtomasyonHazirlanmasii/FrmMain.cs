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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        public static Entity.Calisan calisan = null; //oturum açan kullanıcı bilgileri

        
        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.Hide();
            FrmGiris frm = new FrmGiris();
            if (frm.ShowDialog()==DialogResult.OK)
            {
                this.Show();
                YetkiyeGoreMenuGoster();
            }
            else
            {
                Application.Exit();

            }
        }
        private void YetkiyeGoreMenuGoster()
        {
            if (!calisan.YoneticiMi)
            {
                mnSeferIslemleri.Visible = false;
                mnSubeIslemleri.Visible = false;
                mnPersonelIslemleri.Visible = false;
                mnMasrafIslemleri.Visible = false;
                //mnCalisanIslemleri.Visible = false;
                mnMarkaIslemleri.Visible = false;
                mnOtobüsİşlemleri.Visible = false;
                mnsRaporlar.Visible = false;
                mnMusteriIslemleri.Visible = false;

            }

        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //çalışan login olmuşsa, yani çalışan varsa 

            if (calisan != null)
            {
                //giriş çıkış bilgileri tutulacak, hata yapıldığında hatanın kimin tarafından yapıldığını bulmak için

                Entity.PersonelGirisCikis cikisBilgileri = new Entity.PersonelGirisCikis();
                cikisBilgileri.PersonelID = FrmMain.calisan.PersonelID;
                cikisBilgileri.IslemTipi = false;
                Face.PersonelGirisCikis.PersonelGirisCikisEkle(cikisBilgileri);
            }
        }

        private void mnSubeIslemleri_Click(object sender, EventArgs e)
        {
            SubeIslemleri.FrmSubeIslemleri frm = new SubeIslemleri.FrmSubeIslemleri();
            FormAcikMi(frm);
        }

        private void FormAcikMi(Form acilacakForm)
        {
            bool acikMi = false;
            //ne kadar form açıldı ise o uzunlukta bir for döngüsü
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                if (acilacakForm.Name==MdiChildren[i].Name) 
                {
                    this.MdiChildren[i].Focus();
                    acikMi = true;
                }
            }
            if (acikMi==false)
            {
                acilacakForm.MdiParent = this;
                acilacakForm.Show();
            }
            else
            {
                acilacakForm.Dispose(); 
            }
        }

        private void mnsCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
