using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SorumluDataAccessLayer
{
    public class SorumluDAL
    {
        private string connectionString = "server=MBB-01-BIL065-N\\SQLEXPRESS; Initial Catalog=Sorumlular; Integrated Security=SSPI";

        public SorumluDAL(string connectionString)
        {
            connectionString = connectionString;
        }
        public bool SorumluEkle(string sorumluAdi, string sorumluSoyadi, long tcKimlik, string rol,
            string telNo, string eposta, DateTime dogumTarihi, string adres, string kullaniciAdi, string sifre)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO Sorumlular 
                    (SorumluAdi, SorumluSoyadi, TCKimlik, Rol, TelNo, Eposta, DogumTarihi, Adres, KullaniciAdi, Sifre) 
                    VALUES 
                    (@SorumluAdi, @SorumluSoyadi, @TCKimlik, @Rol, @TelNo, @Eposta, @DogumTarihi, @Adres, @KullaniciAdi, @Sifre)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@SorumluAdi", sorumluAdi);
                command.Parameters.AddWithValue("@SorumluSoyadi", sorumluSoyadi);
                command.Parameters.AddWithValue("@TCKimlik", tcKimlik);
                command.Parameters.AddWithValue("@Rol", rol);
                command.Parameters.AddWithValue("@TelNo", telNo);
                command.Parameters.AddWithValue("@Eposta", eposta);
                command.Parameters.AddWithValue("@DogumTarihi", dogumTarihi);
                command.Parameters.AddWithValue("@Adres", adres);
                command.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);
                command.Parameters.AddWithValue("@Sifre", sifre);

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
        public bool SorumluGuncelle(int id, string sorumluAdi, string sorumluSoyadi, long tcKimlik,
           string rol, string telNo, string eposta, DateTime dogumTarihi, string adres, string kullaniciAdi, string sifre)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"UPDATE Sorumlular SET 
                    SorumluAdi = @SorumluAdi, 
                    SorumluSoyadi = @SorumluSoyadi, 
                    TCKimlik = @TCKimlik, 
                    Rol = @Rol, 
                    TelNo = @TelNo, 
                    Eposta = @Eposta, 
                    DogumTarihi = @DogumTarihi, 
                    Adres = @Adres, 
                    KullaniciAdi = @KullaniciAdi, 
                    Sifre = @Sifre 
                    WHERE ID = @ID";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", id);
                command.Parameters.AddWithValue("@SorumluAdi", sorumluAdi);
                command.Parameters.AddWithValue("@SorumluSoyadi", sorumluSoyadi);
                command.Parameters.AddWithValue("@TCKimlik", tcKimlik);
                command.Parameters.AddWithValue("@Rol", rol);
                command.Parameters.AddWithValue("@TelNo", telNo);
                command.Parameters.AddWithValue("@Eposta", eposta);
                command.Parameters.AddWithValue("@DogumTarihi", dogumTarihi);
                command.Parameters.AddWithValue("@Adres", adres);
                command.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);
                command.Parameters.AddWithValue("@Sifre", sifre);

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
        public bool SorumluSil(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Sorumlular WHERE ID = @ID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", id);

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
        public DataTable TumSorumlulariGetir()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Sorumlular";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }
        public bool GirisYap(string kullaniciAdi, string sifre)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Sorumlular WHERE KullaniciAdi = @KullaniciAdi AND Sifre = @Sifre";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);
                command.Parameters.AddWithValue("@Sifre", sifre);

                connection.Open();
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }
        public DataRow SorumluGetirById(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Sorumlular WHERE ID = @ID";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@ID", id);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                return dataTable.Rows.Count > 0 ? dataTable.Rows[0] : null;
            }
        }
        public DataTable SorumluAra(string aramaMetni)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"SELECT * FROM Sorumlular 
                    WHERE SorumluAdi LIKE @AramaMetni 
                    OR SorumluSoyadi LIKE @AramaMetni 
                    OR TCKimlik LIKE @AramaMetni 
                    OR KullaniciAdi LIKE @AramaMetni";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@AramaMetni", "%" + aramaMetni + "%");

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }
    }
}
