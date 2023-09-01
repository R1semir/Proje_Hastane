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
namespace Proje_Hastane
{
    public partial class FrmDoktorPaneli : Form
    {
        public FrmDoktorPaneli()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        private void FrmDoktorPaneli_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * From Tbl_Doktorlar", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;

            // Brans comboxa aktarma
            SqlCommand komut2 = new SqlCommand("Select BransAd From Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbrans.Items.Add(dr2[0]);

            }
            bgl.baglanti().Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komutdoktorekle = new SqlCommand("insert into Tbl_Doktorlar (DoktorAd,DoktorSoyad,DoktorBrans,DoktorTc,DoktorSifre) values (@d1,@d2,@d3,@d4,@d5)", bgl.baglanti());
            komutdoktorekle.Parameters.AddWithValue("@d1", txad.Text);
            komutdoktorekle.Parameters.AddWithValue("@d2", txsoyad.Text);
            komutdoktorekle.Parameters.AddWithValue("@d3", cmbrans.Text);
            komutdoktorekle.Parameters.AddWithValue("@d4", msktc.Text);
            komutdoktorekle.Parameters.AddWithValue("@d5", txsif.Text);
            komutdoktorekle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor Eklendi ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txsoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbrans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            msktc.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txsif.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("Delete from Tbl_Doktorlar where DoktorTc=@p1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@p1", msktc.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand komutguncelle = new SqlCommand("Update Tbl_Doktorlar set DoktorAd=@d1,DoktorSoyad=@d2,DoktorBrans=@d3,DoktorSifre=@d5 where DoktorTc=@d4", bgl.baglanti());
            komutguncelle.Parameters.AddWithValue("@d1", txad.Text);
            komutguncelle.Parameters.AddWithValue("@d2", txsoyad.Text);
            komutguncelle.Parameters.AddWithValue("@d3", cmbrans.Text);
            komutguncelle.Parameters.AddWithValue("@d4", msktc.Text);
            komutguncelle.Parameters.AddWithValue("@d5", txsif.Text);
            komutguncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor Güncellendi ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
