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


        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            FrmMusteri frmMusteri = new FrmMusteri
            {
                Text = "Musteri ekle",
                Musteri = new Musteri()
            };

            var sonuc = frmMusteri.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogics.MusteriEkle(frmMusteri.Musteri);

                if (b)
                {
                    DataSet ds = BLogics.MusteriGetir("");
                    if (ds != null && ds.Tables.Count > 0)
                        dataGridView1.DataSource = ds.Tables[0];
                }
                else
                {

                }
            }
        }

        private void btnMusteriDuzenle_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            FrmMusteri frmMusteri = new FrmMusteri
            {
                Text = "Musteri Güncelle",
                Guncelleme = true,
                Musteri = new Musteri()
                {
                    ID = row.Cells[0].Value.ToString(),

                    Ad = row.Cells[1].Value.ToString(),
                    Soyad = row.Cells[2].Value.ToString(),
                    Telefon = row.Cells[3].Value.ToString(),
                    Mail = row.Cells[4].Value.ToString(),
                    Adres = row.Cells[5].Value.ToString(),
                }
            };
            var sonuc = frmMusteri.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogics.MusteriGuncelle(frmMusteri.Musteri);

                if (b)
                {
                    DataSet ds = BLogics.MusteriGetir("");
                    if (ds != null && ds.Tables.Count > 0)
                        dataGridView1.DataSource = ds.Tables[0];
                }
                else
                {

                }
            }
        }

        private void btnMusteriBul_Click(object sender, EventArgs e)
        {
            DataSet ds = BLogics.MusteriGetir("");
            if (ds != null && ds.Tables.Count > 0)
                dataGridView1.DataSource = ds.Tables[0];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet ds = BLogics.MusteriGetir("");
            if (ds != null && ds.Tables.Count > 0)
                dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnMusteriSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            var ID = row.Cells[0].Value.ToString();
            var sonuc = MessageBox.Show("Silmek istediðinize emin misiniz?", "Silmeyi Onayla",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogics.MusteriSil(ID);
                if (b)
                {

                    DataSet ds = BLogics.MusteriGetir("");
                    if (ds != null && ds.Tables.Count > 0)
                        dataGridView1.DataSource = ds.Tables[0];
                }

            }



            FrmMusteri frmMusteri = new FrmMusteri
            {
                Text = "Musteri Güncelle",
                Guncelleme = true,

            };
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            FrmUrun frm = new FrmUrun
            {
                Text = "Musteri ekle",
                Urun = new Urun()
            };

            var sonuc = frm.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogics.UrunEkle(frm.Urun);

                if (b)
                {
                    DataSet ds = BLogics.UrunleriGetir("");
                    if (ds != null && ds.Tables.Count > 0)
                        dataGridView1.DataSource = ds.Tables[0];
                }
                else
                {

                }
            }
        }
    }
}