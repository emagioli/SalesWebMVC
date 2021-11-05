using Microsoft.AspNetCore.Mvc;
using SalesWebMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMVC.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> departmentsList = new List<Department>();
            departmentsList.Add(new Department { Id = 1, Name = "Eletronics"});
            departmentsList.Add(new Department { Id = 2, Name = "Toys"});
            departmentsList.Add(new Department { Id = 3, Name = "Beverages"});
            
            return View(departmentsList);
        }
    }
}
