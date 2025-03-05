using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using EntityLayer;

namespace DataAccessLayer
{
    public class KatRafDAL
    {
        private readonly string connectionString = "server=MBB-01-BIL065-N\\SQLEXPRESS; Initial Catalog=KutuphaneDB; Integrated Security=SSPI";

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

        public bool KategoriGuncelle(int id, string kategoriAdi, string kategoriRafKodu)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE KategoriRaflar SET KategoriAdi = @KategoriAdi, KategoriRafKodu = @KategoriRafKodu WHERE ID = @ID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", id);
                command.Parameters.AddWithValue("@KategoriAdi", kategoriAdi);
                command.Parameters.AddWithValue("@KategoriRafKodu", kategoriRafKodu);

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
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

        public DataTable TumKategoriRaflariGetir()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM KategoriRaflar";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }


        public DataRow KategoriRaflarGetirById(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM KategoriRaflar WHERE ID = @ID";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@ID", id);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                return dataTable.Rows.Count > 0 ? dataTable.Rows[0] : null;
            }
        }

        public DataTable KategoriRaflarAra(string aramaMetni)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM KategoriRaflar WHERE KategoriRafAdi LIKE @AramaMetni OR KategoriRafKodu LIKE @AramaMetni";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@AramaMetni", "%" + aramaMetni + "%");

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }
    }
}
