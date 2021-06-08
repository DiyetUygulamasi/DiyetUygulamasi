using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiyetUygulamasi
{
    class DenizUrunleri:IDiyet
    {
        public void DiyetOlustur(string DiyetIsim)
        {
            MessageBox.Show(DiyetIsim);
        }
    }
}
