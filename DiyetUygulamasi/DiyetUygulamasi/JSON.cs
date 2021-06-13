using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetUygulamasi
{
    class JSON:Cikti
    {
        public JSON()
        {
            hastaBilgi = new HastaBilgi();
        }

        public override void DiyetBilgiCikti()
        {
            hastaBilgi.DiyetAd = "";
        }

        public override void KisiselBilgiCikti()
        {
            hastaBilgi.Ad = "";
        }
    }
}
