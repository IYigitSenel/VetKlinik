namespace VetKlinik.Web.Models;

public class Veteriner
{
    public int Id { get; set; }
    public string AdSoyad { get; set; } = "";
    public string Uzmanlik { get; set; } = "";

    // Identity kullanicisi ile baglanti (Adim 4'te kullanilacak)
    public string? KullaniciId { get; set; }

    public int KlinikId { get; set; }
    public Klinik? Klinik { get; set; }

    public List<MusaitlikSaati> MusaitlikSaatleri { get; set; } = new();
    public List<Randevu> Randevular { get; set; } = new();
}
