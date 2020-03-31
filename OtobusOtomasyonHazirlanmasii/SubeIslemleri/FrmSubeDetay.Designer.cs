namespace OtobusOtomasyonHazirlanmasii.SubeIslemleri
{
    partial class FrmSubeDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSubeDetay));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSubeID = new System.Windows.Forms.Label();
            this.lblSubeAdi = new System.Windows.Forms.Label();
            this.lblSehirID = new System.Windows.Forms.Label();
            this.lblSehirAdi = new System.Windows.Forms.Label();
            this.lblCalisanSayisi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Şube Numarası:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şube Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Şehir Numarası:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Şehir Adı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Çalışan Sayısı:";
            // 
            // lblSubeID
            // 
            this.lblSubeID.AutoSize = true;
            this.lblSubeID.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblSubeID.Location = new System.Drawing.Point(197, 58);
            this.lblSubeID.Name = "lblSubeID";
            this.lblSubeID.Size = new System.Drawing.Size(18, 17);
            this.lblSubeID.TabIndex = 5;
            this.lblSubeID.Text = "--";
            // 
            // lblSubeAdi
            // 
            this.lblSubeAdi.AutoSize = true;
            this.lblSubeAdi.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblSubeAdi.Location = new System.Drawing.Point(197, 110);
            this.lblSubeAdi.Name = "lblSubeAdi";
            this.lblSubeAdi.Size = new System.Drawing.Size(18, 17);
            this.lblSubeAdi.TabIndex = 6;
            this.lblSubeAdi.Text = "--";
            // 
            // lblSehirID
            // 
            this.lblSehirID.AutoSize = true;
            this.lblSehirID.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblSehirID.Location = new System.Drawing.Point(197, 158);
            this.lblSehirID.Name = "lblSehirID";
            this.lblSehirID.Size = new System.Drawing.Size(18, 17);
            this.lblSehirID.TabIndex = 7;
            this.lblSehirID.Text = "--";
            // 
            // lblSehirAdi
            // 
            this.lblSehirAdi.AutoSize = true;
            this.lblSehirAdi.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblSehirAdi.Location = new System.Drawing.Point(197, 209);
            this.lblSehirAdi.Name = "lblSehirAdi";
            this.lblSehirAdi.Size = new System.Drawing.Size(18, 17);
            this.lblSehirAdi.TabIndex = 8;
            this.lblSehirAdi.Text = "--";
            // 
            // lblCalisanSayisi
            // 
            this.lblCalisanSayisi.AutoSize = true;
            this.lblCalisanSayisi.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblCalisanSayisi.Location = new System.Drawing.Point(197, 252);
            this.lblCalisanSayisi.Name = "lblCalisanSayisi";
            this.lblCalisanSayisi.Size = new System.Drawing.Size(18, 17);
            this.lblCalisanSayisi.TabIndex = 9;
            this.lblCalisanSayisi.Text = "--";
            // 
            // FrmSubeDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 450);
            this.Controls.Add(this.lblCalisanSayisi);
            this.Controls.Add(this.lblSehirAdi);
            this.Controls.Add(this.lblSehirID);
            this.Controls.Add(this.lblSubeAdi);
            this.Controls.Add(this.lblSubeID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSubeDetay";
            this.Text = "Şube Detayları";
            this.Load += new System.EventHandler(this.FrmSubeDetay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSubeID;
        private System.Windows.Forms.Label lblSubeAdi;
        private System.Windows.Forms.Label lblSehirID;
        private System.Windows.Forms.Label lblSehirAdi;
        private System.Windows.Forms.Label lblCalisanSayisi;
    }
}