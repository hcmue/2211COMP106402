using Microsoft.AspNetCore.Mvc;
using MyStore.Data;
using MyStore.Models;

namespace MyStore.Controllers
{
    public class DemoController : Controller
    {
        private readonly MyeStoreK4602Context _context;

        public DemoController(MyeStoreK4602Context context)
        {
            _context = context;
        }

        public IActionResult Search()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Search(string? Keyword, double? From, double? To)
        {
            //var data = _context.HangHoas.Where(hh => hh.TenHh.Contains(Keyword) && hh.DonGia >= From && hh.DonGia <= To);
            var data = _context.HangHoas.AsQueryable();
            if (Keyword != null)
            {
                data = data.Where(hh => hh.TenHh.Contains(Keyword));
            }
            if (From != null)
            {
                data = data.Where(hh => hh.DonGia >= From);
            }
            if (To != null)
            {
                data = data.Where(hh => hh.DonGia <= To);
            }
            var result = data.Select(p => new HangHoaVM
            {
                MaHh = p.MaHh,
                TenHh = p.TenHh,
                DonGia = p.DonGia,
                NgaySx = p.NgaySx,
                Loai = p.MaLoaiNavigation.TenLoai
            }).ToList();
            return View(result);
        }

        public IActionResult ThongKe()
        {
            var data = _context.ChiTietHds
                .GroupBy(p => p.MaHhNavigation.MaLoaiNavigation.TenLoai)
                .Select(g => new ThongKeTheoLoaiVM
                {
                    Loai = g.Key,
                    DoanhThu = g.Sum(cthd => cthd.SoLuong * cthd.DonGia),
                    GiaCaoNhat = g.Max(cthd => cthd.DonGia),
                    GiaThapNhat = g.Min(cthd => cthd.DonGia),
                    GiaTrungBinh = g.Average(cthd => cthd.DonGia),
                });
            return View(data);
        }
    }
}
