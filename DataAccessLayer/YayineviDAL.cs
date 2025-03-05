using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using EntityLayer;

namespace DataAccessLayer
{
    public class YayineviDAL
    {
        private readonly string connectionString = "server=MBB-01-BIL065-N\\SQLEXPRESS; Initial Catalog=KutuphaneDB; Integrated Security=SSPI";

        public YayineviDAL() { }

        // Yayinevi Ekleme
        public bool YayineviEkle(Yayinevi yayinevi)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Yayinevi (YayineviAdi, TelNo, Eposta, Adres) VALUES (@YayineviAdi, @TelNo, @Eposta, @Adres)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@YayineviAdi", yayinevi.YayineviAdi);
                command.Parameters.AddWithValue("@TelNo", yayinevi.TelNo);
                command.Parameters.AddWithValue("@Eposta", yayinevi.Eposta);
                command.Parameters.AddWithValue("@Adres", yayinevi.Adres);

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }

        // Yayinevi Güncelleme
        public bool YayineviGuncelle(Yayinevi yayinevi)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Yayinevi SET YayineviAdi = @YayineviAdi, TelNo = @TelNo, Eposta = @Eposta, Adres = @Adres WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", yayinevi.id);
                command.Parameters.AddWithValue("@YayineviAdi", yayinevi.YayineviAdi);
                command.Parameters.AddWithValue("@TelNo", yayinevi.TelNo);
                command.Parameters.AddWithValue("@Eposta", yayinevi.Eposta);
                command.Parameters.AddWithValue("@Adres", yayinevi.Adres);

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }

        // Yayinevi Silme
        public bool YayineviSil(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Yayinevi WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }

        // Tüm Yayinevlerini Getir
        public List<Yayinevi> TumYayinevleriniGetir()
        {
            List<Yayinevi> yayinevleri = new List<Yayinevi>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Yayinevi";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows)
                {
                    Yayinevi yayinevi = new Yayinevi
                    {
                        id = Convert.ToInt32(row["Id"]),
                        YayineviAdi = row["YayineviAdi"].ToString(),
                        TelNo = row["TelNo"].ToString(),
                        Eposta = row["Eposta"].ToString(),
                        Adres = row["Adres"].ToString()
                    };
                    yayinevleri.Add(yayinevi);
                }
            }

            return yayinevleri;
        }

        // Yayinevi ID ile Getir
        public Yayinevi YayineviGetirById(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Yayinevi WHERE Id = @Id";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@Id", id);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    DataRow row = dataTable.Rows[0];
                    return new Yayinevi
                    {
                        id = Convert.ToInt32(row["Id"]),
                        YayineviAdi = row["YayineviAdi"].ToString(),
                        TelNo = row["TelNo"].ToString(),
                        Eposta = row["Eposta"].ToString(),
                        Adres = row["Adres"].ToString()
                    };
                }

                return null;
            }
        }

        // Yayinevi Ara
        public List<Yayinevi> YayineviAra(string aramaMetni)
        {
            List<Yayinevi> yayinevleri = new List<Yayinevi>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Yayinevi WHERE YayineviAdi LIKE @AramaMetni";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@AramaMetni", "%" + aramaMetni + "%");

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows)
                {
                    Yayinevi yayinevi = new Yayinevi
                    {
                        id = Convert.ToInt32(row["Id"]),
                        YayineviAdi = row["YayineviAdi"].ToString(),
                        TelNo = row["TelNo"].ToString(),
                        Eposta = row["Eposta"].ToString(),
                        Adres = row["Adres"].ToString()
                    };
                    yayinevleri.Add(yayinevi);
                }
            }

            return yayinevleri;
        }
    }
}
