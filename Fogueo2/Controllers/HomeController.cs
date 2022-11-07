using Fogueo2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Fogueo2.Controllers
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
            
            ViewBag.Message = "Mi matricula es 2021-0620";
            ViewBag.Message2 = "Carrera: Desarrollo de software";
            ViewData["MiNombre"] = "Nombres y apellidos: Fidel David Peguero Pineda";
            ViewData["FechaNac"] = "Fecha de nacimiento: 18/07/2002";
            ViewBag.Message3 = "Correo Institucional: 20210620@itla.edu.do";
            ViewBag.UnInt = 20 * 20 * 3;
            

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}