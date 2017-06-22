using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TalkletWords.Data;
using TalkletWords.Models;

namespace TalkletWords.Controllers
{
    public class MLUsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MLUsController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: MLUs
        public async Task<IActionResult> Index()
        {
            return View(await _context.MLUs.ToListAsync());
        }

        // GET: MLUs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mLU = await _context.MLUs
                .SingleOrDefaultAsync(m => m.MLUId == id);
            if (mLU == null)
            {
                return NotFound();
            }

            return View(mLU);
        }

        // GET: MLUs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MLUs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MLUId,Age,MLUFrom,MLUTo")] MLU mLU)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mLU);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(mLU);
        }

        // GET: MLUs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mLU = await _context.MLUs.SingleOrDefaultAsync(m => m.MLUId == id);
            if (mLU == null)
            {
                return NotFound();
            }
            return View(mLU);
        }

        // POST: MLUs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MLUId,Age,MLUFrom,MLUTo")] MLU mLU)
        {
            if (id != mLU.MLUId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mLU);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MLUExists(mLU.MLUId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(mLU);
        }

        // GET: MLUs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mLU = await _context.MLUs
                .SingleOrDefaultAsync(m => m.MLUId == id);
            if (mLU == null)
            {
                return NotFound();
            }

            return View(mLU);
        }

        // POST: MLUs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var mLU = await _context.MLUs.SingleOrDefaultAsync(m => m.MLUId == id);
            _context.MLUs.Remove(mLU);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool MLUExists(int id)
        {
            return _context.MLUs.Any(e => e.MLUId == id);
        }
    }
}
