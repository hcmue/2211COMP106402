using DemoBuoi04.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoBuoi04.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult DangKyThanhVien()
        {
            return View();
        }

        public IActionResult DangKy()
        {
            return View();
        }

        public IActionResult KiemTraMaNVTrung(string EmployeeNo)
        {
            var dsNhanVien = new string[] { "admin", "7777", "account"};
            if (dsNhanVien.Contains(EmployeeNo))
            {
                return Json($"Mã {EmployeeNo} đã có");
            }
            return Json(true);
        }
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(Employee model)
        {
            if (ModelState.IsValid)
            {
                // TODO: Save database
            }
            else
            {
                ModelState.AddModelError("loi", "Server chưa hợp lệ");
            }
            return View();
        }
    }
}
