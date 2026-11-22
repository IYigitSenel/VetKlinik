namespace VetKlinik.Web.Models;

public class Hayvan
{
    public int Id { get; set; }
    public string Ad { get; set; } = "";
    public string Tur { get; set; } = "";
    public string Irk { get; set; } = "";
    public DateTime DogumTarihi { get; set; }
    public double Kilo { get; set; }

    public int? SahipId { get; set; }
    public Sahip? Sahip { get; set; }

    public List<Asi> Asilar { get; set; } = new();
    public List<Randevu> Randevular { get; set; } = new();
}
