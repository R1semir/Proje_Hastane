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
using System.Net.Http.Headers;

namespace Proje_Hastane
{
    public partial class FrmDoktorBilgiDuzenle : Form
    {
        public FrmDoktorBilgiDuzenle()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        public string TCNO;
        private void FrmDoktorBilgiDuzenle_Load(object sender, EventArgs e)
        {
            msktc.Text = TCNO;

            SqlCommand komut = new SqlCommand("Select * From Tbl_Doktorlar where DoktorTc=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", msktc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txAd.Text = dr[1].ToString();
                TxSoyad.Text = dr[2].ToString();
                cmbrans.Text = dr[3].ToString();
                txsifre.Text = dr[5].ToString();
            }
            bgl.baglanti().Close();
        }

        private void btnbilgigüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Doktorlar set DoktorAd=@p1,DoktorSoyad=@p2,DoktorBrans=@p3,DoktorSifre=@p4 where DoktorTc=@p5",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txAd.Text);
            komut.Parameters.AddWithValue("@p2", TxSoyad.Text);
            komut.Parameters.AddWithValue("@p3", cmbrans.Text);
            komut.Parameters.AddWithValue("@p4", txsifre.Text);
            komut.Parameters.AddWithValue("@p5", msktc.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Güncellendi");
        }
    }
}
