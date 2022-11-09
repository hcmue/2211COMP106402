using Microsoft.AspNetCore.Mvc;

namespace MyStore.Controllers
{
    public class AjaxController : Controller
    {
        public IActionResult MyPage()
        {
            return View();
        }

        [HttpPost]
        public string ServerTime()
        {
            return DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }
    }
}
