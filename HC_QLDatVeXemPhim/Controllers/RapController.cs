using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HC_QLDatVeXemPhim.Core;
using HC_QLDatVeXemPhim.Entities;

namespace HC_QLDatVeXemPhim.Controllers
{
    public class RapController : Controller
    {
        private readonly DatVeContext _context;

        public RapController(DatVeContext context)
        {
            _context = context;
        }

        // GET: Rap
        public async Task<IActionResult> Index()
        {
            return View(await _context.Raps.ToListAsync());
        }

        // GET: Rap/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rap = await _context.Raps
                .FirstOrDefaultAsync(m => m.MaRap == id);
            if (rap == null)
            {
                return NotFound();
            }

            return View(rap);
        }

        // GET: Rap/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Rap/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaRap,TenRap,SoChoTrong")] Rap rap)
        {
            if (ModelState.IsValid)
            {
                _context.Add(rap);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(rap);
        }

        // GET: Rap/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rap = await _context.Raps.FindAsync(id);
            if (rap == null)
            {
                return NotFound();
            }
            return View(rap);
        }

        // POST: Rap/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MaRap,TenRap,SoChoTrong")] Rap rap)
        {
            if (id != rap.MaRap)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rap);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RapExists(rap.MaRap))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(rap);
        }

        // GET: Rap/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rap = await _context.Raps
                .FirstOrDefaultAsync(m => m.MaRap == id);
            if (rap == null)
            {
                return NotFound();
            }

            return View(rap);
        }

        // POST: Rap/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var rap = await _context.Raps.FindAsync(id);
            _context.Raps.Remove(rap);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RapExists(int id)
        {
            return _context.Raps.Any(e => e.MaRap == id);
        }
    }
}
