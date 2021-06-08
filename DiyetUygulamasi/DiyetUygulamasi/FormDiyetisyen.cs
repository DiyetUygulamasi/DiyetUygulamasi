using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DiyetUygulamasi
{
    public partial class FormDiyetisyen : Form
    {
        public FormDiyetisyen(string TC)
        {
            InitializeComponent();
            DiyetisyenTC = TC;
        }
        string DiyetisyenTC;
        SqlCon connection = new SqlCon();
        
        void DGVDoldur()
        {
            SqlCommand dgvDoldur = new SqlCommand
            {
                Connection = connection.SqlConnect(),
                CommandText = "Execute HastaListele " + Convert.ToDouble(DiyetisyenTC)
            };
            SqlDataAdapter adapt = new SqlDataAdapter(dgvDoldur);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dgvHastalar.DataSource = dt;
            connection.SqlConnect().Close();
        }

        private void FormDiyetisyen_Load(object sender, EventArgs e)
        {
            DGVDoldur();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

            if(cmbHastalik.SelectedIndex==0)//Obez Ekleme
            {
                
            }
        }
    }
}
