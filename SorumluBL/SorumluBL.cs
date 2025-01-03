using SorumluDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SorumluBL
{
    public class SorumluBL
    {
        private readonly SorumluDAL sorumluDal;

        public SorumluBL(string connectionString)
        {
            sorumluDal = new SorumluDAL(connectionString);
        }
        public string SorumluEkle(string sorumluAdi, string sorumluSoyadi, string tcKimlik, string rol,
            string telNo, string eposta, DateTime dogumTarihi, string adres, string kullaniciAdi, string sifre)
        {

            if (string.IsNullOrWhiteSpace(sorumluAdi))
                return "Sorumlu adı boş olamaz.";
            if (string.IsNullOrWhiteSpace(sorumluSoyadi))
                return "Sorumlu soyadı boş olamaz.";
            if (string.IsNullOrWhiteSpace(tcKimlik))
                return "TC Kimlik numarası boş olamaz.";
            if (string.IsNullOrWhiteSpace(rol))
                return "Rol boş olamaz.";
            if (string.IsNullOrWhiteSpace(telNo))
                return "Telefon numarası boş olamaz.";
            if (string.IsNullOrWhiteSpace(eposta))
                return "E-posta adresi boş olamaz.";
            if (string.IsNullOrWhiteSpace(adres))
                return "Adres boş olamaz.";
            if (string.IsNullOrWhiteSpace(kullaniciAdi))
                return "Kullanıcı adı boş olamaz.";
            if (string.IsNullOrWhiteSpace(sifre))
                return "Şifre boş olamaz.";

            if (!Regex.IsMatch(telNo, @"^\d{11}$"))
                return "Telefon numarası 11 haneli olmalıdır.";

            if (!Regex.IsMatch(tcKimlik, @"^\d{11}$"))
                return "TC Kimlik numarası 11 haneli olmalıdır.";

            if (!Regex.IsMatch(eposta, @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$"))
                return "Geçerli bir e-posta adresi giriniz.";

            if (sifre.Length < 6)
                return "Şifre en az 6 karakter olmalıdır.";

            if (dogumTarihi > DateTime.Now)
                return "Doğum tarihi bugünden büyük olamaz.";

            try
            {
                bool sonuc = sorumluDal.SorumluEkle(sorumluAdi, sorumluSoyadi, long.Parse(tcKimlik), rol,
                    telNo, eposta, dogumTarihi, adres, kullaniciAdi, sifre);
                return sonuc ? "Sorumlu başarıyla eklendi." : "Sorumlu eklenemedi.";
            }
            catch (Exception ex)
            {
                return $"Hata: {ex.Message}";
            }
        }
        public string SorumluGuncelle(int id, string sorumluAdi, string sorumluSoyadi, string tcKimlik,
            string rol, string telNo, string eposta, DateTime dogumTarihi, string adres, string kullaniciAdi, string sifre)
        {
            // ID kontrolü
            if (id <= 0)
                return "Geçersiz sorumlu ID.";

            if (string.IsNullOrWhiteSpace(sorumluAdi))
                return "Sorumlu adı boş olamaz.";
            if (string.IsNullOrWhiteSpace(sorumluSoyadi))
                return "Sorumlu soyadı boş olamaz.";
            if (string.IsNullOrWhiteSpace(tcKimlik))
                return "TC Kimlik numarası boş olamaz.";
            if (string.IsNullOrWhiteSpace(rol))
                return "Rol boş olamaz.";
            if (string.IsNullOrWhiteSpace(telNo))
                return "Telefon numarası boş olamaz.";
            if (string.IsNullOrWhiteSpace(eposta))
                return "E-posta adresi boş olamaz.";
            if (string.IsNullOrWhiteSpace(adres))
                return "Adres boş olamaz.";
            if (string.IsNullOrWhiteSpace(kullaniciAdi))
                return "Kullanıcı adı boş olamaz.";
            if (string.IsNullOrWhiteSpace(sifre))
                return "Şifre boş olamaz.";

            if (!Regex.IsMatch(telNo, @"^\d{11}$"))
                return "Telefon numarası 11 haneli olmalıdır.";

            if (!Regex.IsMatch(tcKimlik, @"^\d{11}$"))
                return "TC Kimlik numarası 11 haneli olmalıdır.";

            if (!Regex.IsMatch(eposta, @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$"))
                return "Geçerli bir e-posta adresi giriniz.";

            if (sifre.Length < 6)
                return "Şifre en az 6 karakter olmalıdır.";

            if (dogumTarihi > DateTime.Now)
                return "Doğum tarihi bugünden büyük olamaz.";

            try
            {
                bool sonuc = sorumluDal.SorumluGuncelle(id, sorumluAdi, sorumluSoyadi, long.Parse(tcKimlik),
                    rol, telNo, eposta, dogumTarihi, adres, kullaniciAdi, sifre);
                return sonuc ? "Sorumlu başarıyla güncellendi." : "Sorumlu güncellenemedi.";
            }
            catch (Exception ex)
            {
                return $"Hata: {ex.Message}";
            }
        }
        public string SorumluSil(int id)
        {
            if (id <= 0)
                return "Geçersiz sorumlu ID.";

            try
            {
                bool sonuc = sorumluDal.SorumluSil(id);
                return sonuc ? "Sorumlu başarıyla silindi." : "Sorumlu silinemedi.";
            }
            catch (Exception ex)
            {
                return $"Hata: {ex.Message}";
            }
        }
        public DataTable TumSorumlulariGetir()
        {
            try
            {
                return sorumluDal.TumSorumlulariGetir();
            }
            catch (Exception ex)
            {
                throw new Exception($"Hata: {ex.Message}");
            }
        }
        public string GirisYap(string kullaniciAdi, string sifre)
        {
            if (string.IsNullOrWhiteSpace(kullaniciAdi))
                return "Kullanıcı adı boş olamaz.";
            if (string.IsNullOrWhiteSpace(sifre))
                return "Şifre boş olamaz.";

            try
            {
                bool sonuc = sorumluDal.GirisYap(kullaniciAdi, sifre);
                return sonuc ? "Giriş başarılı." : "Kullanıcı adı veya şifre hatalı.";
            }
            catch (Exception ex)
            {
                return $"Hata: {ex.Message}";
            }
        }
        public DataRow SorumluGetirById(int id)
        {
            if (id <= 0)
                throw new ArgumentException("Geçersiz sorumlu ID.");

            try
            {
                return sorumluDal.SorumluGetirById(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Hata: {ex.Message}");
            }
        }
        public DataTable SorumluAra(string aramaMetni)
        {
            if (string.IsNullOrWhiteSpace(aramaMetni))
                return sorumluDal.TumSorumlulariGetir();

            try
            {
                return sorumluDal.SorumluAra(aramaMetni);
            }
            catch (Exception ex)
            {
                throw new Exception($"Hata: {ex.Message}");
            }
        }
    }
}
