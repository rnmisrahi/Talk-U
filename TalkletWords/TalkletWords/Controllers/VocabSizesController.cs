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
    public class VocabSizesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public VocabSizesController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: VocabSizes
        public async Task<IActionResult> Index()
        {
            return View(await _context.VocabSizes.ToListAsync());
        }

        // GET: VocabSizes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vocabSize = await _context.VocabSizes
                .SingleOrDefaultAsync(m => m.VocabSizeId == id);
            if (vocabSize == null)
            {
                return NotFound();
            }

            return View(vocabSize);
        }

        // GET: VocabSizes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: VocabSizes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("VocabSizeId,Age,Vocabulary")] VocabSize vocabSize)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vocabSize);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(vocabSize);
        }

        // GET: VocabSizes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vocabSize = await _context.VocabSizes.SingleOrDefaultAsync(m => m.VocabSizeId == id);
            if (vocabSize == null)
            {
                return NotFound();
            }
            return View(vocabSize);
        }

        // POST: VocabSizes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("VocabSizeId,Age,Vocabulary")] VocabSize vocabSize)
        {
            if (id != vocabSize.VocabSizeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vocabSize);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VocabSizeExists(vocabSize.VocabSizeId))
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
            return View(vocabSize);
        }

        // GET: VocabSizes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vocabSize = await _context.VocabSizes
                .SingleOrDefaultAsync(m => m.VocabSizeId == id);
            if (vocabSize == null)
            {
                return NotFound();
            }

            return View(vocabSize);
        }

        // POST: VocabSizes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vocabSize = await _context.VocabSizes.SingleOrDefaultAsync(m => m.VocabSizeId == id);
            _context.VocabSizes.Remove(vocabSize);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool VocabSizeExists(int id)
        {
            return _context.VocabSizes.Any(e => e.VocabSizeId == id);
        }
    }
}
