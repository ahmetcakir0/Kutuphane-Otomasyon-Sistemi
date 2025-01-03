using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YayineviDataAccessLayer
{
    public class YayineviDAL
    {
        private string connectionString = "server=MBB-01-BIL065-N\\SQLEXPRESS; Initial Catalog=Uye; Integrated Security=SSPI";

        public YayineviDAL(string connectionString)
        {
            connectionString = connectionString;
        }
        public bool YayineviEkle(string yayineviAdi, string telNo, string eposta, string adres)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Yayinevleri (YayineviAdi, TelNo, Eposta, Adres) VALUES (@YayineviAdi, @TelNo, @Eposta, @Adres)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@YayineviAdi", yayineviAdi);
                command.Parameters.AddWithValue("@TelNo", telNo);
                command.Parameters.AddWithValue("@Eposta", eposta);
                command.Parameters.AddWithValue("@Adres", adres);
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
        public bool YayineviGuncelle(int id, string yayineviAdi, string telNo, string eposta, string adres)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Yayinevleri SET YayineviAdi = @YayineviAdi, TelNo = @TelNo, Eposta = @Eposta, Adres = @Adres WHERE id = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@YayineviAdi", yayineviAdi);
                command.Parameters.AddWithValue("@TelNo", telNo);
                command.Parameters.AddWithValue("@Eposta", eposta);
                command.Parameters.AddWithValue("@Adres", adres);
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
        public bool YayineviSil(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Yayinevleri WHERE id = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
        public List<(int id, string YayineviAdi, string TelNo, string Eposta, string Adres)> YayineviListele()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT id, YayineviAdi, TelNo, Eposta, Adres FROM Yayinevleri";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                List<(int id, string YayineviAdi, string TelNo, string Eposta, string Adres)> yayinevleri = new List<(int, string, string, string, string)>();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    yayinevleri.Add((
                        reader.GetInt32(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                        reader.GetString(4)
                    ));
                }
                return yayinevleri;
            }
        }
    }
}
