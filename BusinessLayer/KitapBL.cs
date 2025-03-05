using System;
using System.Collections.Generic;
using DataAccessLayer;
using EntityLayer;

namespace BusinessLayer
{
    public class KitapBL
    {
        private KitapDAL kitapDAL;

        public KitapBL()
        {
            kitapDAL = new KitapDAL();
        }

        public bool KitapEkle(Kitap yeniKitap)
        {
            try
            {
                if (string.IsNullOrEmpty(yeniKitap.KitapAdi))
                    throw new Exception("Kitap adı boş olamaz.");
                if (yeniKitap.SayfaSayisi <= 0)
                    throw new Exception("Sayfa sayısı pozitif bir değer olmalıdır.");
                if (string.IsNullOrEmpty(yeniKitap.ISBN))
                    throw new Exception("ISBN boş olamaz.");

                return kitapDAL.KitapEkle(yeniKitap);
            }
            catch (Exception ex)
            {
                throw new Exception("Kitap ekleme işlemi sırasında hata oluştu: " + ex.Message);
            }
        }

        public bool KitapGuncelle(Kitap kitap)
        {
            try
            {
                if (kitap.ID <= 0)
                    throw new Exception("Geçersiz Kitap ID.");
                if (string.IsNullOrEmpty(kitap.KitapAdi))
                    throw new Exception("Kitap adı boş olamaz.");
                if (kitap.SayfaSayisi <= 0)
                    throw new Exception("Sayfa sayısı pozitif bir değer olmalıdır.");
                if (string.IsNullOrEmpty(kitap.ISBN))
                    throw new Exception("ISBN boş olamaz.");

                return kitapDAL.KitapGuncelle(kitap);
            }
            catch (Exception ex)
            {
                throw new Exception("Kitap güncelleme işlemi sırasında hata oluştu: " + ex.Message);
            }
        }

        public bool KitapSil(int kitapID)
        {
            try
            {
                if (kitapID <= 0)
                    throw new Exception("Geçersiz Kitap ID.");

                return kitapDAL.KitapSil(kitapID);
            }
            catch (Exception ex)
            {
                throw new Exception("Kitap silme işlemi sırasında hata oluştu: " + ex.Message);
            }
        }

        public List<Kitap> TumKitaplariGetir()
        {
            try
            {
                return kitapDAL.TumKitaplariGetir();
            }
            catch (Exception ex)
            {
                throw new Exception("Kitapları getirirken hata oluştu: " + ex.Message);
            }
        }

        public Kitap KitapGetirById(int kitapID)
        {
            try
            {
                if (kitapID <= 0)
                    throw new Exception("Geçersiz Kitap ID.");

                return kitapDAL.KitapGetirById(kitapID);
            }
            catch (Exception ex)
            {
                throw new Exception("Kitap getirme işlemi sırasında hata oluştu: " + ex.Message);
            }
        }
    }
}
