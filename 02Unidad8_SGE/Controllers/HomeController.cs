using System.Diagnostics;
using _02Unidad8_SGE.Models;
using Microsoft.AspNetCore.Mvc;

namespace _02Unidad8_SGE.Controllers
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

        public IActionResult Ejercicio1(String nombre)
        {
            ViewBag.nombre = nombre;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Ejercicio2()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Ejercicio2(String nombre)
        {
            ViewBag.Nombre = nombre;
            return View("Saludo");
        }

        public IActionResult Ejercicio3()
        {   
            Persona persona = new Persona(1, "Eryka", "Zapata Navarro");
            return View(persona);
        }

        [HttpPost] 
        public IActionResult Ejercicio3(Persona persona)
        {
            return View("PersonaModificada", persona);
        }





        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
