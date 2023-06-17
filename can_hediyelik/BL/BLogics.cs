using can_hediyelik.DL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace can_hediyelik.BL
{
    public static class BLogics
    {
        public static bool MusteriEkle(Musteri m)
        {
            try
            {
                int res = DataLayer.MüsteriEkle(m);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu " + ex.Message);
                return false;

            }
        }

        internal static DataSet MusteriGetir(string filtre)
        {
            try
            {
                DataSet ds = DataLayer.MusteriGetir(filtre);
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu " + ex.Message);
                return null;

            }
        }

        internal static bool MusteriGuncelle(Musteri m)
        {
            try
            {
                int res = DataLayer.MusteriGuncelle(m);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu " + ex.Message);
                return false;

            }
        }
    }
}