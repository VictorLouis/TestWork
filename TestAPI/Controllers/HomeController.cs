using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestAPI.DAO;
using TestAPI.Factory;

namespace TestAPI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            EmployeeDAO E = null;
            E = new EmployeeDAO();
            var b =E.getEmployees();
            var a = E.getEmployeeList();

            /*
                    EmployeeFactory factory = null;
                    factory = new HourlyEmployeeFactory(10, "pepe");

                    Employee e = factory.GetEmployee();

                    factory = new MonthlyEmployeeFactory(22, "mogu");
                    Employee w = factory.GetEmployee();


                    ViewBag.Message = e.id + e.name + e.contractTypeName + " ----- "+ w.id + w.name + w.contractTypeName; */
            ViewBag.Message = "hello";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}