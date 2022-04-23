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
    public partial class FrmHastaGirişi : Form
    {
        public FrmHastaGirişi()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void LnkUyeOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHastaKayıt fr = new FrmHastaKayıt();
            fr.Show();
            
        }

        private void BtnGirişYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from Tbl_Hastalar where hastatc=@p1 and hastaşifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskTC.Text);
            komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if(dr.Read())
            {
                FrmHastaDetay fr = new FrmHastaDetay();
                //tc değişkeni normalde hasta detay formunda public olduğu için taşıyabiliyorum
                fr.tc = MskTC.Text;
                //bu formadaki tckimlik numarasını hasta detay formundaki değişkene atadım
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı TC & Şifre ");
            }
            bgl.baglanti().Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
