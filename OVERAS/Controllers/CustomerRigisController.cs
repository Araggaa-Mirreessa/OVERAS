using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OVERAS.Models;
namespace OVERAS.Controllers
{
    public class CustomerRigisController : Controller
    {
        private readonly CustomerDB cd;
        public CustomerRigisController(CustomerDB _cd)
        {
            cd = _cd;

        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(customert c)
        {
            cd.Add(c);
            cd.SaveChanges();
            ViewBag.message = "Data has Secess Fully Registared";
            return View();
        }
        [HttpGet]
        public IActionResult ShowCustomers()
        {
            return View();
        }
        public IActionResult ShowCustomers(customert c)
        {
            var cust = c.ToString();
            cd.SaveChanges();
            return View(cust);
        }


           }
    }

/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OVERS.Models;
namespace OVERS.Controllers
{
    public class CustomerRegistrationController : Controller
    {
        private readonly CustomerDB cd;
        public CustomerRegistrationController(CustomerDB _cd)
        {
            cd = _cd;
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Customer c)
        {
            cd.Add(c);
            cd.SaveChanges();
            return View();

            //VieweBag
        }

    }
}
*/