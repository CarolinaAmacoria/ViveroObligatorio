using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Obligatorio.Controllers
{
    public class TipoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
