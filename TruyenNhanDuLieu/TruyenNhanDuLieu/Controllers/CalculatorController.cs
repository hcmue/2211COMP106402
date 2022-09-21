using Microsoft.AspNetCore.Mvc;

namespace TruyenNhanDuLieu.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Calculate(double SoHang01, double SoHang02, string PhepToan)
        {
            ViewBag.SoHang01 = SoHang01;
            ViewBag.SoHang02 = SoHang02;
            ViewBag.PhepToan = PhepToan;
            double ketQua = 0;
            switch (PhepToan)
            {
                case "+": ketQua = SoHang01 + SoHang02; break;
                case "-": ketQua = SoHang01 - SoHang02; break;
                case "*": ketQua = SoHang01 * SoHang02; break;
                case "/": ketQua = SoHang01 / SoHang02; break;
                case "%": ketQua = SoHang01 % SoHang02; break;
                case "^": ketQua = Math.Pow(SoHang01, SoHang02); break;
            }
            ViewBag.KetQua = ketQua;
            return View("Index");
            //return Content($"{SoHang01} {PhepToan} {SoHang02}");
        }
    }
}
