﻿using Microsoft.AspNetCore.Mvc;

namespace MVC_Proj_1.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult SignIn()
        {
            return View();
        }

        public IActionResult SignUp()
        {
            return View();
        }
    }
}