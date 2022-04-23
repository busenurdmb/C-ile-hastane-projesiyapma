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
    public partial class FrmSekreterDetay : Form
    {
        public FrmSekreterDetay()
        {
            InitializeComponent();
        }
        public string tc;
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmSekreterDetay_Load(object sender, EventArgs e)
        {
            LblTC.Text = tc;
            //adsoyad
            SqlCommand komut = new SqlCommand("select sekreteradsoyad from Tbl_Sekreter where sekretertc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", LblTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblAdSoyad.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();
            //branşlar
            SqlCommand komut2 = new SqlCommand("select branşad from Tbl_Branşlar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                CmbBranş.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
            //branşları datagridewe çekme
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Branşlar", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

          //doktorudatgridwieve aktarma
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select (doktorad+' '+doktorsoyad) as 'Doktorlar' , doktorbranş from Tbl_Doktorlar", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut3 = new SqlCommand("insert into tbl_randevular (RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor) values(@r1,@r2,@r3,@r4)", bgl.baglanti());
            komut3.Parameters.AddWithValue("@r1", MskTarih.Text);
            komut3.Parameters.AddWithValue("@r2", MskSaat.Text);
            komut3.Parameters.AddWithValue("@r3", CmbBranş.Text);
            komut3.Parameters.AddWithValue("@r4", CmbDoktor.Text);
            komut3.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("randevu oluşturuldu");
        }

        private void CmbBranş_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbDoktor.Items.Clear();

            SqlCommand komut = new SqlCommand("select doktorad,doktorsoyad from tbl_Doktorlar where doktorbranş=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", CmbBranş.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                CmbDoktor.Items.Add(dr[0] + "" + dr[1]);
            }
            bgl.baglanti().Close();
        }

        private void BtnOlustur_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Duyurlar (duyuru) values (@d1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", RchDuyuru.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("duyuru oluşturuldu");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDoktorPaneli fr = new FrmDoktorPaneli();
            fr.Show();
        }

     



        private void button2_Click(object sender, EventArgs e)
        {
            FrmBranşPaneli fbr = new FrmBranşPaneli();
            fbr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmRandevuListesi fr = new FrmRandevuListesi();
            fr.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmDuyurular fr = new FrmDuyurular();
            fr.Show();
        }

        private void CmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
