using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCustomExceptionFilter.CustomFilter;
using MvcCustomExceptionFilter.Models;

namespace MvcCustomExceptionFilter.Controllers
{
    public class HomeController : Controller
    {
        private readonly EmployeeContext _dbContext = new EmployeeContext();

        public ActionResult Index()
        {
            var employee = _dbContext.Employees.ToList();
            return View(employee);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [CustomExceptionHandlerFilter]
        public ActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                if (employee.Position == "Software Engineer" && (employee.Salary < 50000 || employee.Salary > 80000))
                {
                    throw new Exception("Salary is not matching with Software Engineer position.");
                }
                else if (employee.Position == "Accountant" && (employee.Salary < 40000 || employee.Salary > 50000))
                {
                    throw new Exception("Salary is not matching with Accountant position.");
                }
                else if (employee.Position == "Senior Sales Executive")
                {
                    throw new Exception("Salary is not matching with Senior Sales Executive position.");
                }
                else
                {
                    _dbContext.Employees.Add(employee);
                    _dbContext.SaveChanges();
                }
            }
            return RedirectToAction("Index");
        }
    }
}