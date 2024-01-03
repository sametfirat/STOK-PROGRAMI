using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.entitis
{
    public class todo
    {
        [DisplayName("ID")]
        public Guid kulanciId { get; set; }
        [DisplayName("Başlık")]
        public string baslık { get; set; }
        [DisplayName("Kısa Acıklama")]
        public string kisaAcıklama { get; set; }
        [DisplayName("Acıklama")]
        public string acıklama { get; set; }
        public int onemDersecesi { get; set; }
        public string durumAcıklama { get; set; }
        public DateTime olusturmaTarihi { get; set; }
    }
}
