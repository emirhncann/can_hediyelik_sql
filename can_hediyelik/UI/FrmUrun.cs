using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace can_hediyelik.UI
{
    public partial class FrmUrun : Form
    {
        public FrmUrun()
        {
            InitializeComponent();
            Urun = new Urun();
        }
        public Urun Urun { get; set; }
        private void btnOk1_Click(object sender, EventArgs e)
        {

        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btgonder_Click(object sender, EventArgs e)
        {


            Urun.ID = txtUrunID.Text;
            Urun.Ad = txtUrun.Text;
            Urun.Fiyat = (double)nmfiyat.Value;
            Urun.Stok = (double)nmStok.Value;
            Urun.Ad = txtUrun.Text;
            Urun.Detay = txtdetay.Text;

            DialogResult = DialogResult.OK;



        }
    }
}
