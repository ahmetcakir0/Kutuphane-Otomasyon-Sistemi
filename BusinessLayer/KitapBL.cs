using System;
using System.Collections.Generic;
using EntityLayer;
using DataAccessLayer;

namespace BusinessLayer
{
    public class KitapBL
    {
        private readonly KitapDAL kitapDal;
        private string connectionString;

        public KitapBL(string connectionString)
        {
            this.connectionString = connectionString;
            this.kitapDal = new KitapDAL();
        }

        public string KitapEkle(Kitap kitap)
        {
            if (string.IsNullOrWhiteSpace(kitap.KitapAdi))
                return "Kitap adı boş olamaz.";

            if (string.IsNullOrWhiteSpace(kitap.YazarAdi))
                return "Yazar adı boş olamaz.";

            if (kitap.SayfaSayisi <= 0)
                return "Sayfa sayısı pozitif bir değer olmalıdır.";

            try
            {
                kitapDal.Ekle(kitap);
                return "Kitap başarıyla eklendi.";
            }
            catch (Exception ex)
            {
                return $"Bir hata oluştu: {ex.Message}";
            }
        }

        public string KitapGuncelle(Kitap kitap)
        {
            if (kitap.ID <= 0)
                return "Geçersiz kitap ID.";

            if (string.IsNullOrWhiteSpace(kitap.KitapAdi))
                return "Kitap adı boş olamaz.";

            if (kitap.SayfaSayisi <= 0)
                return "Sayfa sayısı pozitif bir değer olmalıdır.";

            try
            {
                kitapDal.Guncelle(kitap);
                return "Kitap başarıyla güncellendi.";
            }
            catch (Exception ex)
            {
                return $"Bir hata oluştu: {ex.Message}";
            }
        }

        public string KitapSil(int id)
        {
            if (id <= 0)
                return "Geçersiz kitap ID.";

            try
            {
                kitapDal.Sil(id);
                return "Kitap başarıyla silindi.";
            }
            catch (Exception ex)
            {
                return $"Bir hata oluştu: {ex.Message}";
            }
        }

        public List<Kitap> TumKitaplariGetir()
        {
            try
            {
                return kitapDal.TumKitaplariGetir();
            }
            catch (Exception ex)
            {
                return new List<Kitap> { new Kitap { KitapAdi = $"Hata: {ex.Message}" } };
            }
        }

        public Kitap IdIleKitapGetir(int id)
        {
            if (id <= 0)
                return null;

            try
            {
                return kitapDal.IdIleGetir(id);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
