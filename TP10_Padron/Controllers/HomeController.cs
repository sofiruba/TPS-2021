using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TP10_Padron.Models;

namespace TP10_Padron.Controllers
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
            ViewBag.mensaje = null;
            return View();
        }

        [HttpGet]
        public IActionResult ConsultaPadron(int DNI){
            Persona ppadron = null;
            ppadron = BD.ConsultaPadron(DNI);

            if(ppadron==null){
                ViewBag.mensaje = "DNI no valido";
                return View("Index");
                
            }
            else{

            ViewBag.Nombre = ppadron.Nombre;
            ViewBag.Apellido = ppadron.Apellido;

                if(ppadron.Voto == true){
                    ViewBag.mensaje = "Su voto ya ha sido recibido";
                    return View("Index");
                }
                else{
                    ViewBag.DNI = DNI;
                    return View("Votar");
                }
            }
        }

        [HttpPost]
        public IActionResult Votar(int DNI, int numeroTramite){
            ViewBag.DNI = DNI;

            Persona ppadron = BD.ConsultaPadron(DNI);
            ViewBag.Nombre = ppadron.Nombre;
            ViewBag.Apellido = ppadron.Apellido;
            int pnro =ppadron.NumeroTramite;

            if (numeroTramite  != ppadron.NumeroTramite){
                ViewBag.mensaje = "Error";
                return View("Votar");

            }
            else{
    
                BD.Votar(DNI,numeroTramite);
                ViewBag.mensaje = "Su voto ha sido recibido";
                return View("Index");
            }

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
