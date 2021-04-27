using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Business
{
    public class OgrBilgi
    {
        public int FkSinifId { get; set; }
        public string OgrAd { get; set; }
        public string OgrSoyad { get; set; }
        public Nullable<int> OgrNo { get; set; }
        public Nullable<System.DateTime> DevamsizlikTarih { get; set; }
        public string DevamsizlikTur { get; set; }

       

    }
}
