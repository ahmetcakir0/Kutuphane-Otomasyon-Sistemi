using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;

namespace BusinessLayer
{
    public class KitapBL
    {
        private readonly KitapDAL kitapDal;
        public KitapBL(string connectionString)
        {
            kitapDal = new KitapDAL(connectionString);
        }
        public string KitapEkle(Kitaplar kitap)
        {
            if (string.IsNullOrWhiteSpace(kitap.KitapAdi))
            {
                return "Kitap adı boş olamaz.";
            }

            if (string.IsNullOrWhiteSpace(kitap.YazarAdi))
            {
                return "Yazar adı boş olamaz.";
            }

            if (kitap.SayfaSayisi > 0)
            {
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
            return null;
        }
        public string KitapGuncelle(Kitaplar kitap)
        {
            if (kitap.ID <= 0)
            {
                return "Geçersiz kitap ID.";
            }

            if (string.IsNullOrWhiteSpace(kitap.KitapAdi))
            {
                return "Kitap adı boş olamaz.";
            }

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
            {
                return "Geçersiz kitap ID.";
            }

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

        public List<Kitaplar> TumKitaplariGetir()
        {
            try
            {
                return kitapDal.TumKitaplariGetir();
            }
            catch (Exception)
            {
                return new List<Kitaplar>();
            }
        }

        public Kitaplar IdIleKitapGetir(int id)
        {
            if (id <= 0)
            {
                return null;
            }

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
