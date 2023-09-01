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
    public partial class FrmBrans : Form
    {
        public FrmBrans()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        private void FrmBrans_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Branslar ", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komutekle = new SqlCommand("insert into Tbl_Branslar(BransAd) values (@b1)",bgl.baglanti());
            komutekle.Parameters.AddWithValue("@b1", txbrans.Text);
            komutekle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txbrans.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //bransid = brasid
            SqlCommand komutsil = new SqlCommand("delete From Tbl_Branslar where Brasid=@b1",bgl.baglanti());
            komutsil.Parameters.AddWithValue("@b1", txid.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Silindi");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand komutguncelle = new SqlCommand("update Tbl_Branslar set BransAd=@p1 where Brasid=@p2",bgl.baglanti());
            komutguncelle.Parameters.AddWithValue("@p1", txbrans.Text);
            komutguncelle.Parameters.AddWithValue("@p2", txid.Text);
            komutguncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Güncellendi");

        }
    }
}
