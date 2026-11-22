namespace VetKlinik.Web.Models;

public class MuayeneNotu
{
    public int Id { get; set; }
    public string Not { get; set; } = "";
    public DateTime Tarih { get; set; } = DateTime.Now;

    public int RandevuId { get; set; }
    public Randevu? Randevu { get; set; }
}
