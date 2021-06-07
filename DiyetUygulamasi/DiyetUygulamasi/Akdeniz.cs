using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiyetUygulamasi
{
    class Akdeniz:IDiyet
    {

        public void DiyetOlustur(string menu)
        {
            MessageBox.Show(menu);
        }
    }
}
