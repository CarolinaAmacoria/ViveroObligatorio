using CasosUso.InterfacesManejadores;
using CasosUso.Manejadores;
using Dominio.EntidadesNegocio;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Obligatorio.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string email, string contrasenia)
        {
            return View();
        }

        public IActionResult Logout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Logout(string email, string contrasenia)
        {
            return View();
        }

        public IManejadorPlantas ManejadorPlantas { get;  set; }

        public HomeController(IManejadorPlantas manejador)
        {
            ManejadorPlantas = manejador;
        }

        public ActionResult Index()
        {
            IEnumerable<Planta> plantas = ManejadorPlantas.TraerTodos();
            return View(plantas);
        }
    }
}
