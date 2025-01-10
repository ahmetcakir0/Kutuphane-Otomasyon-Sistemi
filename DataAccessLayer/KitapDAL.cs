using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using EntityLayer;

namespace DataAccessLayer
{
    public class KitapDAL
    {
        private string connectionString = "server=MBB-01-BIL065-N\\SQLEXPRESS; Initial Catalog=Kitaplar; Integrated Security=SSPI";

        public KitapDAL(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Ekle(Kitaplar kitap)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Kitaplar (KitapAdi, YazarAdi, Yayinevi, ISBN, KitapTuru, RafNumarasi, SayfaSayisi, Kategori) " +
                               "VALUES (@KitapAdi, @YazarAdi, @Yayinevi, @ISBN, @KitapTuru, @RafNumarasi, @SayfaSayisi, @Kategori)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@KitapAdi", kitap.KitapAdi);
                command.Parameters.AddWithValue("@YazarAdi", kitap.YazarAdi);
                command.Parameters.AddWithValue("@Yayinevi", kitap.YayinEvi);
                command.Parameters.AddWithValue("@ISBN", kitap.ISBN);
                command.Parameters.AddWithValue("@KitapTuru", kitap.KitapTuru);
                command.Parameters.AddWithValue("@RafNumarasi", kitap.RafNumarasi);
                command.Parameters.AddWithValue("@SayfaSayisi", kitap.SayfaSayisi);
                command.Parameters.AddWithValue("@Kategori", kitap.Kategori);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void Guncelle(Kitaplar kitap)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Kitaplar SET KitapAdi = @KitapAdi, YazarAdi = @YazarAdi, Yayinevi = @Yayinevi, ISBN = @ISBN, " +
                               "KitapTuru = @KitapTuru, RafNumarasi = @RafNumarasi, SayfaSayisi = @SayfaSayisi, Kategori = @Kategori WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", kitap.ID);
                command.Parameters.AddWithValue("@KitapAdi", kitap.KitapAdi);
                command.Parameters.AddWithValue("@YazarAdi", kitap.YazarAdi);
                command.Parameters.AddWithValue("@Yayinevi", kitap.YayinEvi);
                command.Parameters.AddWithValue("@ISBN", kitap.ISBN);
                command.Parameters.AddWithValue("@KitapTuru", kitap.KitapTuru);
                command.Parameters.AddWithValue("@RafNumarasi", kitap.RafNumarasi);
                command.Parameters.AddWithValue("@SayfaSayisi", kitap.SayfaSayisi);
                command.Parameters.AddWithValue("@Kategori", kitap.Kategori);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void Sil(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Kitaplar WHERE ID = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public List<Kitaplar> TumKitaplariGetir()
        {
            List<Kitaplar> kitapListesi = new List<Kitaplar>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Kitaplar";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Kitaplar kitap = new Kitaplar
                    {
                        ID = Convert.ToInt32(reader["Id"]),
                        KitapAdi = reader["KitapAdi"].ToString(),
                        YazarAdi = reader["YazarAdi"].ToString(),
                        YayinEvi = reader["Yayinevi"].ToString(),
                        ISBN = reader["ISBN"].ToString(),
                        KitapTuru = reader["KitapTuru"].ToString(),
                        RafNumarasi = reader["RafNumarasi"].ToString(),
                        SayfaSayisi = Convert.ToInt32(reader["SayfaSayisi"]),
                        Kategori = reader["Kategori"].ToString()
                    };
                    kitapListesi.Add(kitap);
                }
            }

            return kitapListesi;
        }

        public Kitaplar IdIleGetir(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Kitaplar WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return new Kitaplar
                    {
                        ID = Convert.ToInt32(reader["Id"]),
                        KitapAdi = reader["KitapAdi"].ToString(),
                        YazarAdi = reader["YazarAdi"].ToString(),
                        YayinEvi = reader["Yayinevi"].ToString(),
                        ISBN = reader["ISBN"].ToString(),
                        KitapTuru = reader["KitapTuru"].ToString(),
                        RafNumarasi = reader["RafNumarasi"].ToString(),
                        SayfaSayisi = Convert.ToInt32(reader["SayfaSayisi"]),
                        Kategori = reader["Kategori"].ToString()
                    };
                }
            }

            return null;
        }
    }
}

