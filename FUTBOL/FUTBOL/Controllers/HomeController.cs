using FUTBOL.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FUTBOL.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            ADJugador adJugador = new ADJugador();
            var juadores = adJugador.Buscar();
            ViewBag.Mensaje = String.Format("Bienvenido, hay {0} juadores", juadores.Count); ;
            return View();
        }

        public ActionResult Crear()
        {
            ADJugador adJugador = new ADJugador();
            adJugador.Agregar(new Jugador() { Apellido = "Neiman", Nombre = "Bicho" });
            adJugador.Agregar(new Jugador() { Apellido = "Rubin", Nombre = "Nicolas" });
            adJugador.Agregar(new Jugador() { Apellido = "Gleizer", Nombre = "Nicolas" });
            adJugador.Agregar(new Jugador() { Apellido = "Abadi", Nombre = "Alejandro" });
            adJugador.Agregar(new Jugador() { Apellido = "Amigo Rubin", Nombre = "Matias" });
            adJugador.Agregar(new Jugador() { Apellido = "Weicman", Nombre = "Jonathan" });
            adJugador.Agregar(new Jugador() { Apellido = "Kar", Nombre = "Jonathan" });
            adJugador.Agregar(new Jugador() { Apellido = "Alex", Nombre = "Alex" });
            adJugador.Agregar(new Jugador() { Apellido = "Benve", Nombre = "Martin" });
            adJugador.Agregar(new Jugador() { Apellido = "Pereyra", Nombre = "Alejo" });
            adJugador.Agregar(new Jugador() { Apellido = "Laijfer", Nombre = "Leo" });

            ViewBag.Mensaje = "Bienvenido";
            return View();
        }

    }
}
