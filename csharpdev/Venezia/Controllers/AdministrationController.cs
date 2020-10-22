using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Venezia.Models;

namespace Venezia.Controllers
{
    [Area("Administration")]
    public class AdministrationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CreateUser()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateUser(AccountUser account)
        {
            return View();
        }

        [HttpGet]
        public IActionResult UpdateUser()
        {
            return View();
        }

        [HttpPost]
        public IActionResult UpdateUser(AccountUser account)
        {
            return View();
        }

        [HttpGet]
        public IActionResult deleteUser(int ID)
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddRoleUser(int ID, string role)
        {
            return View();
        }

        [HttpPost]
        public IActionResult RemoveRoleUser(int ID, string role)
        {
            return View();
        }
    }
}
