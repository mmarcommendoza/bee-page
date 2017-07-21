using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace paginadetia.Controllers
{
    public class AbejitaController : Controller
    {
       public ActionResult Detalles()
        {
            if (DateTime.Today.DayOfWeek== DayOfWeek.Thursday)
            {
                return new RedirectResult("/");
            }
            return Content("El comienzo de esta nueva pagina para poder escribir cosas feas en el internet acerca de LALO CARA DE MESOPLAS, me tienes emperrado");

        }

    }
}