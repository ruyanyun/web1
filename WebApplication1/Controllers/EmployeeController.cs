﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult SaveEmployee (Employee e,string BtnSubmit)
        {
            switch (BtnSubmit)
            {
                case "Save Employee":
                    return Content(e.FirstName + "|" + e.LastName + "|" + e.Salary);
                case "Cancel":
                    return RedirectToAction("Index");
            }
            return new EmptyResult();
        }
        public string GetString()
        {
            return "Hello World is old now. It's time for wassup bro;";
        }
        public ActionResult AddNew()
        {
            return View("CreateEmployee");
        }

        public ActionResult Index()

        {

            EmployeeListViewModel employeeListViewModel = new EmployeeListViewModel();

            EmployeeBusinessLayer empBal = new EmployeeBusinessLayer();
            List<Employee> employees = empBal.GetEmployees();

            List<EmployeeViewModel> empViewModels = new List<EmployeeViewModel>();

            foreach (Employee emp in employees)
            {
                EmployeeViewModel empViewModel = new EmployeeViewModel();
                empViewModel.EmployeeName = emp.FirstName + "" + emp.LastName;
                empViewModel.Salary = emp.Salary.ToString("C");
                if (emp.Salary > 15000)
                {
                    empViewModel.SalaryColor = "yellow";

                }
                else
                {
                    empViewModel.SalaryColor = "green";
                }
                empViewModels.Add(empViewModel);


            }
            employeeListViewModel.Employees = empViewModels;
            


            return View("Index", employeeListViewModel);



        }

    }
}