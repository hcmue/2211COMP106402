using Microsoft.AspNetCore.Mvc;

namespace Lab02.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
