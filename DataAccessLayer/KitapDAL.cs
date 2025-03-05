using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class KitapDAL
    {
        private readonly string connectionString = "server=MBB-01-BIL065-N\\SQLEXPRESS; Initial Catalog=KutuphaneDB; Integrated Security=SSPI";

        public bool KitapEkle(Kitap yeniKitap)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = @"INSERT INTO Kitaplar (KitapAdi, YazarID, YayineviID, KitapTuruID, KategoriID, SayfaSayisi, ISBN, KitapRaf) 
                                     VALUES (@KitapAdi, @YazarID, @YayineviID, @KitapTuruID, @KategoriID, @SayfaSayisi, @ISBN, @KitapRaf)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@KitapAdi", yeniKitap.KitapAdi);
                        command.Parameters.AddWithValue("@YazarID", yeniKitap.YazarID);
                        command.Parameters.AddWithValue("@YayineviID", yeniKitap.YayineviID);
                        command.Parameters.AddWithValue("@KitapTuruID", yeniKitap.KitapTuruID);
                        command.Parameters.AddWithValue("@KategoriID", yeniKitap.KategoriID);
                        command.Parameters.AddWithValue("@SayfaSayisi", yeniKitap.SayfaSayisi);
                        command.Parameters.AddWithValue("@ISBN", yeniKitap.ISBN);
                        command.Parameters.AddWithValue("@KitapRaf", yeniKitap.KitapRaf);

                        connection.Open();
                        return command.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Kitap eklenirken hata oluştu: " + ex.Message);
            }
        }

        public bool KitapGuncelle(Kitap kitap)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = @"UPDATE Kitaplar 
                                     SET KitapAdi = @KitapAdi, YazarID = @YazarID, YayineviID = @YayineviID, 
                                         KitapTuruID = @KitapTuruID, KategoriID = @KategoriID, SayfaSayisi = @SayfaSayisi, 
                                         ISBN = @ISBN, KitapRaf = @KitapRaf 
                                     WHERE ID = @KitapID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@KitapAdi", kitap.KitapAdi);
                        command.Parameters.AddWithValue("@YazarID", kitap.YazarID);
                        command.Parameters.AddWithValue("@YayineviID", kitap.YayineviID);
                        command.Parameters.AddWithValue("@KitapTuruID", kitap.KitapTuruID);
                        command.Parameters.AddWithValue("@KategoriID", kitap.KategoriID);
                        command.Parameters.AddWithValue("@SayfaSayisi", kitap.SayfaSayisi);
                        command.Parameters.AddWithValue("@ISBN", kitap.ISBN);
                        command.Parameters.AddWithValue("@KitapRaf", kitap.KitapRaf);
                        command.Parameters.AddWithValue("@KitapID", kitap.ID);

                        connection.Open();
                        return command.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Kitap güncellenirken hata oluştu: " + ex.Message);
            }
        }

        public bool KitapSil(int kitapID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Kitaplar WHERE ID = @KitapID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@KitapID", kitapID);
                        connection.Open();
                        return command.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Kitap silinirken hata oluştu: " + ex.Message);
            }
        }

        public List<Kitap> TumKitaplariGetir()
        {
            List<Kitap> kitapListesi = new List<Kitap>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = @"SELECT k.ID, k.KitapAdi, k.YazarID, k.YayineviID, k.KitapTuruID, k.KategoriID, y.YazarAdi, y.YazarSoyadi, yv.YayineviAdi, 
                                            t.KitapTuruAdi, kr.KategoriAdi, k.SayfaSayisi, k.ISBN, k.KitapRaf
                                     FROM Kitaplar k
                                     LEFT JOIN Yazarlar y ON k.YazarID = y.ID
                                     LEFT JOIN Yayinevi yv ON k.YayineviID = yv.ID
                                     LEFT JOIN Turler t ON k.KitapTuruID = t.ID
                                     LEFT JOIN KategoriRaflar kr ON k.KategoriID = kr.ID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                kitapListesi.Add(new Kitap(
                                    Convert.ToInt32(reader["ID"]),
                                    reader["KitapAdi"].ToString(),
                                    Convert.ToInt32(reader["YazarID"]),
                                    Convert.ToInt32(reader["YayineviID"]),
                                    Convert.ToInt32(reader["KitapTuruID"]),
                                    Convert.ToInt32(reader["KategoriID"]),
                                    reader["YazarAdi"].ToString(),
                                    reader["YazarSoyadi"].ToString(),
                                    reader["YayineviAdi"].ToString(),
                                    reader["KitapTuruAdi"].ToString(),
                                    reader["KategoriAdi"].ToString(),
                                    Convert.ToInt32(reader["SayfaSayisi"]),
                                    reader["ISBN"].ToString(),
                                    reader["KitapRaf"].ToString()
                                ));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Kitaplar getirilirken hata oluştu: " + ex.Message);
            }

            return kitapListesi;
        }
    }
}
