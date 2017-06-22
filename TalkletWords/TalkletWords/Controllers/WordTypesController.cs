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
    public class WordTypesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public WordTypesController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: WordTypes
        public async Task<IActionResult> Index()
        {
            return View(await _context.WordTypes.ToListAsync());
        }

        // GET: WordTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wordType = await _context.WordTypes
                .SingleOrDefaultAsync(m => m.WordTypeId == id);
            if (wordType == null)
            {
                return NotFound();
            }

            return View(wordType);
        }

        // GET: WordTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: WordTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("WordTypeId,Name")] WordType wordType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(wordType);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(wordType);
        }

        // GET: WordTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wordType = await _context.WordTypes.SingleOrDefaultAsync(m => m.WordTypeId == id);
            if (wordType == null)
            {
                return NotFound();
            }
            return View(wordType);
        }

        // POST: WordTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("WordTypeId,Name")] WordType wordType)
        {
            if (id != wordType.WordTypeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(wordType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WordTypeExists(wordType.WordTypeId))
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
            return View(wordType);
        }

        // GET: WordTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wordType = await _context.WordTypes
                .SingleOrDefaultAsync(m => m.WordTypeId == id);
            if (wordType == null)
            {
                return NotFound();
            }

            return View(wordType);
        }

        // POST: WordTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var wordType = await _context.WordTypes.SingleOrDefaultAsync(m => m.WordTypeId == id);
            _context.WordTypes.Remove(wordType);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool WordTypeExists(int id)
        {
            return _context.WordTypes.Any(e => e.WordTypeId == id);
        }
    }
}
