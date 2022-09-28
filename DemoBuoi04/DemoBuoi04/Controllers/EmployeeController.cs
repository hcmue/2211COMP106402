using Microsoft.AspNetCore.Mvc;

namespace DemoBuoi04.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }
    }
}
