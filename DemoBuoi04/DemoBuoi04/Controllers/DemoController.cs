using DemoBuoi04.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DemoBuoi04.Controllers
{
    public class DemoController : Controller
    {
        public string TetSapDen()
        {
            var soNgay = DateTime.Now.DemSoNgay(new DateTime(2023, 1, 21));
            return $"Còn {soNgay} nữa đến Tết";
        }
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

        public async Task<IActionResult> BatDongBo()
        {
            var sw = new Stopwatch();
            sw.Start();
            var a = Demo.AAsync();
            var b = Demo.BAsync();
            var c = Demo.CAsync();
            await a; await b; await c;
            sw.Stop();
            return Json(new
            {
                Type = "Async",
                Total = sw.ElapsedMilliseconds
            });
        }
    }
}
