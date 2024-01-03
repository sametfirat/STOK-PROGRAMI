using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.businissservice;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Form t;
        public Form1()
        {
            InitializeComponent();
        }

        private void lblZaman_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void buttonACKapa(bool kontrol)
        {
            foreach (Control item in grpBoxIslemListesi.Controls)
            {
                if (item is Button)
                    ((Button)item).Enabled = false;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tm_Zamanla.Interval = 15000;
            tm_Zamanla.Tick += Tm_Zamanla_Tick;
            tm_Zamanla.Start();
            buttonACKapa(false);
            Form2 kulanıcıKontrol = new Form2();
            kulanıcıKontrol.MdiParent = this;
            kulanıcıKontrol.StartPosition = FormStartPosition.CenterScreen;
            kulanıcıKontrol.Show();
            
        }

        private void Tm_Zamanla_Tick(object sender, EventArgs e)
        {
            lblZaman.Text = DateTime.Now.ToString("dd.MM.yyyy hh:mm");
        }

        private void btnUygulamaKapa_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms ["yeniKayit"] != null)
            {
                t = Application.OpenForms["yeniKayit"];
                t.Focus();
            }
            else
            {
                t = new yeniKayit();
                t.MdiParent = this;
                t.Show();
            }
        }

        private void btnKayitListele_Click(object sender, EventArgs e)
        {
            todosevice todosevice = new todosevice();
            if (todosevice.kayitKontrol() > 0)
            {
                kayıtList kayıtList =new kayıtList();
                kayıtList.MdiParent=this;
                kayıtList.Show();
            }
            else
            {
                MessageBox.Show("Listenecek Kayıt Bulunamadı", "Bilgi"
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
