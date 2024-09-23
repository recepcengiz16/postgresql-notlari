using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostgreUrunProje.Models
{
    public class Urun
    {
        public int urunid { get; set; }
        public string urunad { get; set; }
        public int stok { get; set; }
        public double alisfiyat { get; set; }
        public double satisfiyat { get; set; }
        public string gorsel { get; set; }
        public int kategori { get; set; }
    }
}
