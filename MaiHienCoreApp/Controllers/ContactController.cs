﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MaiHienCoreApp.Controllers
{
    public class ContactController : Controller
    {
        [Route("contact.html")]
        public IActionResult Index()
        {
            return View();
        }
    }
}