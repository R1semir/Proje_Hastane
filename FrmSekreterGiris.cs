﻿using System;
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
    public partial class FrmSekreterGiris : Form
    {
        public FrmSekreterGiris()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();

        private void btngirisyap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_Sekreter where SekreterTc=@p1 and SekreterSifre=@p2",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", msktc.Text);
            komut.Parameters.AddWithValue("@p2", txsif.Text);
            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {

                FrmSekreterDetay frs = new FrmSekreterDetay();
                frs.Tcnumara = msktc.Text;
                frs.Show();
                this.Hide();
            }
            else 
            {
                MessageBox.Show("Hatalı Tc veya Şifre!");

            }
            bgl.baglanti().Close();
        }

        private void FrmSekreterGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
