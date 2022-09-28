using DemoBuoi04.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DemoBuoi04.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult DongBo()
        {
            var sw = new Stopwatch();
            sw.Start();
            Demo.A();
            Demo.B();
            Demo.C();
            sw.Stop();
            return Json(new { 
                Type = "Sync",
                Total = sw.ElapsedMilliseconds
            });
        }
    }
}
