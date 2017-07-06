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
    public class WordDatasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public WordDatasController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: WordDatas
        public async Task<IActionResult> Index(int? page)
        {
            var applicationDbContext = _context.WordDatas.Include(w => w.Word);
            int pageSize = 20;
            int pageNumber = (page ?? 1);

            return View(await PaginatedList<WordData>.CreateAsync(applicationDbContext.AsNoTracking(), page ?? 1, pageSize));
            //return View(await applicationDbContext.ToListAsync());
        }

        // GET: WordDatas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wordData = await _context.WordDatas
                .Include(w => w.Word)
                .SingleOrDefaultAsync(m => m.WordDataId == id);
            if (wordData == null)
            {
                return NotFound();
            }

            return View(wordData);
        }

        // GET: WordDatas/Create
        public IActionResult Create()
        {
            ViewData["WordId"] = new SelectList(_context.Words, "WordId", "WordId");
            return View();
        }

        // POST: WordDatas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("WordDataId,Months,WordId,Percentile")] WordData wordData)
        {
            if (ModelState.IsValid)
            {
                _context.Add(wordData);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewData["WordId"] = new SelectList(_context.Words, "WordId", "WordId", wordData.WordId);
            return View(wordData);
        }

        // GET: WordDatas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wordData = await _context.WordDatas.SingleOrDefaultAsync(m => m.WordDataId == id);
            if (wordData == null)
            {
                return NotFound();
            }
            ViewData["WordId"] = new SelectList(_context.Words, "WordId", "WordId", wordData.WordId);
            return View(wordData);
        }

        // POST: WordDatas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("WordDataId,Months,WordId,Percentile")] WordData wordData)
        {
            if (id != wordData.WordDataId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(wordData);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WordDataExists(wordData.WordDataId))
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
            ViewData["WordId"] = new SelectList(_context.Words, "WordId", "WordId", wordData.WordId);
            return View(wordData);
        }

        // GET: WordDatas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wordData = await _context.WordDatas
                .Include(w => w.Word)
                .SingleOrDefaultAsync(m => m.WordDataId == id);
            if (wordData == null)
            {
                return NotFound();
            }

            return View(wordData);
        }

        // POST: WordDatas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var wordData = await _context.WordDatas.SingleOrDefaultAsync(m => m.WordDataId == id);
            _context.WordDatas.Remove(wordData);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool WordDataExists(int id)
        {
            return _context.WordDatas.Any(e => e.WordDataId == id);
        }
    }
}
