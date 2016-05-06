using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class RoutingController : Controller
    {
        // GET: Routing
        public ActionResult Index(int? id,int? id2)
        {
            ViewBag.id = id;
            ViewBag.id2 = id2;
            return View();
        }
    }
}