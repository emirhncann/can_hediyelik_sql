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
        }
       public Urun Urun { get; set; }
        private void btnOk_Click(object sender, EventArgs e)
        {

            if (ErrorControl(txtUrun)) return;
            if (ErrorControl(nmfiyat)) return;
            if (ErrorControl(nmStok)) return;
            if (ErrorControl(txtdetay)) return;

            Urun.Ad = txtUrun.Text;
            Urun.Fiyat = (double)nmfiyat.Value;
            Urun.Stok = (double)nmStok.Value;
            Urun.Ad = txtUrun.Text;
            Urun.Detay = txtdetay.Text;

            DialogResult = DialogResult.OK;


        }
        private bool ErrorControl(Control c)
        {
            if (c is TextBox || c is ComboBox)
            {
                if (txtUrun.Text == "")
                {
                    errorProvider1.SetError(c, "Eksik ya da hatalı giriş yaptınız!");
                    c.Focus();
                    return false;

                }
                else
                {
                    errorProvider1.SetError(c, "");
                    return true;
                }
            }
            if (c is NumericUpDown)
            {
                if (((NumericUpDown)c).Value == 0)
                {
                    errorProvider1.SetError(c, "Eksik ya da hatalı giriş yaptınız!");
                    c.Focus();
                    return false;
                }
                else
                {
                    errorProvider1.SetError(c, "");
                    return true;
                }
            }


            return true;

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

        }
    }
}
