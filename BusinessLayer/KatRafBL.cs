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
    public class KatRafBL
    {
        private readonly  KatRafDAL kategoriDal;

        public KatRafBL()
        {
            kategoriDal = new KatRafDAL();
        }

        public string KategoriEkle(string kategoriAdi)
        {
            if (string.IsNullOrWhiteSpace(kategoriAdi))
                return "Kategori adı boş olamaz.";

            if (kategoriAdi.Length > 100)
                return "Kategori adı 100 karakterden uzun olamaz.";

            try
            {
                bool sonuc = kategoriDal.KategoriEkle(kategoriAdi);
                return sonuc ? "Kategori başarıyla eklendi." : "Kategorş eklenemedi.";
            }
            catch (Exception ex)
            {
                return $"Hata: {ex.Message}";
            }
        }

        public bool KategoriSil(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("Geçersiz üye ID'si.");
            }

            kategoriDal.KategoriSil(id);
            return true;
        }


        public string KategoriGuncelle(int id, string kategoriAdi)
        {
            if (id <= 0)
                return "Geçersiz tür ID.";

            if (string.IsNullOrWhiteSpace(kategoriAdi))
                return "Kategori adı boş olamaz.";

            if (kategoriAdi.Length > 100)
                return "Kategori adı 100 karakterden uzun olamaz.";

            try
            {
                bool sonuc = kategoriDal.KategoriGuncelle(id, kategoriAdi);
                return sonuc ? "Kategori başarıyla güncellendi." : "Kategori güncellenemedi.";
            }
            catch (Exception ex)
            {
                return $"Hata: {ex.Message}";
            }
        }

        public DataTable TumKategoriRaflariGetir()
        {
            try
            {
                return kategoriDal.TumKategoriRaflariGetir();
            }
            catch (Exception ex)
            {
                throw new Exception($"Hata: {ex.Message}");
            }
        }

        public DataRow KategoriGetirById(int id)
        {
            if (id <= 0)
                throw new ArgumentException("Geçersiz tür ID.");

            try
            {
                return kategoriDal.KategoriRaflarGetirById(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Hata: {ex.Message}");
            }
        }
        public DataTable KategoriAra(string aramaMetni)
        {
            if (string.IsNullOrWhiteSpace(aramaMetni))
                return kategoriDal.TumKategoriRaflariGetir();

            try
            {
                return kategoriDal.KategoriRaflarAra(aramaMetni);
            }
            catch (Exception ex)
            {
                throw new Exception($"Hata: {ex.Message}");
            }
        }
    }
}

