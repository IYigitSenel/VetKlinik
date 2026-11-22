namespace VetKlinik.Web.Models;

public class Hizmet
{
    public int Id { get; set; }
    public string Ad { get; set; } = "";
    public int SureDakika { get; set; }
    public decimal Fiyat { get; set; }

    public int KlinikId { get; set; }
    public Klinik? Klinik { get; set; }
}
