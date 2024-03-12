using HotelPlaza.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HotelPlaza.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            Hospede hospede = new Hospede("Júlia", "juliafigueiredo@hotmail.com");
            hospede.Logar();

            Reserva reserva = new Reserva("Larissa", "larissa@hotmail.com");
            reserva.Logar();

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
