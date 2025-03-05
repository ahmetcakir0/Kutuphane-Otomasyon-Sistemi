//using DataAccessLayer;
//using EntityLayer;
//using System;
//using System.Collections.Generic;

//namespace BusinessLayer
//{
//    public class KitapBL
//    {
//        private KitapDAL kitapDAL;

//        public KitapBL()
//        {
//            kitapDAL = new KitapDAL();
//        }

//        // Kitap ekleme işlemi
//        public string KitapEkle(Kitap yeniKitap)
//        {
//            try
//            {
//                // Doğrulama kontrolleri burada yapılabilir
//                if (string.IsNullOrEmpty(yeniKitap.KitapAdi))
//                {
//                    throw new Exception("Kitap adı boş olamaz.");
//                }

//                return "Kitap başarıyla eklendi";
//            }
//            catch (Exception ex)
//            {
//                throw new Exception("Kitap ekleme işlemi sırasında bir hata oluştu: " + ex.Message);
//            }
//        }

//        // Kitap güncelleme işlemi
//        public bool KitapGuncelle(Kitap kitap)
//        {
//            try
//            {
//                // Doğrulama kontrolleri burada yapılabilir
//                if (string.IsNullOrEmpty(kitap.KitapAdi))
//                {
//                    throw new Exception("Kitap adı boş olamaz.");
//                }

//                // Burada kitapAdi parametresi eklendi (Error CS7036 düzeltmesi)
//                return kitapDAL.KitapGuncelle(
//                    kitap.ID,
//                    kitap.KitapAdi,  // Bu parametre eksikti
//                    kitap.YazarID,
//                    kitap.YayineviID,
//                    kitap.KitapTuruID,
//                    kitap.KategoriID,
//                    kitap.SayfaSayisi,
//                    kitap.ISBN,
//                    kitap.KitapRaf
//                );
//            }
//            catch (Exception ex)
//            {
//                throw new Exception("Kitap güncelleme işlemi sırasında bir hata oluştu: " + ex.Message);
//            }
//        }

//        // Kitap silme işlemi
//        public bool KitapSil(int kitapID)
//        {
//            try
//            {
//                return kitapDAL.KitapSil(kitapID);
//            }
//            catch (Exception ex)
//            {
//                throw new Exception("Kitap silme işlemi sırasında bir hata oluştu: " + ex.Message);
//            }
//        }

//        // Tüm kitapları getirme işlemi
//        public List<Kitap> TumKitaplariGetir()
//        {
//            try
//            {
//                return kitapDAL.TumKitaplariGetir();
//            }
//            catch (Exception ex)
//            {
//                throw new Exception("Kitaplar listelenirken bir hata oluştu: " + ex.Message);
//            }
//        }

//        // ID ile kitap getirme işlemi
//        public Kitap KitapGetirById(int kitapID)
//        {
//            try
//            {
//                return kitapDAL.IdIleGetir(kitapID);
//            }
//            catch (Exception ex)
//            {
//                throw new Exception("Kitap getirilirken bir hata oluştu: " + ex.Message);
//            }
//        }
//    }
//}