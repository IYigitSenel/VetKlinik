namespace VetKlinik.Web.Models;

public class Randevu
{
    public int Id { get; set; }
    public DateTime Baslangic { get; set; }
    public DateTime Bitis { get; set; }
    public RandevuDurumu Durum { get; set; } = RandevuDurumu.Bekliyor;

    public int HayvanId { get; set; }
    public Hayvan? Hayvan { get; set; }

    public int VeterinerId { get; set; }
    public Veteriner? Veteriner { get; set; }

    public int HizmetId { get; set; }
    public Hizmet? Hizmet { get; set; }

    public MuayeneNotu? MuayeneNotu { get; set; }
}
