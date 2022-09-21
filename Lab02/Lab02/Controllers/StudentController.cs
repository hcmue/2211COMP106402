using Lab02.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace Lab02.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        string TxtFullPath => Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Student.txt");
        string JsonFullPath => Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Student.json");

        [HttpPost]
        public IActionResult Index(Student sinhVien, string buttonLuu)
        {
            if (buttonLuu == "Lưu file JSON")
            {
                var jsonString = JsonSerializer.Serialize(sinhVien);
                System.IO.File.WriteAllText(JsonFullPath, jsonString);
            }
            return View(sinhVien);
        }
    }
}
