using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;

namespace DataAccessLayer
{
    public class UyeDAL
    {
        private readonly string connectionString = "server=MBB-01-BIL065-N\\SQLEXPRESS; Initial Catalog=KutuphaneDB; Integrated Security=SSPI";

        public UyeDAL()
        {
          
        }

        public bool UyeEkle(Uye uye)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Uyeler (ad, soyad, tcKimlik, telNo, ePosta, dogumTarihi, adres) VALUES (@ad, @soyad, @tcKimlik, @telNo, @ePosta, @dogumTarihi, @adres)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ad", uye.Ad);
                        command.Parameters.AddWithValue("@soyad", uye.Soyad);
                        command.Parameters.AddWithValue("@tcKimlik", uye.TCKimlik);
                        command.Parameters.AddWithValue("@telNo", uye.TelNo);
                        command.Parameters.AddWithValue("@ePosta", uye.Eposta);
                        command.Parameters.AddWithValue("@dogumTarihi", uye.DogumTarihi);
                        command.Parameters.AddWithValue("@adres", uye.Adres);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: " + ex.Message);
                return false;
            }
        }


        public bool UyeGuncelle(Uye uye)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Uyeler SET ad = @ad, soyad = @soyad, tcKimlik = @tcKimlik, telNo = @telNo, ePosta = @ePosta, dogumTarihi = @dogumTarihi, adres = @adres WHERE Id = @Id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", uye.ID);
                        command.Parameters.AddWithValue("@ad", uye.Ad);
                        command.Parameters.AddWithValue("@soyad", uye.Soyad);
                        command.Parameters.AddWithValue("@tcKimlik", uye.TCKimlik);
                        command.Parameters.AddWithValue("@telNo", uye.TelNo);
                        command.Parameters.AddWithValue("@ePosta", uye.Eposta);
                        command.Parameters.AddWithValue("@dogumTarihi", uye.DogumTarihi);
                        command.Parameters.AddWithValue("@adres", uye.Adres);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Hata yönetimi: loglama veya hata mesajı döndürme
                Console.WriteLine("Hata: " + ex.Message);
                return false;
            }
        }

        public bool UyeSil(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Uyeler WHERE Id = @id";  // @Id değil, @id olmalı

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@id", SqlDbType.Int).Value = id;

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        public DataTable TumUyeleriGetir()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Uyeler";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        public DataRow UyeGetirById(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Uyeler WHERE ID = @ID";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@ID", id);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                return dataTable.Rows.Count > 0 ? dataTable.Rows[0] : null;
            }
        }

        public DataTable UyeAra(string aramaMetni)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Uyeler WHERE ad LIKE @AramaMetni OR AdiSoyadi LIKE @AramaMetni";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@AramaMetni", "%" + aramaMetni + "%");

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }
        public bool UyeBilgisiVarMi(string tcKimlik, string telNo, string eposta, int mevcutUyeId = 0)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
            SELECT COUNT(*) FROM Uyeler 
            WHERE (TCKimlik = @TCKimlik OR TelNo = @TelNo OR Eposta = @Eposta)
            AND ID <> @MevcutUyeId";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TCKimlik", tcKimlik);
                    cmd.Parameters.AddWithValue("@TelNo", telNo);
                    cmd.Parameters.AddWithValue("@Eposta", eposta);
                    cmd.Parameters.AddWithValue("@MevcutUyeId", mevcutUyeId);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0; // Eğer kayıt varsa true döner
                }
            }
        }

    }
}
