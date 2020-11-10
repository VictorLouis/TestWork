using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestAPI.Factory
{
    abstract class Employee
    {
        public abstract int id { get; set; }
        public abstract string name { get; set; }
        public abstract string contractTypeName { get; set; }
        public abstract string roleId { get; set; }
        public abstract string roleName { get; set; }
        public abstract string roleDescription { get; set; }
        public abstract double hourlySalary { get; set; }
        public abstract double monthlySalary { get; set; }
        public abstract double annualSalary { get; set; }

    }

    class HourlyEmployee : Employee
    {
        private int _id { get; set; }
        private string _name { get; set; }
        private string _contractTypeName { get; set; }
        private string _roleId { get; set; }
        private string _roleName { get; set; }
        private string _roleDescription { get; set; }
        private double _hourlySalary { get; set; }
        private double _monthlySalary { get; set; }
        private double _annualSalary { get; set; }

        public HourlyEmployee(int id, string name, string contractType, double annualSalary)
        {
            _id = id;
            _name = name;
            _contractTypeName = contractType;
            _annualSalary = annualSalary;

        }

        public override int id
        {
            get { return _id; }
            set { _id = value; }
        }

        public override string name
        {
            get { return _name; }
            set { _name = value; }
        }

        public override string contractTypeName
        {
            get { return _contractTypeName; }
            set { _contractTypeName = value; }
        }

        public override string roleId
        {
            get { return _roleId; }
            set { _roleId = value; }
        }

        public override string roleName
        {
            get { return _roleName; }
            set { _roleName = value; }
        }

        public override string roleDescription
        {
            get { return _roleDescription; }
            set { _roleDescription = value; }
        }

        public override double hourlySalary
        {
            get { return _hourlySalary; }
            set { _hourlySalary = value; }
        }

        public override double monthlySalary
        {
            get { return _monthlySalary; }
            set { _monthlySalary = value; }
        }

        public override double annualSalary
        {
            get { return _annualSalary; }
            set { _annualSalary = value; }
        }

    }

    //DTO

    class MonthlyEmployee : Employee
    {
        private int _id { get; set; }
        private string _name { get; set; }
        private string _contractTypeName { get; set; }
        private string _roleId { get; set; }
        private string _roleName { get; set; }
        private string _roleDescription { get; set; }
        private double _hourlySalary { get; set; }
        private double _monthlySalary { get; set; }
        private double _annualSalary { get; set; }

        public MonthlyEmployee(int id, string name, string contractType, double annualSalary)
        {
            _id = id;
            _name = name;
            _contractTypeName = contractType;
            _annualSalary = annualSalary;

        }

        public override int id
        {
            get { return _id; }
            set { _id = value; }
        }

        public override string name
        {
            get { return _name; }
            set { _name = value; }
        }

        public override string contractTypeName
        {
            get { return _contractTypeName; }
            set { _contractTypeName = value; }
        }

        public override string roleId
        {
            get { return _roleId; }
            set { _roleId = value; }
        }

        public override string roleName
        {
            get { return _roleName; }
            set { _roleName = value; }
        }

        public override string roleDescription
        {
            get { return _roleDescription; }
            set { _roleDescription = value; }
        }

        public override double hourlySalary
        {
            get { return _hourlySalary; }
            set { _hourlySalary = value; }
        }

        public override double monthlySalary
        {
            get { return _monthlySalary; }
            set { _monthlySalary = value; }
        }

        public override double annualSalary
        {
            get { return _annualSalary; }
            set { _annualSalary = value; }
        }

    }

    /// <summary>  
    /// The 'Creator' Abstract Class  
    /// </summary>  
    abstract class EmployeeFactory
    {
        public abstract Employee GetEmployee();
    }

    /// <summary>  
    /// A 'ConcreteCreator' class  
    /// </summary>  
    class HourlyEmployeeFactory : EmployeeFactory
    {
        private int _id;
        private string _name;
        private string _contractTypeName;
        private double _annualSalary;

        public HourlyEmployeeFactory(int id, string name, string contractType, double annualSalary)
        {
            _id = id;
            _name = name;
            _contractTypeName = contractType;
            _annualSalary = annualSalary;

        }

        public override Employee GetEmployee()
        {
            return new HourlyEmployee(_id, _name, _contractTypeName, _annualSalary);
        }
    }

    /// <summary>  
    /// A 'ConcreteCreator' class  
    /// </summary>  
    class MonthlyEmployeeFactory : EmployeeFactory
    {
        private int _id;
        private string _name;
        private string _contractTypeName;
        private double _annualSalary;

        public MonthlyEmployeeFactory(int id, string name, string contractType, double annualSalary)
        {
            _id = id;
            _name = name;
            _contractTypeName = contractType;
            _annualSalary = annualSalary;
        }

        public override Employee GetEmployee()
        {
            return new MonthlyEmployee(_id, _name, _contractTypeName, _annualSalary);
        }
    }
}