using DemoBuoi04.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoBuoi04.Controllers
{
    public class EmployeeController : Controller
    {
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
