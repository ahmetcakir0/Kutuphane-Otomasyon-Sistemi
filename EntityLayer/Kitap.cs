public class Kitap
{
    public int ID { get; set; }  // Kitap ID'si (veritabanından gelen anahtar)
    public string KitapAdi { get; set; }
    public int YazarID { get; set; }
    public int YayineviID { get; set; }
    public int KitapTuruID { get; set; }
    public int KategoriID { get; set; }
    public string SayfaSayisi { get; set; }
    public string ISBN { get; set; }

    // Kitap sınıfı yapıcı metodu
    public Kitap() { }

    // Parametreli yapıcı metot
    public Kitap(string kitapAdi, int yazarID, int yayineviID, int kitapTuruID, int kategoriID, string sayfaSayisi, string isbn)
    {
        KitapAdi = kitapAdi;
        YazarID = yazarID;
        YayineviID = yayineviID;
        KitapTuruID = kitapTuruID;
        KategoriID = kategoriID;
        SayfaSayisi = sayfaSayisi;
        ISBN = isbn;
    }

    // Parametreli yapıcı metot (ID ile)
    public Kitap(int id, string kitapAdi, int yazarID, int yayineviID, int kitapTuruID, int kategoriID, string sayfaSayisi, string isbn)
    {
        ID = id;
        KitapAdi = kitapAdi;
        YazarID = yazarID;
        YayineviID = yayineviID;
        KitapTuruID = kitapTuruID;
        KategoriID = kategoriID;
        SayfaSayisi = sayfaSayisi;
        ISBN = isbn;
    }
}
