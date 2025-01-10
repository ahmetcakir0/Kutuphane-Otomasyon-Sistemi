using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;

namespace BusinessLayer
{
    public class TurBL
    {
        private readonly TurDAL turDal;

        public TurBL(string connectionString)
        {
            turDal = new TurDAL();
        }

        public string TurEkle(string turAdi, string aciklama)
        {
            if (string.IsNullOrWhiteSpace(turAdi))
                return "Tür adı boş olamaz.";

            if (turAdi.Length > 1000)
                return "Tür adı 1000 karakterden uzun olamaz.";

            try
            {
                bool sonuc = turDal.TurEkle(turAdi, aciklama);
                return sonuc ? "Tür başarıyla eklendi." : "Tür eklenemedi.";
            }
            catch (Exception ex)
            {
                return $"Hata: {ex.Message}";
            }
        }

        public string TurGuncelle(int id, string turAdi, string aciklama)
        {
            if (id <= 0)
                return "Geçersiz tür ID.";

            if (string.IsNullOrWhiteSpace(turAdi))
                return "Tür adı boş olamaz.";

            if (turAdi.Length > 1000)
                return "Tür adı 1000 karakterden uzun olamaz.";

            try
            {
                bool sonuc = turDal.TurGuncelle(id, turAdi, aciklama);
                return sonuc ? "Tür başarıyla güncellendi." : "Tür güncellenemedi.";
            }
            catch (Exception ex)
            {
                return $"Hata: {ex.Message}";
            }
        }

        public DataTable TumTurleriGetir()
        {
            try
            {
                return turDal.TumTurleriGetir();
            }
            catch (Exception ex)
            {
                throw new Exception($"Hata: {ex.Message}");
            }
        }

        public DataRow TurGetirById(int id)
        {
            if (id <= 0)
                throw new ArgumentException("Geçersiz tür ID.");

            try
            {
                return turDal.TurGetirById(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Hata: {ex.Message}");
            }
        }

        public DataTable TurAra(string aramaMetni)
        {
            if (string.IsNullOrWhiteSpace(aramaMetni))
                return turDal.TumTurleriGetir();

            try
            {
                return turDal.TurAra(aramaMetni);
            }
            catch (Exception ex)
            {
                throw new Exception($"Hata: {ex.Message}");
            }
        }
    }
}

