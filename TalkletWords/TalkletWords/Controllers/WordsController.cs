using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TalkletWords.Data;
using TalkletWords.Models;
using PagedList;

namespace TalkletWords.Controllers
{
    public class WordsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public WordsController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Words
        public async Task<IActionResult> Index(string currentFilter, string searchString, bool showAll, int? page)
        {
            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }
            ViewData["CurrentFilter"] = searchString;

            ///IQueryable<Word> words2 = _context.Words;

            var words = from w in _context.Words select w;
            ViewBag.CurrentFilter = searchString;
            if (showAll || String.IsNullOrEmpty(searchString))
            {
                words = words.Include(w => w.Category).Include(w => w.WordType);
            }
            else
            {
                if (!String.IsNullOrEmpty(searchString))
                {
                    words = words.Include(w => w.Category).Include(w => w.WordType).Where(w => w.Definition.Contains(searchString));
                }
                else
                {
                    ///var applicationDbContext = _context.Words.Include(w => w.Category).Include(w => w.WordType);
                    ///return View(await applicationDbContext.ToListAsync());
                    words = words.Include(w => w.Category).Include(w => w.WordType);
                }
            }
            int pageSize = 20;
            int pageNumber = (page ?? 1);

            return View(await PaginatedList<Word>.CreateAsync(words.AsNoTracking(), page ?? 1, pageSize));

        }

        // GET: Words
        public ActionResult WordsInCategory(int? Id)
        {
            var words = from w in _context.Words select w;
            words = words.Include(w => w.Category).Include(w => w.WordType).Where(w=>w.CategoryId == Id);
            return View("WordsInCategory", words);
        }

        // GET: Words
        public ActionResult WordsInWordType(int? Id)
        {
            var words = from w in _context.Words select w;
            words = words.Include(w => w.Category).Include(w => w.WordType).Where(w => w.WordTypeId == Id);
            return View("WordsInWordType", words);
        }

        // GET: Words/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var word = await _context.Words
                .Include(w => w.Category)
                .Include(w => w.WordType)
                .SingleOrDefaultAsync(m => m.WordId == id);
            if (word == null)
            {
                return NotFound();
            }

            return View(word);
        }

        // GET: Words/Create
        public IActionResult Create()
        {
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "Name");
            ViewData["WordTypeId"] = new SelectList(_context.WordTypes, "WordTypeId", "Name");
            return View();
        }

        // POST: Words/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("WordId,Definition,Average,WordTypeId,CategoryId")] Word word)
        {
            if (ModelState.IsValid)
            {
                _context.Add(word);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "Name", word.CategoryId);
            ViewData["WordTypeId"] = new SelectList(_context.WordTypes, "WordTypeId", "Name", word.WordTypeId);
            return View(word);
        }

        // GET: Words/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var word = await _context.Words.SingleOrDefaultAsync(m => m.WordId == id);
            if (word == null)
            {
                return NotFound();
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "Name", word.CategoryId);
            ViewData["WordTypeId"] = new SelectList(_context.WordTypes, "WordTypeId", "Name", word.WordTypeId);
            return View(word);
        }

        // POST: Words/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("WordId,Definition,Average,WordTypeId,CategoryId")] Word word)
        {
            if (id != word.WordId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(word);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WordExists(word.WordId))
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
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "Name", word.CategoryId);
            ViewData["WordTypeId"] = new SelectList(_context.WordTypes, "WordTypeId", "Name", word.WordTypeId);
            return View(word);
        }

        // GET: Words/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var word = await _context.Words
                .Include(w => w.Category)
                .Include(w => w.WordType)
                .SingleOrDefaultAsync(m => m.WordId == id);
            if (word == null)
            {
                return NotFound();
            }

            return View(word);
        }

        // POST: Words/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var word = await _context.Words.SingleOrDefaultAsync(m => m.WordId == id);
            _context.Words.Remove(word);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool WordExists(int id)
        {
            return _context.Words.Any(e => e.WordId == id);
        }
    }
}
