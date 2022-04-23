using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Hastane
{
    public partial class frmgirisler : Form
    {
        public frmgirisler()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void BtnHastaGirişi_Click(object sender, EventArgs e)
        {
             FrmHastaGirişi fr = new FrmHastaGirişi();
            fr.Show();
            this.Hide();
        }

        private void BtnDoktorGirişi_Click(object sender, EventArgs e)
        {
            FrmDoktorGiris   fr = new  FrmDoktorGiris();
            fr.Show();
            this.Hide();
        }

        private void BtnSekreterGirişi_Click(object sender, EventArgs e)
        {
            FrmSekreterGiris fr = new FrmSekreterGiris();
            fr.Show();
            this.Hide();
        }

        private void frmgirisler_Load(object sender, EventArgs e)
        {

        }
    }
}
