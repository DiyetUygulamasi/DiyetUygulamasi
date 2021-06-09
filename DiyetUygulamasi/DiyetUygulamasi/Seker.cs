using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DiyetUygulamasi
{
    class Seker:Hasta
    {
        public Seker(IDiyet diyet) : base(diyet)
        {
            this.diyet = diyet;
        }
        SqlCon connnection = new SqlCon();

        public override void hastaOlustur(Hasta hasta)
        {

            SqlCommand hastaEkle = new SqlCommand
            {
                Connection = connnection.SqlConnect(),
                CommandText = "Execute HastaEkle " + hasta.Tc + "," + "'" + hasta.Ad + "'" + "," + "'" + hasta.Soyad + "'" + "," + hasta.HastalikID + "," + hasta.DiyetisyenTc
            };
            hastaEkle.ExecuteNonQuery();
            connnection.SqlConnect().Close();
        }
    }
}
