using Ejecicio2NotasWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ejecicio2NotasWebApp.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index( CapturaDatos datos)
        {
            var opciones = new CapturaDatos();
            opciones.Nombre = datos.Nombre;
            ViewBag.nombre = opciones.Nombre;
            opciones.Apellido = datos.Apellido;
            ViewBag.apellido = opciones.Apellido;
            ViewBag.mate = opciones.Matematicas(datos);
            ViewBag.Ciencia = opciones.Ciencia(datos);
            ViewBag.lenguaje = opciones.Lenguaje(datos);
            ViewBag.Tecno= opciones.Tecnologia(datos);

            return View("MostrarDatos");
        }

        public ActionResult MostrarDatos()
        {
            return View();
        }

    }
}