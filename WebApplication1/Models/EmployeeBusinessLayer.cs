using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class EmployeeBusinessLayer
    {
        public List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            Employee emp = new Employee();
            emp.FirstName = "andy";
            emp.LastName = "qian";
            emp.Salary = 14000;
            employees.Add(emp);

            emp = new Employee();
            emp.FirstName = "qiumegn"
;
            emp.LastName = "wan";
            emp.Salary = 40000;
            employees.Add(emp);

            emp = new Employee();
            emp.FirstName = "tingting";
            emp.LastName = "wan";
            emp.Salary = 50000;
            employees.Add(emp);





                 return employees;
        }
    }
}