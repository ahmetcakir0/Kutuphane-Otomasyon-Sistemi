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
    public class UyeBL
    {
        private readonly UyeDAL uyeDAL;

        public UyeBL()
        {
            uyeDAL = new UyeDAL();
        }

        public string UyeEkle(Uye uye)
        {
            if (uye == null)
                return "Üye bilgileri eksik.";

            if (string.IsNullOrWhiteSpace(uye.Ad))
                return "Üye adı boş olamaz.";

            if (uye.Ad.Length > 100)
                return "Üye adı 100 karakterden uzun olamaz.";

            if (string.IsNullOrWhiteSpace(uye.Soyad))
                return "Üye soyadı boş olamaz.";

            if (uye.Soyad.Length > 100)
                return "Üye soyadı 100 karakterden uzun olamaz.";

            if (string.IsNullOrWhiteSpace(uye.TCKimlik))
                return "Kimlik numarası boş bırakılamaz.";

            if (string.IsNullOrWhiteSpace(uye.TelNo))
                return "Telefon numarası boş bırakılamaz.";

            if (string.IsNullOrWhiteSpace(uye.Eposta))
                return "E-posta boş bırakılamaz.";

            if (string.IsNullOrWhiteSpace(uye.Adres))
                return "Adres boş bırakılamaz.";

            try
            {
                bool sonuc = uyeDAL.UyeEkle(uye);
                return sonuc ? "Üye başarıyla eklendi." : "Üye eklenemedi.";
            }
            catch (Exception ex)
            {
                return $"Hata: {ex.Message}";
            }
        }


        public string UyeGuncelle(Uye uye)
        {
            if (uye.ID <= 0)
                return "Geçersiz üye ID.";

            if (string.IsNullOrWhiteSpace(uye.Ad))
                return "Üye adı boş olamaz.";

            if (uye.Ad.Length > 100)
                return "Üye adı 100 karakterden uzun olamaz.";

            if (uye.Soyad.Length > 100)
                return "Üye soyadı 100 karakterden uzun olamaz.";

            if (string.IsNullOrWhiteSpace(uye.TCKimlik))
                return "Kimlik numarası boş bırakılamaz.";

            if (string.IsNullOrWhiteSpace(uye.TelNo))
                return "Telefon numarası boş bırakılamaz.";

            if (string.IsNullOrWhiteSpace(uye.Eposta))
                return "Eposta boş bırakılamaz.";

            if (string.IsNullOrWhiteSpace(uye.Adres))
                return "Adres boş bırakılamaz.";

            try
            {
                bool sonuc = uyeDAL.UyeGuncelle(uye); // Uye nesnesi doğrudan veritabanına güncelleniyor
                return sonuc ? "Üye başarıyla güncellendi." : "Üye güncellenemedi.";
            }
            catch (Exception ex)
            {
                return $"Hata: {ex.Message}";
            }
        }


        public bool UyeSil(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("Geçersiz üye ID'si.");
            }

            uyeDAL.UyeSil(id);
            return true;
        }

        public DataTable TumUyeleriGetir()
        {
            try
            {
                return uyeDAL.TumUyeleriGetir();
            }
            catch (Exception ex)
            {
                throw new Exception($"Hata: {ex.Message}");
            }
        }

        public DataRow UyeGetirById(int id)
        {
            if (id <= 0)
                throw new ArgumentException("Geçersiz üye ID.");

            try
            {
                return uyeDAL.UyeGetirById(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Hata: {ex.Message}");
            }
        }

        public DataTable UyeAra(string aramaMetni)
        {
            if (string.IsNullOrWhiteSpace(aramaMetni))
                return uyeDAL.TumUyeleriGetir();

            try
            {
                return uyeDAL.UyeAra(aramaMetni);
            }
            catch (Exception ex)
            {
                throw new Exception($"Hata: {ex.Message}");
            }
        }
    }
}
