namespace WindowsFormsApp1
{
    partial class yeniKayit
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
            this.üRÜNKOD = new System.Windows.Forms.Label();
            this.txtBaslık = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKisaAciklama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOnemDerecesi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cBoxDurum = new System.Windows.Forms.ComboBox();
            this.btnKayit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // üRÜNKOD
            // 
            this.üRÜNKOD.AutoSize = true;
            this.üRÜNKOD.Location = new System.Drawing.Point(38, 41);
            this.üRÜNKOD.Name = "üRÜNKOD";
            this.üRÜNKOD.Size = new System.Drawing.Size(65, 13);
            this.üRÜNKOD.TabIndex = 0;
            this.üRÜNKOD.Text = "Stok Tip Adı";
            // 
            // txtBaslık
            // 
            this.txtBaslık.Location = new System.Drawing.Point(131, 38);
            this.txtBaslık.Name = "txtBaslık";
            this.txtBaslık.Size = new System.Drawing.Size(215, 20);
            this.txtBaslık.TabIndex = 0;
            this.txtBaslık.TextChanged += new System.EventHandler(this.txtBaslık_TextChanged);
            this.txtBaslık.Enter += new System.EventHandler(this.txtBaslık_Enter);
            this.txtBaslık.Leave += new System.EventHandler(this.txtBaslık_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Detayları";
            // 
            // txtKisaAciklama
            // 
            this.txtKisaAciklama.Location = new System.Drawing.Point(131, 70);
            this.txtKisaAciklama.Multiline = true;
            this.txtKisaAciklama.Name = "txtKisaAciklama";
            this.txtKisaAciklama.Size = new System.Drawing.Size(215, 97);
            this.txtKisaAciklama.TabIndex = 1;
            this.txtKisaAciklama.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txtKisaAciklama.Enter += new System.EventHandler(this.txtBaslık_Enter);
            this.txtKisaAciklama.Leave += new System.EventHandler(this.txtBaslık_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Malzeme Ve Bakım";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(131, 191);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(215, 97);
            this.txtAciklama.TabIndex = 2;
            this.txtAciklama.Enter += new System.EventHandler(this.txtBaslık_Enter);
            this.txtAciklama.Leave += new System.EventHandler(this.txtBaslık_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Stok Adeti";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtOnemDerecesi
            // 
            this.txtOnemDerecesi.Location = new System.Drawing.Point(131, 310);
            this.txtOnemDerecesi.Name = "txtOnemDerecesi";
            this.txtOnemDerecesi.Size = new System.Drawing.Size(215, 20);
            this.txtOnemDerecesi.TabIndex = 3;
            this.txtOnemDerecesi.Enter += new System.EventHandler(this.txtBaslık_Enter);
            this.txtOnemDerecesi.Leave += new System.EventHandler(this.txtBaslık_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Stok Durumu";
            // 
            // cBoxDurum
            // 
            this.cBoxDurum.FormattingEnabled = true;
            this.cBoxDurum.Items.AddRange(new object[] {
            "Stokta Var",
            "Bekleniyor",
            "Stokta Yok"});
            this.cBoxDurum.Location = new System.Drawing.Point(131, 339);
            this.cBoxDurum.Name = "cBoxDurum";
            this.cBoxDurum.Size = new System.Drawing.Size(215, 21);
            this.cBoxDurum.TabIndex = 4;
            this.cBoxDurum.SelectedIndexChanged += new System.EventHandler(this.cBoxDurum_SelectedIndexChanged);
            // 
            // btnKayit
            // 
            this.btnKayit.Location = new System.Drawing.Point(131, 386);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(215, 27);
            this.btnKayit.TabIndex = 5;
            this.btnKayit.Text = "Kaydet";
            this.btnKayit.UseVisualStyleBackColor = true;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // yeniKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 465);
            this.Controls.Add(this.btnKayit);
            this.Controls.Add(this.cBoxDurum);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKisaAciklama);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtOnemDerecesi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBaslık);
            this.Controls.Add(this.üRÜNKOD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "yeniKayit";
            this.Text = "todo -yeniKayit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label üRÜNKOD;
        private System.Windows.Forms.TextBox txtBaslık;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKisaAciklama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOnemDerecesi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cBoxDurum;
        private System.Windows.Forms.Button btnKayit;
    }
}