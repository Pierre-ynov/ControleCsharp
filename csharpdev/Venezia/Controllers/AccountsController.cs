using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Venezia.Data;
using Venezia.Models;

namespace Venezia.Controllers
{
    public class AccountsController : Controller
    {
        private readonly VeneziaContext _context;

        public AccountsController(VeneziaContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("login", Name = "Login")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [Route("login", Name = "Login")]
        public IActionResult Login(string UserName, string PasswordHash)
        {
            return View();
        }

        [HttpGet]
        [Route("register", Name = "Register")]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [Route("register", Name = "Register")]
        public IActionResult Register([Bind("UserName","Email","PasswordHash")] AccountUser account)
        {
            return View();
        }

        [HttpGet]
        [Route("logout", Name = "Logout")]
        public IActionResult Logout()
        {
            return View();
        }
    }
}
