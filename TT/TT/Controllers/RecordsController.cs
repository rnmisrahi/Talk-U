using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TT.Data;
using TT.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using System.Globalization;

namespace TT.Controllers
{
    [Authorize]
    public class RecordsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RecordsController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Records
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Records.Include(r => r.Task);
            return View(await applicationDbContext.ToListAsync());
        }

        public async Task<IActionResult> MyTasks()
        {
            string currentUser = User.Identity.Name; ///Great! Finally. such a simple solution!
            var records = _context.Records.Where(r => r.UserName == currentUser);
            var applicationDbContext = records.Include(r => r.Task);
            return View("Index", await applicationDbContext.ToListAsync());
        }

        public async Task<IActionResult> ActiveUsers()
        {
            var records = _context.Records.Where(r => r.IsActive == true);
            var applicationDbContext = records.Include(r => r.Task);
            return View("Index", await applicationDbContext.ToListAsync());
        }

        // GET: Records/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var record = await _context.Records
                .Include(r => r.Task)
                .SingleOrDefaultAsync(m => m.RecordId == id);
            if (record == null)
            {
                return NotFound();
            }

            return View(record);
        }

        private DateTime localDateTime()
        {
            DateTime utc = DateTime.UtcNow;
            TimeZoneInfo IsraelZone = TimeZoneInfo.FindSystemTimeZoneById("Israel Standard Time");
            DateTime localTime = TimeZoneInfo.ConvertTime(utc, IsraelZone);
            return localTime;
        }

        // GET: Records/Create
        public IActionResult Create()
        {
            string currentUser = User.Identity.Name; ///Great! Finally. such a simple solution!
            bool isActive = false;
            Record lastRecord = null;
            if ((_context.Records != null) && (_context.Records.Count() > 0))
            {
                var recs = _context.Records.Where(r => r.UserName == currentUser);
                if (recs.Count() > 0)
                {
                    lastRecord = recs.Last();
                    isActive = lastRecord.IsActive;
                }
                else
                    isActive = false;
            }
            if (isActive)
            {
                //TempData["LastRecord"] = lastRecord;
                return RedirectToAction("Finish", new { id = lastRecord.RecordId });
            }
            else
            {
                ViewData["TrackId"] = new SelectList(_context.Tracks, "TrackId", "Name");
                var record = new Record();
                record.TaskStart = localDateTime();
                return View(record);
            }
        }

        // POST: Records/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RecordId,UserName,TrackId,Description,TaskStart,TaskEnd")] Record record)
        {
            if (ModelState.IsValid)
            {
                _context.Add(record);
                await _context.SaveChangesAsync();
                return RedirectToAction("MyTasks");
            }
            ViewData["TrackId"] = new SelectList(_context.Tracks, "TrackId", "Name", record.TrackId);
            return RedirectToAction("Index");
            //return View(record);
        }

        // GET: Records/Finish/5
        public async Task<IActionResult> Finish(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var record = await _context.Records.SingleOrDefaultAsync(m => m.RecordId == id);
            if (record == null)
            {
                return NotFound();
            }
            if (record.IsActive)
            {
                record.TaskEnd = localDateTime();
                //record.TaskEnd = DateTime.Now;
            }
            ViewData["TrackId"] = new SelectList(_context.Tracks, "TrackId", "Name", record.TrackId);
            return View("Finish", record);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Finish(int id, [Bind("RecordId,UserName,TrackId,Description,TaskStart,TaskEnd")] Record record)
        {
            if (id != record.RecordId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(record);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RecordExists(record.RecordId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("MyTasks");
            }
            ViewData["TrackId"] = new SelectList(_context.Tracks, "TrackId", "Name", record.TrackId);
            return View(record);
        }

        // GET: Records/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var record = await _context.Records.SingleOrDefaultAsync(m => m.RecordId == id);
            if (record == null)
            {
                return NotFound();
            }
            if (record.IsActive)
            {
                record.TaskEnd = DateTime.Now;
            }
            ViewData["TrackId"] = new SelectList(_context.Tracks, "TrackId", "Name", record.TrackId);
            return View(record);
        }

        // POST: Records/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RecordId,UserName,TrackId,Description,TaskStart,TaskEnd")] Record record)
        {
            if (id != record.RecordId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(record);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RecordExists(record.RecordId))
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
            ViewData["TrackId"] = new SelectList(_context.Tracks, "TrackId", "Name", record.TrackId);
            return View(record);
        }

        // GET: Records/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var record = await _context.Records
                .Include(r => r.Task)
                .SingleOrDefaultAsync(m => m.RecordId == id);
            if (record == null)
            {
                return NotFound();
            }

            return View(record);
        }

        // POST: Records/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var record = await _context.Records.SingleOrDefaultAsync(m => m.RecordId == id);
            _context.Records.Remove(record);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool RecordExists(int id)
        {
            return _context.Records.Any(e => e.RecordId == id);
        }
    }
}
