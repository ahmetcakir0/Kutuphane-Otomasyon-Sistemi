using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;

namespace DataAccessLayer
{
    public class YayineviDAL
    {
        private string connectionString;

        public YayineviDAL(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Ekle(Yayinevi yayinevi)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Yayinevleri (YayineviAdi, Eposta, Telefon, Adres) " +
                               "VALUES (@YayineviAdi, @Eposta, @Telefon, @Adres)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@YayineviAdi", yayinevi.YayineviAdi);
                command.Parameters.AddWithValue("@Eposta", yayinevi.Eposta);
                command.Parameters.AddWithValue("@Telefon", yayinevi.TelNo);
                command.Parameters.AddWithValue("@Adres", yayinevi.Adres);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void Guncelle(Yayinevi yayinevi)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Yayinevleri SET YayineviAdi = @YayineviAdi, Eposta = @Eposta, Telefon = @Telefon, Adres = @Adres " +
                               "WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", yayinevi.id);
                command.Parameters.AddWithValue("@YayineviAdi", yayinevi.YayineviAdi);
                command.Parameters.AddWithValue("@Eposta", yayinevi.Eposta);
                command.Parameters.AddWithValue("@Telefon", yayinevi.TelNo);
                command.Parameters.AddWithValue("@Adres", yayinevi.Adres);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void Sil(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Yayinevleri WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public List<Yayinevi> TumYayinevleriniGetir()
        {
            List<Yayinevi> yayinevleri = new List<Yayinevi>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Yayinevleri";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Yayinevi yayinevi = new Yayinevi
                    {
                        id = Convert.ToInt32(reader["Id"]),
                        YayineviAdi = reader["YayineviAdi"].ToString(),
                        Eposta = reader["Eposta"].ToString(),
                        TelNo = reader["Telefon"].ToString(),
                        Adres = reader["Adres"].ToString()
                    };
                    yayinevleri.Add(yayinevi);
                }
            }

            return yayinevleri;
        }

        public Yayinevi IdIleGetir(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Yayinevleri WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return new Yayinevi
                    {
                        id = Convert.ToInt32(reader["Id"]),
                        YayineviAdi = reader["YayineviAdi"].ToString(),
                        Eposta = reader["Eposta"].ToString(),
                        TelNo = reader["Telefon"].ToString(),
                        Adres = reader["Adres"].ToString()
                    };
                }
            }

            return null;
        }
    }
}
