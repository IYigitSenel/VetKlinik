namespace VetKlinik.Web.Models;

public class Klinik
{
    public int Id { get; set; }
    public string Ad { get; set; } = "";
    public string Adres { get; set; } = "";
    public string Telefon { get; set; } = "";

    public List<Veteriner> Veterinerler { get; set; } = new();
    public List<Hizmet> Hizmetler { get; set; } = new();
}
