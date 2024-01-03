using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DataBase;
using WindowsFormsApp1.entitis;

namespace WindowsFormsApp1.businissservice
{
    public class todosevice
    {
        public int kayitKontrol ()
        {
            return sanalDataBase.todoTablo.Count;
        }

        public List<todo> kayitListesi()
        {
            return sanalDataBase.todoTablo;
        }
        public int yenikayit(todo data)
        {
            
            try
            {
                sanalDataBase.todoTablo.Add(data);
                return 0;

            }
            catch(Exception ex)
            {
                return 1;
            }
        }
    }
}
