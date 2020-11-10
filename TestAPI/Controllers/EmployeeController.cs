using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestAPI.DAO;
using TestAPI.DTO;
using TestAPI.Factory;
using TestAPI.Models;

namespace TestAPI.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult displayEmployees()
        {
            EmployeeDAO E = null;
            E = new EmployeeDAO();

            var eList = E.getEmployeeList();

            foreach (EmployeeDTO item in eList)
            {
                if (item.contractTypeName == "HourlySalaryEmployee")
                {
                    item.annualSalary = 120 * item.hourlySalary * 12;
                }
                else
                {
                    item.annualSalary = item.monthlySalary * 12;
                }
            }

            return View(eList);

        }

        public ActionResult getEmployee(int id)
        {
            EmployeeDAO E = null;
            E = new EmployeeDAO();
            EmployeeDTO xy = null;
            var eList = E.getEmployeeList();

            foreach(EmployeeDTO item in eList)
            {
                if(item.id == id)
                {
                    xy = item;
                }
            }

            if(xy.contractTypeName == "HourlySalaryEmployee")
            {
                EmployeeFactory factory = null;
                double annual = 120 * xy.hourlySalary * 12;
                factory = new HourlyEmployeeFactory(xy.id, xy.name, xy.contractTypeName, annual);

                var e = factory.GetEmployee();

                EmployeeModel model = new EmployeeModel();
                model.id = e.id;
                model.name = e.name;
                model.contractTypeName = e.contractTypeName;
                model.annualSalary = e.annualSalary;
                return View(model);
            }
            else
            {
                EmployeeFactory factory = null;
                double annual = xy.monthlySalary * 12;
                factory = new MonthlyEmployeeFactory(xy.id, xy.name, xy.contractTypeName, annual);

                var e =  factory.GetEmployee();

                EmployeeModel model = new EmployeeModel();
                model.id = e.id;
                model.name = e.name;
                model.contractTypeName = e.contractTypeName;
                model.annualSalary = e.annualSalary;
                return View(model);
            }

        }
    }
}