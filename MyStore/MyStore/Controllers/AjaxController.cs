using Microsoft.AspNetCore.Mvc;
using MyStore.Data;
using MyStore.Models;

namespace MyStore.Controllers
{
    public class AjaxController : Controller
    {
        private readonly MyeStoreK4602Context _context;

        public AjaxController(MyeStoreK4602Context ctx)
        {
            _context = ctx;
        }

        public IActionResult MyPage()
        {
            return View();
        }

        [HttpPost]
        public string ServerTime()
        {
            return DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        #region LoadMore
        public IActionResult SanPham()
        {
            ViewBag.TongSoTrang = (int) Math.Ceiling(_context.HangHoas.Count() * 1.0 / SO_SAN_PHAM_MOI_TRANG);
            return View();
        }

        const int SO_SAN_PHAM_MOI_TRANG = 7;
        public IActionResult LaySanPham(int page = 1)
        {
            var data = _context.HangHoas
                    .Skip((page - 1) * SO_SAN_PHAM_MOI_TRANG)
                    .Take(SO_SAN_PHAM_MOI_TRANG)
                    .Select(p => new HangHoaVM {
                        MaHh = p.MaHh,
                        TenHh = p.TenHh,
                        Hinh = p.Hinh,
                        DonGia = p.DonGia,
                        NgaySx = p.NgaySx,
                        Loai = p.MaLoaiNavigation.TenLoai
                    }).ToList();
            return PartialView(data);
        }
        #endregion
    }
}
