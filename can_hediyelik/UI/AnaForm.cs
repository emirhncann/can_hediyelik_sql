using can_hediyelik.BL;
using can_hediyelik.UI;
using System;
using System.Data;
using System.Windows.Forms;

namespace can_hediyelik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Musteri Musteri { get; set; } = new Musteri();




        private void Form1_Load(object sender, EventArgs e)
        {


        }



        private void btnMusteriler_ButtonClick(object sender, EventArgs e)
        {
            new Müþteriler().ShowDialog();
        }

        private void toolStripSplitButton3_ButtonClick(object sender, EventArgs e)
        {
            new Urunler().ShowDialog();
        }

        private void toolStripSplitButton4_ButtonClick(object sender, EventArgs e)
        {
            FrmSatis frm = new FrmSatis()
            {
                Text = "Satýþ",
                Satis = new Satis()
                {
                    ID = Guid.NewGuid(),

                }

            };

            if(frm.ShowDialog() == DialogResult.OK)
            {
                var sonuc = frm.ShowDialog();
                if (sonuc == DialogResult.OK)
                {
                    bool b = BLogics.SatisEkle(frm.Satis);
/*
                    if (b)
                    {
                        DataSet ds = BLogics.MusteriGetir("");
                        if (ds != null && ds.Tables.Count > 0)
                            dataGridView2.DataSource = ds.Tables[0];
                    }
                    else
                    {

                    }
  */              }
            }

        }
    }
}