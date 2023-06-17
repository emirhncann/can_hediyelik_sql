﻿using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace can_hediyelik.DL
{
    public static class DataLayer
    {
        static MySqlConnection conn = new MySqlConnection(
          new MySqlConnectionStringBuilder()
          {
              Server = "127.0.0.1",
              Database = "can_hediyelik",
              UserID = "root",
              Password = "1414"
          }.ConnectionString
        );
        public static int MüsteriEkle(Musteri m)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)

                    conn.Open();

                MySqlCommand komut = new MySqlCommand("can_MusteriEkle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", m.ID);
                komut.Parameters.AddWithValue("@ad", m.Ad);
                komut.Parameters.AddWithValue("@soy", m.Soyad);
                komut.Parameters.AddWithValue("@tel", m.Telefon);
                komut.Parameters.AddWithValue("@mail", m.Mail);
                komut.Parameters.AddWithValue("@adr", m.Adres);

                int res = komut.ExecuteNonQuery();
                return res;

            }
            catch (Exception ex)
            {
                throw ex;


            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();

            }


        }

        internal static DataSet MusteriGetir(string filtre)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)

                    conn.Open();

                MySqlCommand komut;
                if (string.IsNullOrEmpty(filtre))
                {
                    komut = new MySqlCommand("can_MusterilerHepsi", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;

                }
                else
                {
                    komut = new MySqlCommand("can_MusteriBul", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                    komut.Parameters.AddWithValue("@filtre", filtre);
                }
                DataSet dataSet = new DataSet();
                MySqlDataAdapter adp = new MySqlDataAdapter(komut);
                adp.Fill(dataSet);
                return dataSet;


            }
            catch (Exception ex)
            {
                throw ex;


            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();

            }
        }

        internal static int MusteriGuncelle(Musteri m)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("can_MusteriGuncelle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@p_ID", m.ID);
                komut.Parameters.AddWithValue("@p_Ad", m.Ad);
                komut.Parameters.AddWithValue("@p_Soyad", m.Soyad);
                komut.Parameters.AddWithValue("@p_Telefon", m.Telefon);
                komut.Parameters.AddWithValue("@p_Mail", m.Mail);
                komut.Parameters.AddWithValue("@p_Adres", m.Adres);

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

    }
}