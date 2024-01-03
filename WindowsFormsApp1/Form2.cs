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
using WindowsFormsApp1.entitis;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textKulanıciAdi_Enter(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            t.BackColor = Color.LightYellow; 
        }

        private void textKulanıciAdi_Leave(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            t.BackColor = Color.White;   
        }

        private void btnGiriş_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textKulanıciAdi.Text) || !string.IsNullOrEmpty(textSifre.Text))
            {
                kulanciServis kulanciServis = new kulanciServis();
               kulanici kulanıcıKontrol = kulanciServis.kulanciKontrol(textKulanıciAdi.Text, textSifre.Text);
                if (kulanıcıKontrol != null)
                {
                    Form anaform = Application.OpenForms["Form1"];
                    Panel solPanel = (Panel)anaform.Controls["pnlIslemListesi"];
                    GroupBox gbIslemListesi = (GroupBox)solPanel.Controls["grpBoxIslemListesi"];
                    foreach(Control item in gbIslemListesi.Controls)
                    {
                        if (item is Button)
                        {
                            item.Enabled = true;
                        }
                    }
                    MessageBox.Show("Hoşgeldiniz "+ kulanıcıKontrol.kulaniciAdı, 
                        "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Kulanıcı Bilgileriz Yanlıştır", "Hata"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else 
            {
                MessageBox.Show("Lütfen Bilgileri Doldurunuz","Bilgilendirme"
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
