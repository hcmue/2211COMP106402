using Microsoft.AspNetCore.Mvc;
using TruyenNhanDuLieu.Models;

namespace TruyenNhanDuLieu.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Name = "Action index";
            return View("Show");
        }

        public IActionResult Show()
        {
            ViewData["Name"] = "Action show";
            return View();
        }

        public IActionResult StudentInfo()
        {
            var stdInfo = new Student
            {
                Id = 1,
                Name = "Trần Văn Tèo",
                GPA = 3.92
            };

            return View(stdInfo);
        }

        public IActionResult StudentList()
        {
            var danhSachSV = new List<Student>() {
                new Student
                {
                    Id = 1,
                    Name = "Trần Văn Tèo",
                    GPA = 3.92
                },
                new Student
                {
                    Id = 2,
                    Name = "Lý thánh Tông",
                    GPA = 3.6
                }
            };

            return View(danhSachSV);
        }
    }
}
