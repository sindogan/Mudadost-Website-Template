using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcTemplateProject.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
       
        public ActionResult Hakkimizda()
        {
            return View();
        }
        public ActionResult Ekip()
        {
            return View();
        }
        public ActionResult Etkinlik()
        {
            return View();
        }
        public ActionResult Faaliyetler()
        {
            return View();
        }
        public ActionResult İletisim()
        {
            return View();
        }
        public ActionResult Anasayfa()
        {
            return View();
        }


    }
}