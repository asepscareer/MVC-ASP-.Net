using ASPNETMVC.Context;
using ASPNETMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNETMVC.Controllers
{
    public class EmployeesController : Controller
    {
        // GET: Employees
        private MyContext myContext = new MyContext();
        // Read
        public ActionResult Index()
        {
            return View(myContext.employees.ToList());
        }
        public ActionResult Details(int Id)
        {
            return View(myContext.employees.Find(Id));
        }
        // Create
        public ActionResult Creates()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Creates(Employee employee)
        {
            myContext.employees.Add(employee);
            myContext.SaveChanges();
            return RedirectToAction("Index");
        }
        // Delete
        public ActionResult Deletes(int Id)
        {
            return View(myContext.employees.Find(Id));
        }
        [HttpPost]
        public ActionResult Deletes(Employee employee, int Id)
        {
            var delete = myContext.employees.Find(Id);
            myContext.employees.Remove(delete);
            myContext.SaveChanges();
            return RedirectToAction("Index");
        }
        // Updates

    }
}