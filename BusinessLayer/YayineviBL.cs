
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public string YayineviEkle(string yayineviAdi, string telNo, string ePosta, string adres)
        {
            if (string.IsNullOrWhiteSpace(yayineviAdi))
                return "Yayınevi adı soyadı boş olamaz.";

            if (yayineviAdi.Length > 100)
                return "Yayınevi adı 100 karakterden uzun olamaz.";

            if (string.IsNullOrWhiteSpace(telNo))
                return "Telefon numarası boş bırakılamaz.";

            if (string.IsNullOrWhiteSpace(ePosta))
                return "Eposta boş bırakılamaz.";

            if (string.IsNullOrWhiteSpace(adres))
                return "Adres boş bırakılamaz.";
            try
            {
                bool sonuc = yayineviDAL.YayineviEkle(yayineviAdi, telNo, ePosta, adres);
                return sonuc ? "Yayınevi başarıyla eklendi." : "Yayınevi eklenemedi.";
            }
            catch (Exception ex)
            {
                return $"Hata: {ex.Message}";
            }
        }

        public string YayineviGuncelle(int id, string yayineviAdi, string telNo, string ePosta, string adres)
        {
            if (id <= 0)
                return "Geçersiz yayınevi ID.";


            if (string.IsNullOrWhiteSpace(yayineviAdi))
                return "Yayınevi adı soyadı boş olamaz.";

            if (yayineviAdi.Length > 100)
                return "Yayınevi adı 100 karakterden uzun olamaz.";

            if (string.IsNullOrWhiteSpace(telNo))
                return "Telefon numarası boş bırakılamaz.";

            if (string.IsNullOrWhiteSpace(ePosta))
                return "Eposta boş bırakılamaz.";

            if (string.IsNullOrWhiteSpace(adres))
                return "Adres boş bırakılamaz.";

            try
            {
                bool sonuc = yayineviDAL.YayineviGuncelle(id, yayineviAdi, telNo, ePosta, adres);
                return sonuc ? "Yayınevi başarıyla güncellendi." : "Yayınevi güncellenemedi.";
            }
            catch (Exception ex)
            {
                return $"Hata: {ex.Message}";
            }
        }

        public string YayineviSil(int id)
        {
            if (id <= 0)
                return "Geçersiz yayınevi ID.";

            try
            {
                yayineviDAL.YayineviSil(id);
                return "Yayınevi başarıyla silindi.";
            }
            catch (Exception ex)
            {
                return $"Hata: {ex.Message}";
            }
        }

        public DataTable TumYayinevleriniGetir()
        {
            try
            {
                return yayineviDAL.TumYayinevleriniGetiir();
            }
            catch (Exception ex)
            {
                throw new Exception($"Hata: {ex.Message}");
            }
        }

        public DataRow YayineviGetirById(int id)
        {
            if (id <= 0)
                throw new ArgumentException("Geçersiz yayınevi ID.");

            try
            {
                return yayineviDAL.YayinevleriniGetirById(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Hata: {ex.Message}");
            }
        }
        public DataTable YayineviAra(string aramaMetni)
        {
            if (string.IsNullOrWhiteSpace(aramaMetni))
                return yayineviDAL.TumYayinevleriniGetiir();

            try
            {
                return yayineviDAL.YayineviAra(aramaMetni);
            }
            catch (Exception ex)
            {
                throw new Exception($"Hata: {ex.Message}");
            }
        }
    }
}
