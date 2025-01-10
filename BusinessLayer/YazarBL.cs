using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;

namespace BusinessLayer
{
    public class YazarBL
    {
        private readonly YazarDAL yazarDal;

        public YazarBL(string connectionString)
        {
            yazarDal = new YazarDAL(connectionString);
        }
        public string YazarEkle(string yazarAdiSoyadi, string iletisim, string biyografi)
        {
            if (string.IsNullOrWhiteSpace(yazarAdiSoyadi))
                return "Yazar adı soyadı boş olamaz.";

            if (string.IsNullOrWhiteSpace(iletisim))
                return "İletişim bilgisi boş olamaz.";

            if (string.IsNullOrWhiteSpace(biyografi))
                return "Biyografi boş olamaz.";

            try
            {
                bool sonuc = yazarDal.YazarEkle(yazarAdiSoyadi, iletisim, biyografi);
                return sonuc ? "Yazar başarıyla eklendi." : "Yazar eklenemedi.";
            }
            catch (Exception ex)
            {
                return $"Hata: {ex.Message}";
            }
        }
        public string YazarGuncelle(int id, string yazarAdiSoyadi, string iletisim, string biyografi)
        {
            if (id <= 0)
                return "Geçersiz yazar ID.";

            if (string.IsNullOrWhiteSpace(yazarAdiSoyadi))
                return "Yazar adı soyadı boş olamaz.";

            if (string.IsNullOrWhiteSpace(iletisim))
                return "İletişim bilgisi boş olamaz.";

            if (string.IsNullOrWhiteSpace(biyografi))
                return "Biyografi boş olamaz.";

            try
            {
                bool sonuc = yazarDal.YazarGuncelle(id, yazarAdiSoyadi, iletisim, biyografi);
                return sonuc ? "Yazar başarıyla güncellendi." : "Yazar güncellenemedi.";
            }
            catch (Exception ex)
            {
                return $"Hata: {ex.Message}";
            }
        }
        public string YazarSil(int id)
        {
            if (id <= 0)
                return "Geçersiz yazar ID.";

            try
            {
                bool sonuc = yazarDal.YazarSil(id);
                return sonuc ? "Yazar başarıyla silindi." : "Yazar silinemedi.";
            }
            catch (Exception ex)
            {
                return $"Hata: {ex.Message}";
            }
        }
        public List<(int Id, string YazarAdiSoyadi, string Iletisim, string Biyografi)> YazarListele()
        {
            try
            {
                return yazarDal.YazarListele();
            }
            catch (Exception ex)
            {
                throw new Exception($"Hata: {ex.Message}");
            }
        }

    }
}
