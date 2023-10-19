using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NewsLetter6.Data;
using NewsLetter6.Models;
using Microsoft.AspNetCore.Authorization;

namespace NewsLetter6.Controllers
{
    //[Authorize]
    public class TitlesController : Controller
    {
        private readonly NewsLetterContext _context;

        public TitlesController(NewsLetterContext context)
        {
            _context = context;
        }

        //GET: Titles
        public async Task<IActionResult> Index()
        {
             return _context.Titles != null ? 
                View(await _context.Titles
                    .Include(a => a.Articles)
                    .Where(title=>title.IsActive==true)
                    .OrderByDescending(title => title.TitleId)
                    //.ThenByDescending(title => title.Articles!.Max(article => article.ArticleId))
                    .ToListAsync()) :
                Problem("Entity set 'NewsLetterContext.Titles' is null.");

        }

         //GET: UpdateIndex
        public async Task<IActionResult> IndexUpdate()
        {
             return _context.Titles != null ? 
                View(await _context.Titles
                    .Include(a => a.Articles)
                    .Where(title=>title.IsActive==true)
                    .OrderByDescending(title => title.TitleId)
                    //.ThenByDescending(title => title.Articles!.Max(article => article.ArticleId))
                    .ToListAsync()) :
                Problem("Entity set 'NewsLetterContext.Titles' is null.");

        }

        // GET: Titles/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Titles == null)
            {
                return NotFound();
            }

            var newsLetterTitle = await _context.Titles
                .FirstOrDefaultAsync(m => m.TitleId == id);
            if (newsLetterTitle == null)
            {
                return NotFound();
            }

            return View(newsLetterTitle);
        }

        // GET: Titles/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Titles/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TitleId,TitleDate,IsActive")] NewsLetterTitle newsLetterTitle)
        {
            if (ModelState.IsValid)
            {
                _context.Add(newsLetterTitle);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(newsLetterTitle);
        }

        // GET: Titles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Titles == null)
            {
                return NotFound();
            }

            var newsLetterTitle = await _context.Titles.FindAsync(id);
            if (newsLetterTitle == null)
            {
                return NotFound();
            }
            return View(newsLetterTitle);
        }

        // POST: Titles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TitleId,TitleDate,IsActive")] NewsLetterTitle newsLetterTitle)
        {
            if (id != newsLetterTitle.TitleId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(newsLetterTitle);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NewsLetterTitleExists(newsLetterTitle.TitleId))
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
            return View(newsLetterTitle);
        }

        // GET: Titles/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Titles == null)
            {
                return NotFound();
            }

            var newsLetterTitle = await _context.Titles
                .FirstOrDefaultAsync(m => m.TitleId == id);
            if (newsLetterTitle == null)
            {
                return NotFound();
            }

            return View(newsLetterTitle);
        }

        // POST: Titles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Titles == null)
            {
                return Problem("Entity set 'NewsLetterContext.Titles'  is null.");
            }
            var newsLetterTitle = await _context.Titles.FindAsync(id);
            if (newsLetterTitle != null)
            {
                _context.Titles.Remove(newsLetterTitle);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NewsLetterTitleExists(int id)
        {
          return (_context.Titles?.Any(e => e.TitleId == id)).GetValueOrDefault();
        }
    }
}
