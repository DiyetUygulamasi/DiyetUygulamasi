using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace DiyetUygulamasi
{
    public abstract class Cikti
    {
        protected HastaBilgi hastaBilgi;

        public HastaBilgi HastaBilgi
        {
            get { return HastaBilgi; }
        }

        public abstract void KisiselBilgiCikti(StreamWriter html,JsonWriter json);
        public abstract void DiyetBilgiCikti(StreamWriter html, JsonWriter json);
        public abstract void BilgiCikti();
        public abstract void BilgiCiktiTers();

    }
}
