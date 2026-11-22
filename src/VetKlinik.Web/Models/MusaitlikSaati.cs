namespace VetKlinik.Web.Models;

public class MusaitlikSaati
{
    public int Id { get; set; }
    public DayOfWeek Gun { get; set; }
    public TimeSpan Baslangic { get; set; }
    public TimeSpan Bitis { get; set; }

    public int VeterinerId { get; set; }
    public Veteriner? Veteriner { get; set; }
}
