using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UyeEntityLayer;

namespace UyeDataAccessLayerr
{
    public class UyeDAL
    {

        private string connectionString = "server=MBB-01-BIL065-N\\SQLEXPRESS; Initial Catalog=Uye; Integrated Security=SSPI";

        public UyeDAL(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Ekle(Uyeler uye)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Uyeler (UyeAdi, UyeSoyadi, Email, Telefon, Adres) " +
                               "VALUES (@UyeAdi, @UyeSoyadi, @Email, @Telefon, @Adres)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UyeAdi", uye.Ad);
                command.Parameters.AddWithValue("@UyeSoyadi", uye.Soyad);
                command.Parameters.AddWithValue("@Email", uye.Eposta);
                command.Parameters.AddWithValue("@Telefon", uye.TelNo);
                command.Parameters.AddWithValue("@Adres", uye.Adres);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void Guncelle(Uyeler uye)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Uyeler SET UyeAdi = @UyeAdi, UyeSoyadi = @UyeSoyadi, DogumTarihi = @DogumTarihi, Email = @Email, Telefon = @Telefon, Adres = @Adres WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", uye.ID);
                command.Parameters.AddWithValue("@UyeAdi", uye.Ad);
                command.Parameters.AddWithValue("@UyeSoyadi", uye.Soyad);
                command.Parameters.AddWithValue("@DogumTarihi", uye.DogumTarihi);
                command.Parameters.AddWithValue("@Email", uye.Eposta);
                command.Parameters.AddWithValue("@Telefon", uye.TelNo);
                command.Parameters.AddWithValue("@Adres", uye.Adres);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void Sil(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Uyeler WHERE ID = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public List<Uyeler> TumUyeleriGetir()
        {
            List<Uyeler> uyeListesi = new List<Uyeler>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Uyeler";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Uyeler uye = new Uyeler
                    {
                        ID = Convert.ToInt32(reader["Id"]),
                        Ad = reader["UyeAdi"].ToString(),
                        Soyad = reader["UyeSoyadi"].ToString(),
                        DogumTarihi = DateTime.Parse(reader["DogumTarihi"].ToString()),
                        TCKimlik = reader["TCKimlik"].ToString(),
                        Eposta = reader["Email"].ToString(),
                        TelNo = reader["Telefon"].ToString(),
                        Adres = reader["Adres"].ToString()
                    };
                    uyeListesi.Add(uye);
                }
            }

            return uyeListesi;
        }

        public Uyeler IdIleGetir(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Uyeler WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return new Uyeler
                    {
                        ID = Convert.ToInt32(reader["Id"]),
                        Ad = reader["UyeAdi"].ToString(),
                        Soyad = reader["UyeSoyadi"].ToString(),
                        DogumTarihi = DateTime.Parse(reader["DogumTarihi"].ToString()),
                        TCKimlik = reader["TCKimlik"].ToString(),
                        Eposta = reader["Email"].ToString(),
                        TelNo = reader["Telefon"].ToString(),
                        Adres = reader["Adres"].ToString()
                    };
                }
            }

            return null;
        }
    }
}
