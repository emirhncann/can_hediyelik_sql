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
            urun = new Urun();
        }
        public Urun urun = new Urun();  
        
        public bool Guncelleme { get; internal set; } = false;  

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


            urun.ID = txtUrunID.Text;
            urun.Ad = txtUrun.Text;
            urun.Fiyat = (double)nmfiyat.Value;
            urun.Stok = (double)nmStok.Value;
            urun.Ad = txtUrun.Text;
            urun.Detay = txtdetay.Text;

            DialogResult = DialogResult.OK;



        }

        private void FrmUrun_Load(object sender, EventArgs e)
        {
            
            if (Guncelleme)
            {
                txtUrunID.Text = urun.ID;
                txtUrun.Text = urun.Ad.ToString();
                nmfiyat.Value = (decimal)urun.Fiyat;
                txtdetay.Text = urun.Detay;
                nmStok.Value = (decimal)urun.Stok;

            }
        }
    }
}
