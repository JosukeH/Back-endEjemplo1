using Back_endEjemplo1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace Back_endEjemplo1.Controllers
{
    public class CalculosController : Controller
    {
        // GET: Calculos
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Suma(String n1, string n2)
        {
            int res = 0;
            res = Convert.ToInt16(n1) + Convert.ToInt16(n2);
            ViewBag.res = res;
            return View();
        }

        public ActionResult Operacion()
        {
            OperasBas op = new OperasBas();
            return View(op);
        }
        [HttpPost]
        public ActionResult Operacion(OperasBas op)
        {
            op.Suma();
            return View(op);
        }

        public ActionResult Resta(OperasBas op)
        {
            op.Resta();
            return View(op);
        }
    }
}