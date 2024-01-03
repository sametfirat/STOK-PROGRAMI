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
    public partial class yeniKayit : Form
    {
        public yeniKayit()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBaslık_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.Green;
        }

        private void txtBaslık_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.White;
        }

        private void txtBaslık_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            todosevice todosevic = new todosevice();
            int sonuc = todosevic.yenikayit(new entitis.todo()
            {
                kulanciId = Guid.NewGuid(),
                baslık = txtBaslık.Text,
                kisaAcıklama = txtKisaAciklama.Text,
                acıklama = txtAciklama.Text,
                durumAcıklama = cBoxDurum.SelectedItem.ToString(),
                olusturmaTarihi = DateTime.Now,
                onemDersecesi = Convert.ToInt32(txtOnemDerecesi.Text)

            });
            if (sonuc == 0)
            {
                MessageBox.Show("Kayıt Tamamlandı", "Bilgilendirme",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult result = MessageBox.Show("YENİ KAYIT EKLEMEK İSTERMİSİNİZ", "bİLGİLENDİRME",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    foreach (Control item in this.Controls)
                    {
                        if (item is TextBox)
                        {
                            ((TextBox)item).Text = string.Empty;
                        }
                    }
                }
                else
                {
                    Form kayitList = Application.OpenForms["kayitList"];
                    if (kayitList == null)
                    {
                        kayitList = new kayıtList();
                        
                        kayitList.StartPosition = FormStartPosition.CenterScreen;
                        kayitList.Show();
                        this.Close();
                    }
                    else
                    {
                        GroupBox list = (GroupBox)kayitList.Controls["grpBoxListe"];
                        DataGridView grdliste = (DataGridView)list.Controls["dgvListe"];
                        List<todo> guncelle = todosevic.kayitListesi();
                        grdliste.DataSource = null;
                        grdliste.DataSource = guncelle;
                        this.Close();

                    }

                }
            }
            else
            {
                MessageBox.Show("Bir Hata Oluştu", "Bilgilendirme",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void cBoxDurum_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
