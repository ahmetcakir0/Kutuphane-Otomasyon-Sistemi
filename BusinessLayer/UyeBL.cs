using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;

namespace BusinessLayer
{
    public class UyeBL
    {
        private readonly UyeDAL uyeDAL;

        public UyeBL(string connectionString)
        {
            uyeDAL = new UyeDAL(connectionString);
        }

        public bool UyeEkle(Uyeler uye)
        {
            if (string.IsNullOrWhiteSpace(uye.Ad) || string.IsNullOrWhiteSpace(uye.Soyad))
            {
                throw new ArgumentException("Üye adı ve soyadı boş olamaz.");
            }

            uyeDAL.Ekle(uye);
            return true;
        }

        public bool UyeGuncelle(Uyeler uye)
        {
            if (uye.ID <= 0)
            {
                throw new ArgumentException("Geçersiz üye ID'si.");
            }

            uyeDAL.Guncelle(uye);
            return true;
        }

        public bool UyeSil(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("Geçersiz üye ID'si.");
            }

            uyeDAL.Sil(id);
            return true;
        }

        public List<Uyeler> TumUyeleriGetir()
        {
            return uyeDAL.TumUyeleriGetir();
        }

        public Uyeler UyeGetirById(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("Geçersiz üye ID'si.");
            }

            return uyeDAL.IdIleGetir(id);
        }
    }
}
