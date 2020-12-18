using HC_QLDatVeXemPhim.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HC_QLDatVeXemPhim.Core;
using HC_QLDatVeXemPhim.Entities;

namespace HC_QLDatVeXemPhim.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly DatVeContext _context;

        public HomeController(ILogger<HomeController> logger, DatVeContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            ViewData["phims"] = await _context.Phims.ToListAsync();

            ViewData["raps"] = await _context.Raps.ToListAsync();

            ViewData["lichchieus"] = await _context.LichChieuPhims
                .Include(l => l.Phim)
                .Include(l => l.Rap)
                .ToListAsync();

            return View();
        }

        public IActionResult DatVe()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
