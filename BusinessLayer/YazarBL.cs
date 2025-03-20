using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;
using System.Security.Policy;
using System.Data.SqlClient;
using System.Data;

namespace BusinessLayer
{
    public class YazarBL
    {

        private readonly YazarDAL yazarDal;

        public YazarBL()
        {
            yazarDal = new YazarDAL();
        }

        public string YazarEkle(Yazar yazar)
        {
            // Geçersiz girişleri kontrol et
            if (string.IsNullOrWhiteSpace(yazar.AdiSoyadi))
                return "Yazar adı soyadı boş olamaz.";

            if (yazar.AdiSoyadi.Length > 100)
                return "Yazar adı soyadı 100 karakterden uzun olamaz.";

            if (string.IsNullOrWhiteSpace(yazar.Iletisim))
                return "İletişim boş bırakılamaz.";

            if (string.IsNullOrWhiteSpace(yazar.Biyografi))
                return "Biyografi boş bırakılamaz.";

            try
            {
                bool sonuc = yazarDal.YazarEkle(yazar); // Yazar nesnesi doğrudan ekleniyor
                return sonuc ? "Yazar başarıyla eklendi." : "Yazar eklenemedi.";
            }
            catch (Exception ex)
            {
                return $"Hata: {ex.Message}";
            }
        }

        public string YazarGuncelle(int id, Yazar yazar)
        {
            // Geçersiz girişleri kontrol et
            if (id <= 0)
                return "Geçersiz yazar ID.";

            if (string.IsNullOrWhiteSpace(yazar.AdiSoyadi))
                return "Yazar adı soyadı boş olamaz.";

            if (yazar.AdiSoyadi.Length > 100)
                return "Yazar adı soyadı 100 karakterden uzun olamaz.";

            if (string.IsNullOrWhiteSpace(yazar.Iletisim))
                return "İletişim boş bırakılamaz.";

            if (string.IsNullOrWhiteSpace(yazar.Biyografi))
                return "Biyografi boş bırakılamaz.";

            try
            {
                bool sonuc = yazarDal.YazarGuncelle(id, yazar); // Yazar nesnesi ile güncelleniyor
                return sonuc ? "Yazar başarıyla güncellendi." : "Yazar güncellenemedi.";
            }
            catch (Exception ex)
            {
                return $"Hata: {ex.Message}";
            }
        }

        public DataTable TumYazarlariGetir()
        {
            try
            {
                return yazarDal.TumYazarlariGetir();
            }
            catch (Exception ex)
            {
                throw new Exception($"Hata: {ex.Message}");
            }
        }
        public DataRow YazarGetirById(int id)
        {
            if (id <= 0)
                throw new ArgumentException("Geçersiz yazar ID.");

            try
            {
                return yazarDal.YazarGetirById(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Hata: {ex.Message}");
            }
        }
        public DataTable YazarAra(string aramaMetni)
        {
            if (string.IsNullOrWhiteSpace(aramaMetni))
                return yazarDal.TumYazarlariGetir();

            try
            {
                return yazarDal.YazarAra(aramaMetni);
            }
            catch (Exception ex)
            {
                throw new Exception($"Hata: {ex.Message}");
            }
        }

        public bool IletisimVarMi(string iletisim)
        {
            return yazarDal.IletisimVarMi(iletisim);
        }
    }
}
