﻿using System;
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
    public partial class FrmSatis : Form
    {
        public FrmSatis()
        {
            InitializeComponent();
        }

        public Musteri Musteri { get; set; }
        public Urun Urun { get; set; }

        public Satis Satis { get; set; }


        private void btnOk_Click(object sender, EventArgs e)
        {
            if (nmFiyat.Value == 0)
            {
                errorProvider1.SetError(nmFiyat, "Lütfen Fiyat Giriniz");
                nmFiyat.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(nmFiyat, "");
            }
            Satis.Tarih = dtTarih.Value;
            Satis.Fiyat = (double)nmFiyat.Value;

            DialogResult = DialogResult.OK;

        }

        private void FrmSatis_Load(object sender, EventArgs e)
        {
            txtID.Text = Satis.ID.ToString();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Müşteriler frm = new Müşteriler();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                Musteri = frm.Musteri;
                txtMusteri.Text = Musteri.ToString();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Urunler frm = new Urunler();
            if (frm.ShowDialog() == DialogResult.OK)
            {
             // Urun = new Urun();
              txtID.Text = frm.urun.ID.ToString();
            }
        }
    }
}
