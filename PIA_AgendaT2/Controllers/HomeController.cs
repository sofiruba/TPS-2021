using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PIA_AgendaT2.Models;

namespace PIA_AgendaT2.Controllers
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
           List<Contacto> Lista = BD.Listado();
           ViewBag.Listado = Lista;
            return View();
        }


        public IActionResult AgendarContacto()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AgendarContacto(string Apellido, string Nombre, string Telefono, string Email, string URLFoto)
        {
            Contacto PForm =new Contacto(1,Apellido, Nombre, Telefono, Email, URLFoto);
            BD.AgendarContacto(PForm);
            return RedirectToAction("Index");
        }

        public IActionResult  VerContacto(int IdContacto)
        {
            ViewData["IdContacto"] = IdContacto;
            Contacto VContacto = BD.VerContacto(IdContacto);
            ViewBag.Nombre = VContacto.Nombre;
            ViewBag.Apellido = VContacto.Apellido;
            ViewBag.Telefono = VContacto.Telefono;
            ViewBag.Email = VContacto.Email;
            ViewBag.URLFoto = VContacto.URLFoto;
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
