using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using firstApp.Models;

namespace firstApp.Controllers
{
    public class PersonalController : Controller
    {
        public IActionResult Index()
        {
            Personal personal = new Personal();
            personal.Nombre ="Liseth";
            personal.Apellido ="Ramos";
            personal.Edad=19;
            personal.CorreoElectronico ="lissramos2812@gmail.com";
            personal.Telefono = 77705057;
            personal.Direccion = "AvenidaGerardoBarriosBarrioSanPedro";

            return View(personal);
        }
    }
}