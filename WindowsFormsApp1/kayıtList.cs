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
    public partial class kayıtList : Form
    {
        todosevice todosevice;

        public kayıtList()
        {
            InitializeComponent();
            todosevice = new todosevice();
        }

        private void kayıtList_Load(object sender, EventArgs e)
        {
            dgvListe.DataSource = tümlist();
            dgvListe.Columns["kulanciId"].Visible = false;

        }
        private List<todo> tümlist()
        {
            return todosevice.kayitListesi();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgvListe.DataSource = tümlist();
            dgvListe.Columns["kulanciId"].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvListe.DataSource = tümlist().Where(x=>x.durumAcıklama == "Stokta Bulunuyor").ToList();
            dgvListe.Columns["kulanciId"].Visible = false;
        }

        private void btntmmlanmayanyanlar_Click(object sender, EventArgs e)
        {
            dgvListe.DataSource = tümlist().Where(x => x.durumAcıklama == "Bekleniyor").ToList();
            dgvListe.Columns["kulanciId"].Visible = false;
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            dgvListe.DataSource = tümlist().Where(x => x.durumAcıklama == "Stokta Yok").ToList();
            dgvListe.Columns["kulanciId"].Visible = false;
        }
    }
}
