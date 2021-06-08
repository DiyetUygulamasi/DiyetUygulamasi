using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetUygulamasi
{
    public abstract class Hasta
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public double Tc { get; set; }
        public string Hastalik { get; set; }

        protected IDiyet diyet;
        public Hasta(IDiyet diyet)
        {
            this.diyet = diyet;
        }
        public abstract void hastaOlustur(string Ad, string Soyad, double TC, string Hastalik);
    }
}
