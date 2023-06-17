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
    public partial class FrmOdeme : Form
    {
        public FrmOdeme()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        public Odeme Odeme { get; set; }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (nmTutar.Value == 0)
            {
                errorProvider1.SetError(nmTutar, "Lütfen Tutar Giriniz");
                nmTutar.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(nmTutar, "");
            }
            if (txtAciklama.Text == "")
            {
                errorProvider1.SetError(txtAciklama, "Eksik ya da hatalı bilgi!");
                txtAciklama.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtAciklama, "");
            }

            if (cbOdemeTuru.SelectedItem == null)
            {
                errorProvider1.SetError(cbOdemeTuru, "Ödeme Türü Seçiniz!!");
                cbOdemeTuru.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(cbOdemeTuru, "");
            }

            DialogResult = DialogResult.OK;

            Odeme.Tur = cbOdemeTuru.SelectedItem.ToString();
            Odeme.Tutar = (double)nmTutar.Value;
            Odeme.Aciklama = txtAciklama.Text;
            Odeme.Tarih = dtTarih.Value;


        }
    }
}
