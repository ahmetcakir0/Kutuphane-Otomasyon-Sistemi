using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class KitapDAL
    {
        private string connectionString = "server=MBB-01-BIL065-N\\SQLEXPRESS; Initial Catalog=KutuphaneDB; Integrated Security=SSPI";


        public void Ekle(Kitap kitap)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
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
                catch (Exception ex)
                {
                    throw new Exception("Kitap eklenirken bir hata oluştu: " + ex.Message);
                }
            }
        }

        public void Guncelle(Kitap kitap)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
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
                catch (Exception ex)
                {
                    throw new Exception("Kitap güncellenirken bir hata oluştu: " + ex.Message);
                }
            }
        }

        public void Sil(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "DELETE FROM Kitaplar WHERE ID = @Id";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Id", id);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Kitap silinirken bir hata oluştu: " + ex.Message);
                }
            }
        }

        public List<Kitap> TumKitaplariGetir()
        {
            List<Kitap> kitapListesi = new List<Kitap>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "SELECT \r\n    k.ID,\r\n    k.KitapAdi,\r\n    y.YazarAdi, \r\n    yv.YayineviAdi, \r\n    t.TurAdi, \r\n    kr.KategoriAdi,\r\n    k.SayfaSayisi,\r\n    k.ISBN,\r\n    k.KitapRafNumarasi\r\nFROM Kitaplar k\r\nLEFT JOIN Yazarlar y ON k.YazarID = y.ID\r\nLEFT JOIN Yayinevi yv ON k.YayineviID = yv.ID\r\nLEFT JOIN Turler t ON k.KitapTuruID = t.ID\r\nLEFT JOIN KategoriRaflar kr ON k.KategoriID = kr.ID;\r\n";
                    SqlCommand command = new SqlCommand(query, connection);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        kitapListesi.Add(new Kitap
                        {
                            ID = Convert.ToInt32(reader["ID"]),
                            KitapAdi = reader["KitapAdi"].ToString(),
                            YazarAdi = reader["YazarID"].ToString(),
                            YayinEvi = Convert.ToInt32(reader["YayineviID"]),
                            ISBN = reader["ISBN"].ToString(),
                            KitapTuru = Convert.ToInt32(reader["KitapTuruID"]),
                            RafNumarasi = Convert.ToInt32(reader["KitapRafKodu"]),
                            //SayfaSayisi = Convert.ToInt32(reader["SayfaSayisi"]),
                            //Kategori = Convert.ToInt32(reader["KategoriID"])
                        });
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Kitaplar getirilirken bir hata oluştu: " + ex.Message);
                }
            }

            return kitapListesi;
        }

        public Kitap IdIleGetir(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "SELECT * FROM Kitaplar WHERE Id = @Id";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Id", id);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        return new Kitap
                        {
                            ID = Convert.ToInt32(reader["Id"]),
                            KitapAdi = reader["KitapAdi"].ToString(),
                            YazarAdi = reader["YazarAdi"].ToString(),
                            YayinEvi = Convert.ToInt32(reader["Yayinevi"]),
                            ISBN = reader["ISBN"].ToString(),
                            KitapTuru = Convert.ToInt32(reader["KitapTuru"]),
                            RafNumarasi = Convert.ToInt32(reader["RafNumarasi"]),
                            SayfaSayisi = Convert.ToInt32(reader["SayfaSayisi"]),
                            Kategori = Convert.ToInt32(reader["Kategori"])
                        };
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Kitap getirilirken bir hata oluştu: " + ex.Message);
                }
            }

            return null;
        }
    }
}
