using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YayineviDataAccessLayer;

namespace YayineviBusinessLayer
{
    public class YayineviBL
    {
        private readonly YayineviDAL yayineviDal;

        public YayineviBL(string connectionString)
        {
            yayineviDal = new YayineviDAL(connectionString);
        }
        public string YayineviEkle(string yayineviAdi, string telNo, string eposta, string adres)
        {
            if (string.IsNullOrWhiteSpace(yayineviAdi))
                return "Yayınevi adı boş olamaz.";
            if (string.IsNullOrWhiteSpace(telNo))
                return "Telefon numarası boş olamaz.";
            if (string.IsNullOrWhiteSpace(eposta))
                return "E-posta adresi boş olamaz.";
            if (string.IsNullOrWhiteSpace(adres))
                return "Adres bilgisi boş olamaz.";

            try
            {
                bool sonuc = yayineviDal.YayineviEkle(yayineviAdi, telNo, eposta, adres);
                return sonuc ? "Yayınevi başarıyla eklendi." : "Yayınevi eklenemedi.";
            }
            catch (Exception ex)
            {
                return $"Hata: {ex.Message}";
            }
        }
        public string YayineviGuncelle(int id, string yayineviAdi, string telNo, string eposta, string adres)
        {
            if (id <= 0)
                return "Geçersiz yayınevi ID.";
            if (string.IsNullOrWhiteSpace(yayineviAdi))
                return "Yayınevi adı boş olamaz.";
            if (string.IsNullOrWhiteSpace(telNo))
                return "Telefon numarası boş olamaz.";
            if (string.IsNullOrWhiteSpace(eposta))
                return "E-posta adresi boş olamaz.";
            if (string.IsNullOrWhiteSpace(adres))
                return "Adres bilgisi boş olamaz.";

            try
            {
                bool sonuc = yayineviDal.YayineviGuncelle(id, yayineviAdi, telNo, eposta, adres);
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
                bool sonuc = yayineviDal.YayineviSil(id);
                return sonuc ? "Yayınevi başarıyla silindi." : "Yayınevi silinemedi.";
            }
            catch (Exception ex)
            {
                return $"Hata: {ex.Message}";
            }
        }
        public List<(int id, string YayineviAdi, string TelNo, string Eposta, string Adres)> YayineviListele()
        {
            try
            {
                return yayineviDal.YayineviListele();
            }
            catch (Exception ex)
            {
                throw new Exception($"Hata: {ex.Message}");
            }
        }
    }
}
