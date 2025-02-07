using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using EntityLayer;

namespace DataAccessLayer
{
    public class KatRafDAL
    {
        private readonly string connectionString = "server=MBB-01-BIL065-N\\SQLEXPRESS; Initial Catalog=KategoriRaflar; Integrated Security=SSPI";

        public bool KategoriEkle(string kategoriAdi, int kategoriRafKodu)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO KategoriRaflar (KategoriAdi, KategoriRafKodu) VALUES (@KategoriAdi, @KategoriRafKodu)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@KategoriAdi", kategoriAdi);
                    cmd.Parameters.AddWithValue("@KategoriRafKodu", kategoriRafKodu);

                    conn.Open();
                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
        }

        public bool KategoriSil(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM KategoriRaflar WHERE ID = @ID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", id);

                    conn.Open();
                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
        }

        public bool KategoriGuncelle(int id, string kategoriAdi, int kategoriRafKodu)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE KategoriRaflar SET KategoriAdi = @KategoriAdi, KategoriRafKodu = @KategoriRafKodu WHERE ID = @ID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.Parameters.AddWithValue("@KategoriAdi", kategoriAdi);
                    cmd.Parameters.AddWithValue("@KategoriRafKodu", kategoriRafKodu);

                    conn.Open();
                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
        }

        public List<(int ID, string KategoriAdi, int KategoriRafKodu)> KategorileriGetir()
        {
            List<(int, string, int)> kategoriler = new List<(int, string, int)>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT ID, KategoriAdi, KategoriRafKodu FROM KategoriRaflar";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string kategoriAdi = reader.GetString(1);
                            int kategoriRafKodu = reader.GetInt32(2);

                            kategoriler.Add((id, kategoriAdi, kategoriRafKodu));
                        }
                    }
                }
            }
            return kategoriler;
        }

        public DataTable KategorileriGetirDataTable()
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT ID, KategoriAdi, KategoriRafKodu FROM KategoriRaflar";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }
    }
}
