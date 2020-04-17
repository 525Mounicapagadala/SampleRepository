using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GitHub.Models;

namespace GitHub.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Clients obj = new Clients();
            obj.ClientId = 1001;
            obj.ClientName = "Client1";
            return View("ClientsView",obj);
        }
    }
}