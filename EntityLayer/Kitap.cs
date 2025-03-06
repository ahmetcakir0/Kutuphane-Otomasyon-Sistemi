public class Kitap
{
    public int ID { get; set; }
    public string KitapAdi { get; set; }
    public int YazarID { get; set; }
    public string YazarAdi { get; set; }
    public int YayineviID { get; set; }
    public string YayineviAdi { get; set; } 
    public int KitapTuruID { get; set; }
    public string TurAdi { get; set; } 
    public int KategoriID { get; set; }
    public string KategoriAdi { get; set; }
    public string SayfaSayisi { get; set; }
    public string ISBN { get; set; }
    public string RafNumarasi { get; set; }
    public string Aciklama { get; set; }

    public Kitap(string kitapAdi, int yazarID, string yazarAdi, int yayineviID, string yayineviAdi,
                 int kitapTuruID, string turAdi, int kategoriID, string kategoriAdi,
                 string sayfaSayisi, string isbn, string rafNumarasi, string aciklama)
    {
        KitapAdi = kitapAdi;
        YazarID = yazarID;
        YazarAdi = yazarAdi;
        YayineviID = yayineviID;
        YayineviAdi = yayineviAdi;
        KitapTuruID = kitapTuruID;
        TurAdi = turAdi;
        KategoriID = kategoriID;
        KategoriAdi = kategoriAdi;
        SayfaSayisi = sayfaSayisi;
        ISBN = isbn;
        RafNumarasi = rafNumarasi;
        Aciklama = aciklama;
    }

    public Kitap(int Id, string kitapAdi, int yazarID, string yazarAdi, int yayineviID, string yayineviAdi,
             int kitapTuruID, string turAdi, int kategoriID, string kategoriAdi,
             string sayfaSayisi, string isbn, string rafNumarasi, string aciklama)
    {
        ID = Id;
        KitapAdi = kitapAdi;
        YazarID = yazarID;
        YazarAdi = yazarAdi;
        YayineviID = yayineviID;
        YayineviAdi = yayineviAdi;
        KitapTuruID = kitapTuruID;
        TurAdi = turAdi;
        KategoriID = kategoriID;
        KategoriAdi = kategoriAdi;
        SayfaSayisi = sayfaSayisi;
        ISBN = isbn;
        RafNumarasi = rafNumarasi;
        Aciklama = aciklama;
    }
}

