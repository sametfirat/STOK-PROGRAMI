namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlIslemListesi = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.grpBoxIslemListesi = new System.Windows.Forms.GroupBox();
            this.btnUygulamaKapa = new System.Windows.Forms.Button();
            this.btnKayitListele = new System.Windows.Forms.Button();
            this.btnYeniKayit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblZaman = new System.Windows.Forms.Label();
            this.tm_Zamanla = new System.Windows.Forms.Timer(this.components);
            this.pnlIslemListesi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.grpBoxIslemListesi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlIslemListesi
            // 
            this.pnlIslemListesi.Controls.Add(this.pictureBox2);
            this.pnlIslemListesi.Controls.Add(this.grpBoxIslemListesi);
            this.pnlIslemListesi.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlIslemListesi.Location = new System.Drawing.Point(0, 0);
            this.pnlIslemListesi.Name = "pnlIslemListesi";
            this.pnlIslemListesi.Size = new System.Drawing.Size(200, 455);
            this.pnlIslemListesi.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(176, 128);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // grpBoxIslemListesi
            // 
            this.grpBoxIslemListesi.Controls.Add(this.btnUygulamaKapa);
            this.grpBoxIslemListesi.Controls.Add(this.btnKayitListele);
            this.grpBoxIslemListesi.Controls.Add(this.btnYeniKayit);
            this.grpBoxIslemListesi.Location = new System.Drawing.Point(12, 158);
            this.grpBoxIslemListesi.Name = "grpBoxIslemListesi";
            this.grpBoxIslemListesi.Size = new System.Drawing.Size(176, 154);
            this.grpBoxIslemListesi.TabIndex = 3;
            this.grpBoxIslemListesi.TabStop = false;
            this.grpBoxIslemListesi.Text = "İşlem Listesi";
            // 
            // btnUygulamaKapa
            // 
            this.btnUygulamaKapa.Location = new System.Drawing.Point(6, 77);
            this.btnUygulamaKapa.Name = "btnUygulamaKapa";
            this.btnUygulamaKapa.Size = new System.Drawing.Size(164, 23);
            this.btnUygulamaKapa.TabIndex = 0;
            this.btnUygulamaKapa.Text = "Uygulama Kapa";
            this.btnUygulamaKapa.UseVisualStyleBackColor = true;
            this.btnUygulamaKapa.UseWaitCursor = true;
            this.btnUygulamaKapa.Click += new System.EventHandler(this.btnUygulamaKapa_Click);
            // 
            // btnKayitListele
            // 
            this.btnKayitListele.Location = new System.Drawing.Point(6, 48);
            this.btnKayitListele.Name = "btnKayitListele";
            this.btnKayitListele.Size = new System.Drawing.Size(164, 23);
            this.btnKayitListele.TabIndex = 0;
            this.btnKayitListele.Text = "Ürün Listele";
            this.btnKayitListele.UseVisualStyleBackColor = true;
            this.btnKayitListele.Click += new System.EventHandler(this.btnKayitListele_Click);
            // 
            // btnYeniKayit
            // 
            this.btnYeniKayit.Location = new System.Drawing.Point(6, 19);
            this.btnYeniKayit.Name = "btnYeniKayit";
            this.btnYeniKayit.Size = new System.Drawing.Size(164, 23);
            this.btnYeniKayit.TabIndex = 0;
            this.btnYeniKayit.Text = "Yeni Ürün Ekle";
            this.btnYeniKayit.UseVisualStyleBackColor = true;
            this.btnYeniKayit.Click += new System.EventHandler(this.btnYeniKayit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(829, 419);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 36);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblZaman
            // 
            this.lblZaman.AutoSize = true;
            this.lblZaman.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblZaman.Location = new System.Drawing.Point(856, 427);
            this.lblZaman.Name = "lblZaman";
            this.lblZaman.Size = new System.Drawing.Size(133, 20);
            this.lblZaman.TabIndex = 3;
            this.lblZaman.Text = "10.10.2023 22:40";
            this.lblZaman.Click += new System.EventHandler(this.lblZaman_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 455);
            this.Controls.Add(this.lblZaman);
            this.Controls.Add(this.pnlIslemListesi);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "toda-uygulama";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlIslemListesi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.grpBoxIslemListesi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlIslemListesi;
        private System.Windows.Forms.GroupBox grpBoxIslemListesi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnUygulamaKapa;
        private System.Windows.Forms.Button btnKayitListele;
        private System.Windows.Forms.Button btnYeniKayit;
        private System.Windows.Forms.Label lblZaman;
        private System.Windows.Forms.Timer tm_Zamanla;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

