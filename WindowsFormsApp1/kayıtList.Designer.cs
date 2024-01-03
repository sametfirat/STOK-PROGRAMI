namespace WindowsFormsApp1
{
    partial class kayıtList
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btntam = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btntümülist = new System.Windows.Forms.Button();
            this.grpBoxListe = new System.Windows.Forms.GroupBox();
            this.dgvListe = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnIptal = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btntmmlanmayanyanlar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.grpBoxListe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btntam);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.btntümülist);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 413);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İşlem Listesi";
            // 
            // btntam
            // 
            this.btntam.Location = new System.Drawing.Point(6, 94);
            this.btntam.Name = "btntam";
            this.btntam.Size = new System.Drawing.Size(188, 29);
            this.btntam.TabIndex = 0;
            this.btntam.Text = "Tamamlananlar";
            this.btntam.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Location = new System.Drawing.Point(6, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 413);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "İşlem Listesi";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 94);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(188, 29);
            this.button3.TabIndex = 0;
            this.button3.Text = "Tamamlananlar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 59);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(188, 29);
            this.button4.TabIndex = 0;
            this.button4.Text = "Tümünü Listele";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btntümülist
            // 
            this.btntümülist.Location = new System.Drawing.Point(6, 59);
            this.btntümülist.Name = "btntümülist";
            this.btntümülist.Size = new System.Drawing.Size(188, 29);
            this.btntümülist.TabIndex = 0;
            this.btntümülist.Text = "Tümünü Listele";
            this.btntümülist.UseVisualStyleBackColor = true;
            // 
            // grpBoxListe
            // 
            this.grpBoxListe.Controls.Add(this.dgvListe);
            this.grpBoxListe.Location = new System.Drawing.Point(246, 12);
            this.grpBoxListe.Name = "grpBoxListe";
            this.grpBoxListe.Size = new System.Drawing.Size(649, 413);
            this.grpBoxListe.TabIndex = 1;
            this.grpBoxListe.TabStop = false;
            this.grpBoxListe.Text = "Liste";
            // 
            // dgvListe
            // 
            this.dgvListe.AllowUserToAddRows = false;
            this.dgvListe.AllowUserToDeleteRows = false;
            this.dgvListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListe.Location = new System.Drawing.Point(3, 16);
            this.dgvListe.Name = "dgvListe";
            this.dgvListe.ReadOnly = true;
            this.dgvListe.Size = new System.Drawing.Size(643, 394);
            this.dgvListe.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnIptal);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.btntmmlanmayanyanlar);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(18, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 413);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlem Listesi";
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(6, 164);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(188, 29);
            this.btnIptal.TabIndex = 0;
            this.btnIptal.Text = "Stokta Bulunmayanlar";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(0, 164);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(188, 29);
            this.button5.TabIndex = 0;
            this.button5.Text = "Tamamlanmayanlar";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btntmmlanmayanyanlar
            // 
            this.btntmmlanmayanyanlar.Location = new System.Drawing.Point(6, 129);
            this.btntmmlanmayanyanlar.Name = "btntmmlanmayanyanlar";
            this.btntmmlanmayanyanlar.Size = new System.Drawing.Size(188, 29);
            this.btntmmlanmayanyanlar.TabIndex = 0;
            this.btntmmlanmayanyanlar.Text = "Gelecek Ürünler";
            this.btntmmlanmayanyanlar.UseVisualStyleBackColor = true;
            this.btntmmlanmayanyanlar.Click += new System.EventHandler(this.btntmmlanmayanyanlar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Stokta Bulunanlar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 29);
            this.button2.TabIndex = 0;
            this.button2.Text = "Ürünleri Listele";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // kayıtList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 450);
            this.Controls.Add(this.grpBoxListe);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "kayıtList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "todo-kayıt liste";
            this.Load += new System.EventHandler(this.kayıtList_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.grpBoxListe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btntümülist;
        private System.Windows.Forms.GroupBox grpBoxListe;
        private System.Windows.Forms.DataGridView dgvListe;
        private System.Windows.Forms.Button btntam;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btntmmlanmayanyanlar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}