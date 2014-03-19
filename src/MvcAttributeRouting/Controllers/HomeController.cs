using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcAttributeRouting.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [Route("sobre")]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [Route("categorias/{categoria}/produtos/{produto}")]
        public string RouteTest(string categoria, string produto)
        {
            return String.Format("Listando o produto {0} da categoria {1}", produto, categoria);
        }
    }
}