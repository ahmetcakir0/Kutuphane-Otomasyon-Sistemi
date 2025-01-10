
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;

namespace BusinessLayer
{
    public class YayineviBL
    {
        private readonly YayineviDAL yayineviDal;

        public YayineviBL(string connectionString)
        {
            yayineviDal = new YayineviDAL(connectionString);
        }

        public string YayineviEkle(string yayineviAdi, string eposta, string telNo, string adres)
        {
            if (string.IsNullOrWhiteSpace(yayineviAdi))
                return "Yayınevi adı boş olamaz.";
            if (string.IsNullOrWhiteSpace(eposta))
                return "E-posta adresi boş olamaz.";
            if (string.IsNullOrWhiteSpace(telNo))
                return "Telefon numarası boş olamaz.";
            if (string.IsNullOrWhiteSpace(adres))
                return "Adres bilgisi boş olamaz.";

            try
            {
                Yayinevi yeniYayinevi = new Yayinevi
                {
                    YayineviAdi = yayineviAdi,
                    Eposta = eposta,
                    TelNo = telNo,
                    Adres = adres
                };
                yayineviDal.Ekle(yeniYayinevi);
                return "Yayınevi başarıyla eklendi.";
            }
            catch (Exception ex)
            {
                return $"Hata: {ex.Message}";
            }
        }

        public string YayineviGuncelle(int id, string yayineviAdi, string eposta, string telNo, string adres)
        {
            if (id <= 0)
                return "Geçersiz yayınevi ID.";
            if (string.IsNullOrWhiteSpace(yayineviAdi))
                return "Yayınevi adı boş olamaz.";
            if (string.IsNullOrWhiteSpace(eposta))
                return "E-posta adresi boş olamaz.";
            if (string.IsNullOrWhiteSpace(telNo))
                return "Telefon numarası boş olamaz.";
            if (string.IsNullOrWhiteSpace(adres))
                return "Adres bilgisi boş olamaz.";

            try
            {
                Yayinevi guncellenecekYayinevi = new Yayinevi
                {
                    id = id,
                    YayineviAdi = yayineviAdi,
                    Eposta = eposta,
                    TelNo = telNo,
                    Adres = adres
                };
                yayineviDal.Guncelle(guncellenecekYayinevi);
                return "Yayınevi başarıyla güncellendi.";
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
                yayineviDal.Sil(id);
                return "Yayınevi başarıyla silindi.";
            }
            catch (Exception ex)
            {
                return $"Hata: {ex.Message}";
            }
        }

        public List<Yayinevi> YayineviListele()
        {
            try
            {
                return yayineviDal.TumYayinevleriniGetir();
            }
            catch (Exception ex)
            {
                throw new Exception($"Hata: {ex.Message}");
            }
        }

        public Yayinevi YayineviIdIleGetir(int id)
        {
            if (id <= 0)
                throw new Exception("Geçersiz yayınevi ID.");

            try
            {
                return yayineviDal.IdIleGetir(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Hata: {ex.Message}");
            }
        }
    }
}
