﻿using Microsoft.AspNetCore.Mvc;

namespace DemoBuoi04.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
