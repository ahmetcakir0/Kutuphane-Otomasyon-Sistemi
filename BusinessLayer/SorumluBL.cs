using System;
using System.Data;
using EntityLayer;
using DataAccessLayer;

namespace BusinessLayer
{
    public class SorumluBL
    {
        private readonly SorumluDAL sorumluDAL;

        public SorumluBL()
        {
            sorumluDAL = new SorumluDAL();
        }

        public string SorumluEkle(Sorumlu sorumlu)
        {
            if (sorumlu == null)
                return "Sorumlu bilgileri eksik.";

            if (string.IsNullOrWhiteSpace(sorumlu.SorumluAdi))
                return "Sorumlu adı boş olamaz.";

            if (sorumlu.SorumluAdi.Length > 100)
                return "Sorumlu adı 100 karakterden uzun olamaz.";

            if (string.IsNullOrWhiteSpace(sorumlu.SorumluSoyadi))
                return "Sorumlu soyadı boş olamaz.";

            if (sorumlu.SorumluSoyadi.Length > 100)
                return "Sorumlu soyadı 100 karakterden uzun olamaz.";

            if (string.IsNullOrWhiteSpace(sorumlu.TCKimlik))
                return "TC Kimlik numarası boş bırakılamaz.";

            if (string.IsNullOrWhiteSpace(sorumlu.TelNo))
                return "Telefon numarası boş olamaz.";

            if (string.IsNullOrWhiteSpace(sorumlu.Eposta))
                return "E-posta boş bırakılamaz.";

            if (string.IsNullOrWhiteSpace(sorumlu.Adres))
                return "Adres boş bırakılamaz.";

            if (string.IsNullOrWhiteSpace(sorumlu.KullaniciAdi))
                return "Kullanıcı adı boş bırakılamaz.";

            if (string.IsNullOrWhiteSpace(sorumlu.Sifre))
                return "Şifre boş bırakılamaz.";

            if (sorumlu.Sifre.Length < 6)
                return "Şifre en az 6 karakter uzunluğunda olmalıdır.";

            try
            {
                // SorumluDAL.SorumluEkle metodu string döndürdüğü için sonucu string olarak alıyoruz.
                string sonuc = sorumluDAL.SorumluEkle(sorumlu);
                return sonuc;
            }
            catch (Exception ex)
            {
                return $"Hata: {ex.Message}";
            }
        }

        public string SorumluGuncelle(Sorumlu sorumlu)
        {
            if (sorumlu.ID <= 0)
                return "Geçersiz sorumlu ID.";

            if (string.IsNullOrWhiteSpace(sorumlu.SorumluAdi))
                return "Sorumlu adı boş olamaz.";

            if (sorumlu.SorumluAdi.Length > 100)
                return "Sorumlu adı 100 karakterden uzun olamaz.";

            if (string.IsNullOrWhiteSpace(sorumlu.SorumluSoyadi))
                return "Sorumlu soyadı boş olamaz.";

            if (sorumlu.SorumluSoyadi.Length > 100)
                return "Sorumlu soyadı 100 karakterden uzun olamaz.";

            if (string.IsNullOrWhiteSpace(sorumlu.TCKimlik))
                return "TC Kimlik numarası boş bırakılamaz.";

            if (string.IsNullOrWhiteSpace(sorumlu.TelNo))
                return "Telefon numarası boş olamaz.";

            if (string.IsNullOrWhiteSpace(sorumlu.Eposta))
                return "E-posta boş bırakılamaz.";

            if (string.IsNullOrWhiteSpace(sorumlu.Adres))
                return "Adres boş bırakılamaz.";

            if (string.IsNullOrWhiteSpace(sorumlu.KullaniciAdi))
                return "Kullanıcı adı boş bırakılamaz.";

            if (string.IsNullOrWhiteSpace(sorumlu.Sifre))
                return "Şifre boş bırakılamaz.";

            if (sorumlu.Sifre.Length < 6)
                return "Şifre en az 6 karakter uzunluğunda olmalıdır.";

            try
            {
                // SorumluDAL.SorumluGuncelle metodu da string döndürdüğü için sonucu string olarak alıyoruz.
                string sonuc = sorumluDAL.SorumluGuncelle(sorumlu);
                return sonuc;
            }
            catch (Exception ex)
            {
                return $"Hata: {ex.Message}";
            }
        }

        public bool SorumluSil(int id)
        {
            if (id <= 0)
                throw new ArgumentException("Geçersiz sorumlu ID'si.");

            try
            {
                return sorumluDAL.SorumluSil(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Hata: {ex.Message}");
            }
        }

        public DataTable TumSorumlulariGetir()
        {
            try
            {
                return sorumluDAL.TumSorumlulariGetir();
            }
            catch (Exception ex)
            {
                throw new Exception($"Hata: {ex.Message}");
            }
        }

        public DataRow SorumluGetirById(int id)
        {
            if (id <= 0)
                throw new ArgumentException("Geçersiz sorumlu ID.");

            try
            {
                return sorumluDAL.SorumluGetirByİd(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Hata: {ex.Message}");
            }
        }

        public DataTable SorumluAra(string aramaMetni)
        {
            if (string.IsNullOrWhiteSpace(aramaMetni))
                return sorumluDAL.TumSorumlulariGetir();

            try
            {
                return sorumluDAL.SorumluAra(aramaMetni);
            }
            catch (Exception ex)
            {
                throw new Exception($"Hata: {ex.Message}");
            }
        }
    }
}
