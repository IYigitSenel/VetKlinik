using Microsoft.AspNetCore.Mvc;

namespace VetKlinik.Web.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}