using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SitioWebCompletoParte_1.Controllers
{
    public class HomeAdminController : Controller
    {
        // GET: HomeAdmin
        public ActionResult Home()
        {
            ViewBag.encabezado = "Bienvenido Administrador";
            return View();
        }
    }
}