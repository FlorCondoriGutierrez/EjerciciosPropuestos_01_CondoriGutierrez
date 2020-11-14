using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EjerciciosPropuestos_01_CondoriGutierrez.Models;

namespace EjerciciosPropuestos_01_CondoriGutierrez.Controllers
{
    public class Ejercicio03Controller : Controller
    {
        // GET: Ejercicio03
        public ActionResult Index()
        {

            return View();
        }
        public ActionResult Visualizar()
        {
            ClsEjercicio03 objCen = new ClsEjercicio03();

            objCen.centigrados = Convert.ToInt32(Request.Form["N"]);


            objCen.resultado = 32 + (9 * objCen.centigrados / 5);
            return View(objCen);
        }

    }
}