using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class KitapDAL
    {
        private readonly string connectionString = "server=MBB-01-BIL065-N\\SQLEXPRESS; Initial Catalog=KutuphaneDB; Integrated Security=SSPI";


        public List<string> GetYayineviAdlari()
        {
            List<string> yayinevleri = new List<string>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT YayineviAdi FROM Yayinevleri"; // Yayınevi tablosundaki adları çek

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yayinevleri.Add(reader["YayineviAdi"].ToString()); // Listeye ekle
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Veritabanı hatası: " + ex.Message);
                }
            }

            return yayinevleri;
        }

        public List<string> GetTurAdlari()
        {
            List<string> turler = new List<string>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT TurAdi FROM Turler"; // Tür tablosundan adları getir

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            turler.Add(reader["TurAdi"].ToString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Veritabanı hatası: " + ex.Message);
                }
            }

            return turler;
        }
        public List<string> GetKategoriAdlari()
        {
            List<string> kategoriler = new List<string>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT KategoriAdi FROM Kategoriler"; // Kategori tablosundan adları getir

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            kategoriler.Add(reader["KategoriAdi"].ToString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Veritabanı hatası: " + ex.Message);
                }
            }

            return kategoriler;
        }
        public string GetYazarAdi(int yazarID)
        {
            string yazarAdi = string.Empty;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT YazarAdi FROM Yazarlar WHERE ID = @YazarID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@YazarID", yazarID);
                        conn.Open();
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            yazarAdi = result.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Yazar adı alınırken hata oluştu: " + ex.Message);
            }

            return yazarAdi;
        }


        public bool KitapEkle(Kitap yeniKitap)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = @"INSERT INTO Kitaplar (KitapAdi, YazarID, YayineviID, KitapTuruID, KategoriID, SayfaSayisi, ISBN) 
                             VALUES (@KitapAdi, @YazarID, @YayineviID, @KitapTuruID, @KategoriID, @SayfaSayisi, @ISBN)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@KitapAdi", yeniKitap.KitapAdi);
                        command.Parameters.AddWithValue("@YazarID", yeniKitap.YazarID);
                        command.Parameters.AddWithValue("@YayineviID", yeniKitap.YayineviID);
                        command.Parameters.AddWithValue("@KitapTuruID", yeniKitap.KitapTuruID);
                        command.Parameters.AddWithValue("@KategoriID", yeniKitap.KategoriID);
                        command.Parameters.AddWithValue("@SayfaSayisi", yeniKitap.SayfaSayisi);
                        command.Parameters.AddWithValue("@ISBN", yeniKitap.ISBN);

                        connection.Open();
                        return command.ExecuteNonQuery() > 0;  // Returns true if row is inserted, otherwise false
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
                                         ISBN = @ISBN
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
                        command.Parameters.AddWithValue("@ID", kitap.ID);

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
                    string query = "DELETE FROM Kitaplar WHERE ID = @Id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", kitapID);
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
                    string query = @"SELECT 
                              k.ID, k.KitapAdi, k.YazarID,
                              y.YazarAdi, k.YayineviID, yv.YayineviAdi, 
                              k.KitapTuruID, t.KitapTuruAdi, 
                              k.KategoriID, kr.KategoriAdi, 
                              k.SayfaSayisi, k.ISBN
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
                                // Yazar adı ve diğer detayları almak ve kullanmak
                                kitapListesi.Add(new Kitap(
                                    reader["KitapAdi"].ToString(),
                                    Convert.ToInt32(reader["YazarID"]),
                                    Convert.ToInt32(reader["YayineviID"]),
                                    Convert.ToInt32(reader["KitapTuruID"]),
                                    Convert.ToInt32(reader["KategoriID"]),
                                    reader["SayfaSayisi"].ToString(),
                                    reader["ISBN"].ToString()
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


        public Kitap KitapGetirById(int kitapID)
        {
            Kitap kitap = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = @"SELECT 
                                k.ID, k.KitapAdi, k.YazarID, y.YazarAdi,
                                k.YayineviID, yv.YayineviAdi, 
                                k.KitapTuruID, t.KitapTuruAdi, 
                                k.KategoriID, kr.KategoriAdi, 
                                k.SayfaSayisi, k.ISBN
                            FROM Kitaplar k
                            LEFT JOIN Yazarlar y ON k.YazarID = y.ID
                            LEFT JOIN Yayinevi yv ON k.YayineviID = yv.ID
                            LEFT JOIN Turler t ON k.KitapTuruID = t.ID
                            LEFT JOIN KategoriRaflar kr ON k.KategoriID = kr.ID
                            WHERE k.ID = @KitapID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", kitapID);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                kitap = new Kitap(
                                    reader["KitapAdi"].ToString(),              // Kitap Adı
                                    Convert.ToInt32(reader["YazarID"]),         // Yazar ID
                                    Convert.ToInt32(reader["YayineviID"]),      // Yayinevi ID
                                    Convert.ToInt32(reader["KitapTuruID"]),     // Kitap Turu ID
                                    Convert.ToInt32(reader["KategoriID"]),      // Kategori ID
                                    reader["SayfaSayisi"].ToString(),          // Sayfa Sayisi (string olarak alınıyor)
                                    reader["ISBN"].ToString()                   // ISBN
                                );
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Kitap getirilirken hata oluştu: " + ex.Message);
            }

            return kitap;
        }

    }
}
