using Microsoft.AspNetCore.Mvc;
using VetKlinik.Web.Models;

namespace VetKlinik.Web.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var hayvan = new Hayvan
        {
            Id = 1,
            Ad = "Pamuk",
            Tur = "Kedi",
            Irk = "Tekir",
            DogumTarihi = new DateTime(2022, 5, 10),
            Kilo = 4.2
        };

        return View(hayvan);
    }
}