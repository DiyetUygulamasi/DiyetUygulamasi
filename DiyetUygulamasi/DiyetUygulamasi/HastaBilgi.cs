using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DiyetUygulamasi
{
    public class HastaBilgi
    {
        SqlCon connection = new SqlCon();
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public double Tc { get; set; }
        public string HastalikAd { get; set; }
        public string DiyetisyenAd { get; set; }
        public string DiyetisyenSoyad { get; set; }
        public string DiyetAd { get; set; }
        public string[] DiyetListe = new string[3];

        void HastaBilgiAl(double hastaTC)
        {
            SqlCommand komut = new SqlCommand
            {
                Connection = connection.SqlConnect(),
                CommandText = "execute HastaBilgiAl "+ hastaTC
            };
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Tc = Convert.ToDouble(dr["HastaTC"].ToString());
                Ad = dr["HastaAd"].ToString();
                Soyad = dr["HastaSoyad"].ToString();
                HastalikAd = dr["HastalikAd"].ToString();
                DiyetisyenAd = dr["DiyetisyenAd"].ToString();
                DiyetisyenSoyad = dr["DiyetisyenSoyad"].ToString();
                DiyetAd = dr["DiyetAd"].ToString();
                DiyetListe[0] = dr["Sabah"].ToString();
                DiyetListe[1] = dr["Ogle"].ToString();
                DiyetListe[2] = dr["Aksam"].ToString();
            }
        }

    }
}
