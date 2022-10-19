using DemoBuoi04.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoBuoi04.ViewComponents
{
    public class CategoryViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            // đọc data động từ...
            var data = new List<CategoryModel> { 
                new CategoryModel{Id = 1, Name = "Laptop"},
                new CategoryModel{Id = 2, Name = "Tablet"},
                new CategoryModel{Id = 3, Name = "Phone"}
            };

            return View(data);
        }
    }
}
