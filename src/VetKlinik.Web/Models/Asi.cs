namespace VetKlinik.Web.Models;

public class Asi
{
    public int Id { get; set; }
    public string Ad { get; set; } = "";
    public DateTime UygulamaTarihi { get; set; }
    public DateTime? SonrakiTarih { get; set; }

    public int HayvanId { get; set; }
    public Hayvan? Hayvan { get; set; }
}
