using HotelPlaza.Models;
using Microsoft.AspNetCore.Mvc;

namespace HotelPlaza.Controllers
{
    public class HospedeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details()
        {
            Hospede hospede = new Hospede("Júlia", "juliafigueiredo@hotmail.com");

            return View(hospede);
        }

        public IActionResult Lista()
        {
            List<Hospede> listaHospede = new List<Hospede>();

            Hospede hospede = new Hospede("Júlia", "juliafigueiredo@hotmail.com");
            Hospede hospede2 = new Hospede("Larissa", "larissa@hotmail.com");
            Hospede hospede3 = new Hospede("Isabelli", "isabelli@hotmail.com");
            Hospede hospede4 = new Hospede("João", "joao@hotmail.com");
            Hospede hospede5 = new Hospede("José", "jose@hotmail.com");
            Hospede hospede6 = new Hospede("Maria", "maria@hotmail.com");
            Hospede hospede7 = new Hospede("Cleiton", "cleiton@hotmail.com");

            listaHospede.Add(hospede);
            listaHospede.Add(hospede2);
            listaHospede.Add(hospede3);
            listaHospede.Add(hospede4);
            listaHospede.Add(hospede5);
            listaHospede.Add(hospede6);
            listaHospede.Add(hospede7);

            return View(listaHospede);
        }
    }
}
