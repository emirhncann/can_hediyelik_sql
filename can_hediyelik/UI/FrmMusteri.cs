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
    public partial class FrmMusteri : Form
    {
        public Musteri Musteri { get; set; } = new Musteri();
        public bool Guncelleme { get; set; }


        public FrmMusteri()
        {
            Musteri = new Musteri();
            InitializeComponent();
        }

        private void FrmMusteri_Load_1(object sender, EventArgs e)
        {
            if (Guncelleme)
            {
                txtID.Text = Musteri.ID;
                txtAd.Text = Musteri.Ad;
                txtSoyad.Text = Musteri.Soyad;
                txtTel.Text = Musteri.Telefon;
                txtMail.Text = Musteri.Mail;
                txtAdres.Text = Musteri.Adres;
            }
        }

        private void btnOk_Click_1(object sender, EventArgs e)
        {
            if (!ErrorControl(txtAd)) return;
            if (!ErrorControl(txtSoyad)) return;
            if (!ErrorControl(txtTel)) return;
            if (!ErrorControl(txtMail)) return;
            if (!ErrorControl(txtAdres)) return;
            if (!ErrorControl(txtID)) return;

            Musteri.ID = txtID.Text;
            Musteri.Ad = txtAd.Text;
            Musteri.Soyad = txtSoyad.Text;
            Musteri.Telefon = txtTel.Text;
            Musteri.Mail = txtMail.Text;
            Musteri.Adres = txtAdres.Text;

            DialogResult = DialogResult.OK;
        }


        private bool ErrorControl(Control c)
        {
            if (c is TextBox)
            {
                if (txtAd.Text == "")
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
            if (c is MaskedTextBox)
            {
                if (!((MaskedTextBox)c).MaskFull)
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

        private void txtTel_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }

        private void txtAdres_TextChanged(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void txtMail_TextChanged(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void txtSoyad_TextChanged(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

       
    }
}