using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NewsLetter6.Data;
using NewsLetter6.Models;

namespace NewsLetter6.Controllers
{
    public class ArticlesController : Controller
    {
        private readonly NewsLetterContext _context;

        public ArticlesController(NewsLetterContext context)
        {
            _context = context;
        }

        // GET: Articles
        public async Task<IActionResult> Index()
        {
            var newsLetterContext = _context.Articles!.Include(n => n.NewsletterTitle);
            return View(await newsLetterContext.ToListAsync());
        }

        // GET: Articles/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Articles == null)
            {
                return NotFound();
            }

            var newsletterArticle = await _context.Articles
                .Include(n => n.NewsletterTitle)
                .FirstOrDefaultAsync(m => m.ArticleId == id);
            if (newsletterArticle == null)
            {
                return NotFound();
            }

            return View(newsletterArticle);
        }

        // GET: Articles/Create
        public IActionResult Create()
        {
            ViewData["TitleId"] = new SelectList(_context.Titles, "TitleId", "TitleId");
            return View();
        }

        // POST: Articles/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ArticleId,Name,Description,Picture,TitleId")] NewsletterArticle newsletterArticle)
        {
            if (ModelState.IsValid)
            {
                _context.Add(newsletterArticle);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TitleId"] = new SelectList(_context.Titles, "TitleId", "TitleId", newsletterArticle.TitleId);
            return View(newsletterArticle);
        }

        // GET: Articles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Articles == null)
            {
                return NotFound();
            }

            var newsletterArticle = await _context.Articles.FindAsync(id);
            if (newsletterArticle == null)
            {
                return NotFound();
            }
            ViewData["TitleId"] = new SelectList(_context.Titles, "TitleId", "TitleId", newsletterArticle.TitleId);
            return View(newsletterArticle);
        }

        // POST: Articles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ArticleId,Name,Description,Picture,TitleId")] NewsletterArticle newsletterArticle)
        {
            if (id != newsletterArticle.ArticleId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(newsletterArticle);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NewsletterArticleExists(newsletterArticle.ArticleId))
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
            ViewData["TitleId"] = new SelectList(_context.Titles, "TitleId", "TitleId", newsletterArticle.TitleId);
            return View(newsletterArticle);
        }

        // GET: Articles/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Articles == null)
            {
                return NotFound();
            }

            var newsletterArticle = await _context.Articles
                .Include(n => n.NewsletterTitle)
                .FirstOrDefaultAsync(m => m.ArticleId == id);
            if (newsletterArticle == null)
            {
                return NotFound();
            }

            return View(newsletterArticle);
        }

        // POST: Articles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Articles == null)
            {
                return Problem("Entity set 'NewsLetterContext.Articles'  is null.");
            }
            var newsletterArticle = await _context.Articles.FindAsync(id);
            if (newsletterArticle != null)
            {
                _context.Articles.Remove(newsletterArticle);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NewsletterArticleExists(int id)
        {
          return (_context.Articles?.Any(e => e.ArticleId == id)).GetValueOrDefault();
        }
    }
}
