using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyStore.Data;
using MyStore.Models;
using System.Security.Claims;

namespace MyStore.Controllers
{
    [Authorize]
    public class KhachHangController : Controller
    {
        private readonly MyeStoreK4602Context _ctx;

        public KhachHangController(MyeStoreK4602Context context)
        {
            _ctx = context;
        }

        [AllowAnonymous]
        [HttpGet("/Login")]
        public IActionResult Login(string ReturnUrl = null)
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost("/Login")]
        public async Task<IActionResult> Login(LoginVM model, string ReturnUrl = null)
        {
            var kh = _ctx.KhachHangs.SingleOrDefault(p => p.MaKh == model.UserName && p.MatKhau == model.Password);
            if (kh == null)
            {
                ViewBag.ErrorMessage = "Invalid username/password";
                ViewBag.ReturnUrl = ReturnUrl;
                return View();
            }

            //Tạo claim
            //Claims
            var claims = new List<Claim> {
                    new Claim(ClaimTypes.Email, kh.Email),
                    new Claim(ClaimTypes.Name, kh.HoTen),
                    new Claim("ID", kh.MaKh),
                    new Claim(ClaimTypes.Role, "Admin"),
                };


            //cookies
            var claimsIdentity = new ClaimsIdentity(
        claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var claimPrincipal = new ClaimsPrincipal(claimsIdentity);
            await HttpContext.SignInAsync(claimPrincipal);

            if (ReturnUrl != null && Url.IsLocalUrl(ReturnUrl))
            {
                return Redirect(ReturnUrl);
            }
            else
            {
                return Redirect("/Home");
            }
        }

        [HttpGet("/Logout")]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return Redirect("/Home");
        }
    }
}
