using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetUygulamasi
{
    public interface IDiyet
    {
        string DiyetAdi { get; set; }
        string DiyetListesi { get; set; }
        void DiyetAta(Hasta hasta)
        {
            this.DiyetAdi = DiyetAdi;
            this.DiyetListesi = DiyetListesi;
        }

    }
}
