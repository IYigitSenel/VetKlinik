namespace VetKlinik.Web.Models;

public class Sahip
{
    public int Id { get; set; }
    public string AdSoyad { get; set; } = "";
    public string Telefon { get; set; } = "";
    public string Eposta { get; set; } = "";

    // Identity kullanicisi ile baglanti (Adim 4'te kullanilacak)
    public string? KullaniciId { get; set; }

    public List<Hayvan> Hayvanlar { get; set; } = new();
}
