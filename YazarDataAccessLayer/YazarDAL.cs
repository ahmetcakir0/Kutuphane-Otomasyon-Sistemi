using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazarDataAccessLayer
{
    public class YazarDAL
    {
        private string connectionString = "Server=.;Database=YayineviDB;Trusted_Connection=True;";

        public YazarDAL(string connectionString)
        {
            connectionString = connectionString;
        }
        public bool YazarEkle(string yazarAdiSoyadi, string iletisim, string biyografi)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Yazarlar (YazarAdiSoyadi, Iletisim, Biyografi) VALUES (@YazarAdiSoyadi, @Iletisim, @Biyografi)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@YazarAdiSoyadi", yazarAdiSoyadi);
                command.Parameters.AddWithValue("@Iletisim", iletisim);
                command.Parameters.AddWithValue("@Biyografi", biyografi);

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
        public bool YazarGuncelle(int id, string yazarAdiSoyadi, string iletisim, string biyografi)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Yazarlar SET YazarAdiSoyadi = @YazarAdiSoyadi, Iletisim = @Iletisim, Biyografi = @Biyografi WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@YazarAdiSoyadi", yazarAdiSoyadi);
                command.Parameters.AddWithValue("@Iletisim", iletisim);
                command.Parameters.AddWithValue("@Biyografi", biyografi);

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
        public bool YazarSil(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Yazarlar WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
        public List<(int Id, string YazarAdiSoyadi, string Iletisim, string Biyografi)> YazarListele()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Id, YazarAdiSoyadi, Iletisim, Biyografi FROM Yazarlar";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                List<(int Id, string YazarAdiSoyadi, string Iletisim, string Biyografi)> yazarlar = new List<(int, string, string, string)>();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    yazarlar.Add((
                        reader.GetInt32(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3)
                    ));
                }

                return yazarlar;
            }
        }
    }
}
