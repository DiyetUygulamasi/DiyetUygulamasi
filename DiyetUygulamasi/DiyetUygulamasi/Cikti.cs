using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetUygulamasi
{
    public abstract class Cikti
    {
        protected HastaBilgi hastaBilgi;

        public HastaBilgi HastaBilgi
        {
            get { return hastabilgi; }
        }

        public abstract void SosuHazirla();
        public abstract void HamuruHazirla();

    }
}
