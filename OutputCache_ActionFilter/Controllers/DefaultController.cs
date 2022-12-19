using OutputCache_ActionFilter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OutputCache_ActionFilter.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        [OutputCache(Duration = 10, VaryByParam = "none")]
        public ActionResult Index()
        {
            DemoDBEntities db = new DemoDBEntities();
            var Employees = db.Employees.ToList();
            return View(Employees);
        }
    }
}