using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetUygulamasi
{
    class Obez:Hasta
    {
        public Obez(IDiyet diyet) : base(diyet)
        {
        }
        public override void diyetAta(string diyetIsim)
        {
            this.diyet.DiyetOlustur(diyetIsim);
        }
    }
}
