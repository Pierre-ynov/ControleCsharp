using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Venezia.Data;
using Venezia.Models;

namespace Venezia.Controllers
{
    public class AccountsController : Controller
    {
        private readonly VeneziaContext _context;

        private readonly UserManager<AccountUser> _manage;

        public AccountsController(VeneziaContext context, UserManager<AccountUser> userManage)
        {
            _context = context;
            _manage = userManage;
        }

        [HttpGet]
        [Route("login", Name = "Login")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [Route("login", Name = "Login")]
        public async Task<IActionResult> Login(string UserName, string PasswordHash)
        {
            if (UserName == null || PasswordHash == null)
            {
                return RedirectToRoute("~/");
            }

            if (ModelState.IsValid)
            {
                var result = await _manage.FindByNameAsync(UserName);
                if (result!=null)
                {
                    var verif = await _manage.CheckPasswordAsync(result, PasswordHash);
                    if (verif)
                    {
                        return RedirectToRoute("~/");
                    }
                }
            }
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
        public async Task<IActionResult> Register([Bind("UserName", "Email", "PasswordHash")] AccountUser account)
        {
            if (ModelState.IsValid)
            {
                var result = await _manage.CreateAsync(account);
                if (result.Succeeded)
                {
                    return RedirectToRoute("~/");
                }
            }
            return View();
        }

        [HttpGet]
        [Route("logout", Name = "Logout")]
        public IActionResult Logout(string UserName)
        {

            return View();
        }
    }
}
