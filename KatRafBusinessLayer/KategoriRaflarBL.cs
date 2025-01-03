using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KatRafDataAccessLayer;

namespace KatRafBusinessLayer
{
    public class KategoriRaflarBL
    {
        private readonly KategoriRaflarDAL kategoriDal;

        public KategoriRaflarBL(string connectionString)
        {
            kategoriDal = new KategoriRaflarDAL(connectionString);
        }
        public string KategoriEkle(int id, string kategoriAdi, int kategoriRafKodu)
        {
            if (id <= 0)
            {
                return "ID değeri sıfır veya negatif olamaz.";
            }

            if (string.IsNullOrWhiteSpace(kategoriAdi))
            {
                return "Kategori adı boş olamaz.";
            }

            if (kategoriRafKodu <= 0)
            {
                return "Kategori Raf Kodu sıfır veya negatif olamaz.";
            }

            try
            {
                bool sonuc = kategoriDal.KategoriEkle(id, kategoriAdi, kategoriRafKodu);
                return sonuc ? "Kategori başarıyla eklendi." : "Kategori eklenirken bir hata oluştu.";
            }
            catch (Exception ex)
            {
                return $"Bir hata oluştu: {ex.Message}";
            }
        }
        public string KategoriSil(int id)
        {
            if (id <= 0)
            {
                return "ID değeri sıfır veya negatif olamaz.";
            }

            try
            {
                bool sonuc = kategoriDal.KategoriSil(id);
                return sonuc ? "Kategori başarıyla silindi." : "Kategori silinirken bir hata oluştu.";
            }
            catch (Exception ex)
            {
                return $"Bir hata oluştu: {ex.Message}";
            }
        }
        public string KategoriGuncelle(int id, string kategoriAdi, int kategoriRafKodu)
        {
            if (id <= 0)
            {
                return "ID değeri sıfır veya negatif olamaz.";
            }

            if (string.IsNullOrWhiteSpace(kategoriAdi))
            {
                return "Kategori adı boş olamaz.";
            }

            if (kategoriRafKodu <= 0)
            {
                return "Kategori Raf Kodu sıfır veya negatif olamaz.";
            }

            try
            {
                bool sonuc = kategoriDal.KategoriGuncelle(id, kategoriAdi, kategoriRafKodu);
                return sonuc ? "Kategori başarıyla güncellendi." : "Kategori güncellenirken bir hata oluştu.";
            }
            catch (Exception ex)
            {
                return $"Bir hata oluştu: {ex.Message}";
            }
        }
        public List<(int ID, string KategoriAdi, int KategoriRafKodu)> KategorileriGetir()
        {
            try
            {
                return kategoriDal.KategorileriGetir();
            }
            catch (Exception ex)
            {
                throw new Exception($"Kategoriler getirilirken bir hata oluştu: {ex.Message}");
            }
        }
    }
}
