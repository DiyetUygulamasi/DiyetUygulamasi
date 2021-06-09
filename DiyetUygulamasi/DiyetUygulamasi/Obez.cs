using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DiyetUygulamasi
{
    class Obez:Hasta
    {
        public Obez(IDiyet diyet) : base(diyet)
        {
        }
        SqlCon connnection = new SqlCon();

        public override void hastaOlustur(Hasta hasta)
        {

            SqlCommand hastaEkle = new SqlCommand
            {
                Connection = connnection.SqlConnect(),
                CommandText="Execute HastaEkle"+hasta.Tc+","+"'"+hasta.Ad+"'"+","+"'"+hasta.Soyad+"'"+","+hasta.Hastalik+","+hasta.DiyetisyenTc
            };
        }
    }
}