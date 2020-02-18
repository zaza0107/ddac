using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ddac.Models;

namespace ddac.Views
{
    public class BeautynSpasController : Controller
    {
        private readonly ddacContext _context;

        public BeautynSpasController(ddacContext context)
        {
            _context = context;
        }

        // GET: BeautynSpas
        public async Task<IActionResult> Index()
        {
            return View(await _context.BeautynSpa.ToListAsync());
        }

        // GET: BeautynSpas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var beautynSpa = await _context.BeautynSpa
                .FirstOrDefaultAsync(m => m.Bid == id);
            if (beautynSpa == null)
            {
                return NotFound();
            }

            return View(beautynSpa);
        }

        // GET: BeautynSpas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BeautynSpas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Bid,BeautyName,BeautyPrice,BQty")] BeautynSpa beautynSpa)
        {
            if (ModelState.IsValid)
            {
                _context.Add(beautynSpa);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(beautynSpa);
        }

        // GET: BeautynSpas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var beautynSpa = await _context.BeautynSpa.FindAsync(id);
            if (beautynSpa == null)
            {
                return NotFound();
            }
            return View(beautynSpa);
        }

        // POST: BeautynSpas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Bid,BeautyName,BeautyPrice,BQty")] BeautynSpa beautynSpa)
        {
            if (id != beautynSpa.Bid)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(beautynSpa);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BeautynSpaExists(beautynSpa.Bid))
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
            return View(beautynSpa);
        }

        // GET: BeautynSpas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var beautynSpa = await _context.BeautynSpa
                .FirstOrDefaultAsync(m => m.Bid == id);
            if (beautynSpa == null)
            {
                return NotFound();
            }

            return View(beautynSpa);
        }

        // POST: BeautynSpas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var beautynSpa = await _context.BeautynSpa.FindAsync(id);
            _context.BeautynSpa.Remove(beautynSpa);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BeautynSpaExists(int id)
        {
            return _context.BeautynSpa.Any(e => e.Bid == id);
        }
    }
}
