using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestAPI.DTO
{
    public class EmployeeDTO
    {
        public int id { get; set; }
        public string name { get; set; }
        public string contractTypeName { get; set; }
        public string roleId { get; set; }
        public string roleName { get; set; }
        public string roleDescription { get; set; }
        public double hourlySalary { get; set; }
        public double monthlySalary { get; set; }
        public double annualSalary { get; set; }
    }

    public class EmployeeList
    {
        public List<EmployeeDTO> employeeList { get; set; }
    }
}