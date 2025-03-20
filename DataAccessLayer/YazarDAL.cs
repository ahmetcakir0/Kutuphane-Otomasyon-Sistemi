using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using EntityLayer;

namespace DataAccessLayer
{
    public class YazarDAL
    {
        private readonly string connectionString = "server=MBB-01-BIL065-N\\SQLEXPRESS; Initial Catalog=KutuphaneDB; Integrated Security=SSPI";

        public YazarDAL()
        {
            //this.connectionString = connectionString;
        }

        // Yazar ekleme işlemi
        public bool YazarEkle(Yazar yazar)
        {
            // Geçersiz girişleri kontrol et
            if (string.IsNullOrWhiteSpace(yazar.AdiSoyadi) || yazar.AdiSoyadi.Length > 150)
                throw new ArgumentException("Yazar adı boş olamaz ve 150 karakterden uzun olamaz.");

            if (string.IsNullOrWhiteSpace(yazar.Iletisim) || yazar.Iletisim.Length > 100)
                throw new ArgumentException("İletişim bilgisi boş olamaz ve 100 karakterden uzun olamaz.");

            if (string.IsNullOrWhiteSpace(yazar.Biyografi) || yazar.Biyografi.Length > 1000)
                throw new ArgumentException("Biyografi boş olamaz ve 1000 karakterden uzun olamaz.");

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand("INSERT INTO Yazarlar (AdiSoyadi, Iletisim, DogumTarihi, Biyografi) VALUES (@AdiSoyadi, @Iletisim, @DogumTarihi, @Biyografi)", connection))
                {
                    command.Parameters.Add("@AdiSoyadi", SqlDbType.NVarChar, 150).Value = yazar.AdiSoyadi;
                    command.Parameters.Add("@Iletisim", SqlDbType.NVarChar, 100).Value = yazar.Iletisim;
                    command.Parameters.Add("@DogumTarihi", SqlDbType.Date).Value = yazar.DogumTarihi;
                    command.Parameters.Add("@Biyografi", SqlDbType.NVarChar, 1000).Value = yazar.Biyografi;

                    connection.Open();
                    return command.ExecuteNonQuery() > 0;
                }
            }
            catch (SqlException ex)
            {
                // Hata loglaması yapılabilir
                Console.WriteLine($"SQL Hatası: {ex.Message}");
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Beklenmeyen Hata: {ex.Message}");
                return false;
            }
        }


        // Yazar güncelleme işlemi
        public bool YazarGuncelle(int id, Yazar yazar)
        {
            // Geçersiz girişleri kontrol et
            if (string.IsNullOrWhiteSpace(yazar.AdiSoyadi) || yazar.AdiSoyadi.Length > 150)
                throw new ArgumentException("Yazar adı boş olamaz ve 150 karakterden uzun olamaz.");

            if (string.IsNullOrWhiteSpace(yazar.Iletisim) || yazar.Iletisim.Length > 100)
                throw new ArgumentException("İletişim bilgisi boş olamaz ve 100 karakterden uzun olamaz.");

            if (string.IsNullOrWhiteSpace(yazar.Biyografi) || yazar.Biyografi.Length > 1000)
                throw new ArgumentException("Biyografi boş olamaz ve 1000 karakterden uzun olamaz.");

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand("UPDATE Yazarlar SET AdiSoyadi = @AdiSoyadi, Iletisim = @Iletisim, DogumTarihi = @DogumTarihi, Biyografi = @Biyografi WHERE Id = @Id", connection))
                {
                    command.Parameters.Add("@Id", SqlDbType.Int).Value = id;
                    command.Parameters.Add("@AdiSoyadi", SqlDbType.NVarChar, 150).Value = yazar.AdiSoyadi;
                    command.Parameters.Add("@Iletisim", SqlDbType.NVarChar, 100).Value = yazar.Iletisim;
                    command.Parameters.Add("@DogumTarihi", SqlDbType.Date).Value = yazar.DogumTarihi;
                    command.Parameters.Add("@Biyografi", SqlDbType.NVarChar, 1000).Value = yazar.Biyografi;

                    connection.Open();
                    return command.ExecuteNonQuery() > 0;
                }
            }
            catch (SqlException ex)
            {
                // Hata loglaması yapılabilir
                Console.WriteLine($"SQL Hatası: {ex.Message}");
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Beklenmeyen Hata: {ex.Message}");
                return false;
            }
        }


        public DataTable TumYazarlariGetir()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Yazarlar";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }
        public DataRow YazarGetirById(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Yazarlar WHERE ID = @ID";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@ID", id);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                return dataTable.Rows.Count > 0 ? dataTable.Rows[0] : null;
            }
        }

        public DataTable YazarAra(string aramaMetni)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Yazarlar WHERE TurAdi LIKE @AramaMetni OR AdiSoyadi LIKE @AramaMetni";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@AramaMetni", "%" + aramaMetni + "%");

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        public bool IletisimVarMi(string iletisim)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "SELECT COUNT(*) FROM Yazarlar WHERE Iletisim = @Iletisim";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Iletisim", iletisim);

                    connection.Open();
                    int count = Convert.ToInt32(command.ExecuteScalar());

                    // Eğer iletişim bilgisi varsa
                    return count > 0;
                }
                catch (Exception ex)
                {
                    throw new Exception("Veritabanı hatası: " + ex.Message); // Veritabanı hatası durumu
                }
            }
        }
    }
}
