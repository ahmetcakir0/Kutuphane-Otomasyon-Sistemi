using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;

namespace DataAccessLayer
{
    public class SorumluDAL
    {
        private readonly string connectionString = "server=MBB-01-BIL065-N\\SQLEXPRESS; Initial Catalog=KutuphaneDB; Integrated Security=SSPI";
        public string SorumluEkle(Sorumlu sorumlu)
        {
            // Parametreleri kontrol et
            if (string.IsNullOrWhiteSpace(sorumlu.SorumluAdi))
                return "Sorumlu adı boş olamaz.";

            if (string.IsNullOrWhiteSpace(sorumlu.SorumluSoyadi))
                return "Sorumlu soyadı boş olamaz.";

            if (string.IsNullOrWhiteSpace(sorumlu.TCKimlik))
                return "TC Kimlik numarası boş bırakılamaz.";

            if (string.IsNullOrWhiteSpace(sorumlu.Rol))
                return "Rol boş bırakılamaz.";

            if (string.IsNullOrWhiteSpace(sorumlu.TelNo))
                return "Telefon numarası boş bırakılamaz.";

            if (string.IsNullOrWhiteSpace(sorumlu.Eposta))
                return "Eposta boş bırakılamaz.";

            if (string.IsNullOrWhiteSpace(sorumlu.Adres))
                return "Adres boş bırakılamaz.";

            if (string.IsNullOrWhiteSpace(sorumlu.KullaniciAdi))
                return "Kullanıcı adı boş bırakılamaz.";

            if (string.IsNullOrWhiteSpace(sorumlu.Sifre))
                return "Şifre boş bırakılamaz.";

            try
            {
                // Veritabanına kaydetme işlemi
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Sorumlular (sorumluAdi, sorumluSoyadi, tcKimlik, rol, telNo, ePosta, dogumTarihi, adres, kullaniciAdi, sifre) " +
                                   "VALUES (@sorumluAdi, @sorumluSoyadi, @tcKimlik, @rol, @telNo, @ePosta, @dogumTarihi, @adres, @kullaniciAdi, @sifre)";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@sorumluAdi", sorumlu.SorumluAdi);
                    command.Parameters.AddWithValue("@sorumluSoyadi", sorumlu.SorumluSoyadi);
                    command.Parameters.AddWithValue("@tcKimlik", sorumlu.TCKimlik);
                    command.Parameters.AddWithValue("@rol", sorumlu.Rol);
                    command.Parameters.AddWithValue("@telNo", sorumlu.TelNo);
                    command.Parameters.AddWithValue("@ePosta", sorumlu.Eposta);
                    command.Parameters.AddWithValue("@dogumTarihi", sorumlu.DogumTarihi);
                    command.Parameters.AddWithValue("@adres", sorumlu.Adres);
                    command.Parameters.AddWithValue("@kullaniciAdi", sorumlu.KullaniciAdi);
                    command.Parameters.AddWithValue("@sifre", sorumlu.Sifre);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0 ? "Sorumlu başarıyla eklendi." : "Sorumlu eklenemedi.";
                }
            }
            catch (Exception ex)
            {
                return $"Hata: {ex.Message}";
            }
        }



        public string SorumluGuncelle(Sorumlu sorumlu)
        {
            // Parametreleri kontrol et
            if (sorumlu.ID <= 0)
                return "Geçersiz sorumlu ID.";

            if (string.IsNullOrWhiteSpace(sorumlu.SorumluAdi))
                return "Sorumlu adı boş olamaz.";

            if (string.IsNullOrWhiteSpace(sorumlu.SorumluSoyadi))
                return "Sorumlu soyadı boş olamaz.";

            if (string.IsNullOrWhiteSpace(sorumlu.TCKimlik))
                return "TC Kimlik numarası boş bırakılamaz.";

            if (string.IsNullOrWhiteSpace(sorumlu.Rol))
                return "Rol boş bırakılamaz.";

            if (string.IsNullOrWhiteSpace(sorumlu.TelNo))
                return "Telefon numarası boş bırakılamaz.";

            if (string.IsNullOrWhiteSpace(sorumlu.Eposta))
                return "Eposta boş bırakılamaz.";

            if (string.IsNullOrWhiteSpace(sorumlu.Adres))
                return "Adres boş bırakılamaz.";

            if (string.IsNullOrWhiteSpace(sorumlu.KullaniciAdi))
                return "Kullanıcı adı boş bırakılamaz.";

            if (string.IsNullOrWhiteSpace(sorumlu.Sifre))
                return "Şifre boş bırakılamaz.";

            try
            {
                // Veritabanına güncelleme işlemi
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Sorumlular SET sorumluAdi = @sorumluAdi, sorumluSoyadi = @sorumluSoyadi, tcKimlik = @tcKimlik, " +
                                   "rol = @rol, telNo = @telNo, ePosta = @ePosta, dogumTarihi = @dogumTarihi, adres = @adres, kullaniciAdi = @kullaniciAdi, " +
                                   "sifre = @sifre WHERE Id = @Id";

                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@Id", sorumlu.ID);
                    command.Parameters.AddWithValue("@sorumluAdi", sorumlu.SorumluAdi);
                    command.Parameters.AddWithValue("@sorumluSoyadi", sorumlu.SorumluSoyadi);
                    command.Parameters.AddWithValue("@tcKimlik", sorumlu.TCKimlik);
                    command.Parameters.AddWithValue("@rol", sorumlu.Rol);
                    command.Parameters.AddWithValue("@telNo", sorumlu.TelNo);
                    command.Parameters.AddWithValue("@ePosta", sorumlu.Eposta);
                    command.Parameters.AddWithValue("@dogumTarihi", sorumlu.DogumTarihi);
                    command.Parameters.AddWithValue("@adres", sorumlu.Adres);
                    command.Parameters.AddWithValue("@kullaniciAdi", sorumlu.KullaniciAdi);
                    command.Parameters.AddWithValue("@sifre", sorumlu.Sifre);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0 ? "Sorumlu başarıyla güncellendi." : "Sorumlu güncellenemedi.";
                }
            }
            catch (Exception ex)
            {
                return $"Hata: {ex.Message}";
            }
        }



        public bool SorumluSil(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Sorumlular WHERE Id = @id";  // Doğru SQL sorgusu

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@id", SqlDbType.Int).Value = id;

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
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
                string query = "SELECT COUNT(*) FROM Sorumlular WHERE kullaniciAdi = @kullaniciAdi AND sifre = @sifre";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
                command.Parameters.AddWithValue("@sifre", sifre);

                connection.Open();
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }
        public DataRow SorumluGetirByİd(int id)
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
                string query = "SELECT * FROM Sorumlular WHERE ad LIKE @AramaMetni OR sorumluAdi LIKE @AramaMetni";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@AramaMetni", "%" + aramaMetni + "%");

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }
    }
}