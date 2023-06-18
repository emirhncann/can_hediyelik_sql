using can_hediyelik.BL;
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
    public partial class Urunler : Form
    {
        public Urunler()
        {
            InitializeComponent();
        }

        private void Urunler_Load(object sender, EventArgs e)
        {
            DataSet ds2 = BLogics.UrunGetir("");
            if (ds2 != null && ds2.Tables.Count > 0)
                dataGridView2.DataSource = ds2.Tables[0];
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            FrmUrun frm = new FrmUrun
            {
                Text = "Urun ekle",
                Urun = new Urun()
            };

            var sonuc = frm.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogics.UrunEkle(frm.Urun);

                if (b)
                {
                    DataSet ds = BLogics.UrunGetir("");
                    if (ds != null && ds.Tables.Count > 0)
                        dataGridView2.DataSource = ds.Tables[0];
                }
                else
                {

                }
            }
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView2.SelectedRows[0];
            FrmUrun frm = new FrmUrun
            {
                Text = "Urun Güncelle",
                Guncelleme = true,
                Urun = new Urun()
                {


                    ID = row.Cells[0].Value.ToString(),
                    Ad = row.Cells[1].Value.ToString(),
                    Fiyat = Convert.ToDouble(row.Cells[2].Value),
                    Stok = Convert.ToDouble(row.Cells[3].Value),
                    Detay = row.Cells[4].Value.ToString(),

                }
            };
            var sonuc = frm.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogics.UrunGuncelle(frm.Urun);

                if (b)
                {
                    DataSet ds = BLogics.UrunGetir("");
                    if (ds != null && ds.Tables.Count > 0)
                        dataGridView2.DataSource = ds.Tables[0];
                }
                else
                {

                }
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

            DataGridViewRow row = dataGridView2.SelectedRows[0];
            var ID = row.Cells[0].Value.ToString();
            var sonuc = MessageBox.Show("Silmek istediğinize emin misiniz?", "Silmeyi Onayla",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogics.UrunSil(ID);
                if (b)
                {

                    DataSet ds = BLogics.UrunGetir("");
                    if (ds != null && ds.Tables.Count > 0)
                        dataGridView2.DataSource = ds.Tables[0];
                }

            }



            FrmUrun frm = new FrmUrun
            {
                Text = "Urun Güncelle",
                Guncelleme = true,

            };
        }
    }
}
