public class Kitap
{
    public int ID { get; set; } // ID özelliği eklendi
    public string KitapAdi { get; set; }
    public int YazarID { get; set; }
    public string YazarAdi { get; set; }
    public int YayineviID { get; set; }
    public string YayineviAdi { get; set; }
    public int TurID { get; set; }
    public string TurAdi { get; set; }
    public int KategoriID { get; set; }
    public string KategoriAdi { get; set; }
    public string SayfaSayisi { get; set; }
    public string ISBN { get; set; }
    public string RafNumarasi { get; set; }
    public string Aciklama { get; set; }

    public Kitap()
    {

    }
    public Kitap(int id, string kitapAdi, int yazarID, string yazarAdi, int yayineviID, string yayineviAdi, int turID, string turAdi, int kategoriID, string kategoriAdi, string sayfaSayisi, string isbn, string rafNumarasi, string aciklama)
    {
        ID = id;
        KitapAdi = kitapAdi;
        YazarID = yazarID;
        YazarAdi = yazarAdi;
        YayineviID = yayineviID;
        YayineviAdi = yayineviAdi;
        TurID = turID;
        TurAdi = turAdi;
        KategoriID = kategoriID;
        KategoriAdi = kategoriAdi;
        SayfaSayisi = sayfaSayisi;
        ISBN = isbn;
        RafNumarasi = rafNumarasi;
        Aciklama = aciklama;
    }
}