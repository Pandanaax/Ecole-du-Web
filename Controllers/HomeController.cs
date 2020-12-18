using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationEcoleWeb.Controllers
{
    [Authorize(Roles = "Administrateur")]
    public class HomeController : Controller
    {
        [AllowAnonymous]
        [Authorize(Roles = "Stagiaire")]
        public ActionResult Index()
        {
            ViewBag.Message = "Formation.";
            return View();
        }
        
        public ActionResult About()
        {

            ViewBag.Message = "Création de formation.";
            return View();
        }

        [AllowAnonymous]
        public ActionResult Contact()
        {
            
            return View();
        }

    }
}