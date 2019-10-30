using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MT200412952.Data;
using MT200412952.Models;

namespace MT200412952.Controllers
{
    public class MidTermsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MidTermsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: MidTerms
        public async Task<IActionResult> Index()
        {
            return View(await _context.MidTerm.ToListAsync());
        }

        // GET: MidTerms/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var midTerm = await _context.MidTerm
                .FirstOrDefaultAsync(m => m.Id == id);
            if (midTerm == null)
            {
                return NotFound();
            }

            return View(midTerm);
        }

        // GET: MidTerms/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MidTerms/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Message,Name,Date")] MidTerm midTerm)
        {
            if (ModelState.IsValid)
            {
                _context.Add(midTerm);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(midTerm);
        }

        // GET: MidTerms/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var midTerm = await _context.MidTerm.FindAsync(id);
            if (midTerm == null)
            {
                return NotFound();
            }
            return View(midTerm);
        }

        // POST: MidTerms/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Message,Name,Date")] MidTerm midTerm)
        {
            if (id != midTerm.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(midTerm);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MidTermExists(midTerm.Id))
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
            return View(midTerm);
        }

        // GET: MidTerms/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var midTerm = await _context.MidTerm
                .FirstOrDefaultAsync(m => m.Id == id);
            if (midTerm == null)
            {
                return NotFound();
            }

            return View(midTerm);
        }

        // POST: MidTerms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var midTerm = await _context.MidTerm.FindAsync(id);
            _context.MidTerm.Remove(midTerm);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MidTermExists(int id)
        {
            return _context.MidTerm.Any(e => e.Id == id);
        }
    }
}
