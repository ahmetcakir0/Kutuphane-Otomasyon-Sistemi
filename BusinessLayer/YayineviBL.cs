using System;
using System.Collections.Generic;
using EntityLayer;
using DataAccessLayer;
using System.Data;

namespace BusinessLayer
{
    public class YayineviBL
    {
        private readonly YayineviDAL yayineviDAL;

        public YayineviBL()
        {
            yayineviDAL = new YayineviDAL();
        }

        // Yayinevi Ekleme
        public string YayineviEkle(Yayinevi yayinevi)
        {
            if (string.IsNullOrWhiteSpace(yayinevi.YayineviAdi))
                return "Yayınevi adı boş olamaz.";

            if (yayinevi.YayineviAdi.Length > 100)
                return "Yayınevi adı 100 karakterden uzun olamaz.";

            if (string.IsNullOrWhiteSpace(yayinevi.TelNo))
                return "Telefon numarası boş bırakılamaz.";

            if (string.IsNullOrWhiteSpace(yayinevi.Eposta))
                return "E-posta boş bırakılamaz.";

            if (string.IsNullOrWhiteSpace(yayinevi.Adres))
                return "Adres boş bırakılamaz.";

            try
            {
                bool sonuc = yayineviDAL.YayineviEkle(yayinevi);
                return sonuc ? "Yayınevi başarıyla eklendi." : "Yayınevi eklenemedi.";
            }
            catch (Exception ex)
            {
                return $"Hata: {ex.Message}";
            }
        }

        // Yayinevi Güncelleme
        public string YayineviGuncelle(Yayinevi yayinevi)
        {
            if (yayinevi.id <= 0)
                return "Geçersiz yayınevi ID.";

            if (string.IsNullOrWhiteSpace(yayinevi.YayineviAdi))
                return "Yayınevi adı boş olamaz.";

            if (yayinevi.YayineviAdi.Length > 100)
                return "Yayınevi adı 100 karakterden uzun olamaz.";

            if (string.IsNullOrWhiteSpace(yayinevi.TelNo))
                return "Telefon numarası boş bırakılamaz.";

            if (string.IsNullOrWhiteSpace(yayinevi.Eposta))
                return "E-posta boş bırakılamaz.";

            if (string.IsNullOrWhiteSpace(yayinevi.Adres))
                return "Adres boş bırakılamaz.";

            try
            {
                bool sonuc = yayineviDAL.YayineviGuncelle(yayinevi);
                return sonuc ? "Yayınevi başarıyla güncellendi." : "Yayınevi güncellenemedi.";
            }
            catch (Exception ex)
            {
                return $"Hata: {ex.Message}";
            }
        }

        // Yayinevi Silme
        public string YayineviSil(int id)
        {
            if (id <= 0)
                return "Geçersiz yayınevi ID.";

            try
            {
                bool sonuc = yayineviDAL.YayineviSil(id);
                return sonuc ? "Yayınevi başarıyla silindi." : "Yayınevi silinemedi.";
            }
            catch (Exception ex)
            {
                return $"Hata: {ex.Message}";
            }
        }

        // Tüm Yayinevlerini Getir
        public List<Yayinevi> TumYayinevleriniGetir()
        {
            try
            {
                return yayineviDAL.TumYayinevleriniGetir();
            }
            catch (Exception ex)
            {
                throw new Exception($"Hata: {ex.Message}");
            }
        }

        // Yayinevi ID ile Getir
        public Yayinevi YayineviGetirById(int id)
        {
            if (id <= 0)
                throw new ArgumentException("Geçersiz yayınevi ID.");

            try
            {
                return yayineviDAL.YayineviGetirById(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Hata: {ex.Message}");
            }
        }

        // Yayinevi Ara
        public List<Yayinevi> YayineviAra(string aramaMetni)
        {
            try
            {
                return yayineviDAL.YayineviAra(aramaMetni);
            }
            catch (Exception ex)
            {
                throw new Exception($"Hata: {ex.Message}");
            }
        }

        public bool TelNoVarMi(string telNo)
        {
            return yayineviDAL.TelNoVarMi(telNo);
        }

        // E-posta adresinin var olup olmadığını kontrol et
        public bool EpostaVarMi(string eposta)
        {
            return yayineviDAL.EpostaVarMi(eposta);
        }
    }
}
