using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using WindowsFormsApp1.entitis;

namespace WindowsFormsApp1.DataBase
{
   public static class sanalDataBase
    {
        public static List<kulanici> kulanıcıTablo;
        public static List<todo> todoTablo;
        static sanalDataBase()
        {
            kulanıcıTablo = new List<kulanici>();
            kulanıcıTablo.Add(new kulanici() { kulaniciId = Guid.NewGuid(), kulaniciAdı = "samet", sifre = "samet" }); ;
            todoTablo = new List<todo>();
            todoTablo.Add(new todo() { acıklama = "KABAN  VE HIRKA ",durumAcıklama ="Stokta  Yok"}); ;
        }

    }
}
