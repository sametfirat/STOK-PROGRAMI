using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DataBase;
using WindowsFormsApp1.entitis;

namespace WindowsFormsApp1.businissservice
{
    public class kulanciServis
    {
        public kulanici kulanciKontrol(string kulaniciAdi ,string sifre)
        {
            return sanalDataBase.kulanıcıTablo.Where(x => x.kulaniciAdı == kulaniciAdi &&
            x.sifre == sifre).FirstOrDefault();
        }
    }
}
