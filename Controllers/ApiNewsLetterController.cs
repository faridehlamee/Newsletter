using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using Microsoft.EntityFrameworkCore;
using NewsLetter6.Data;
using NewsLetter6.Models;
using Microsoft.AspNetCore.Cors;

namespace NewsLetter6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("NewsLetterPolicy")]
    
    public class ApiNewsLetterController : ControllerBase
    {
        private readonly ILogger<ApiNewsLetterController> _logger;
        private readonly NewsLetterContext _context;

        public ApiNewsLetterController(ILogger<ApiNewsLetterController> logger,NewsLetterContext context)
        {
            _logger = logger;
            _context = context;
        }

        // GET: api/NewsLetters
        [HttpGet]
        public async Task<ActionResult<IEnumerable<NewsLetterTitle>>> GetNewsLetters()
        {
          if (_context.Titles == null)
          {
              return NotFound();
          }
           return await _context.Titles
                .Include(i => i.Articles)
                .Where(title => title.IsActive == true)
                .OrderByDescending(title => title.TitleId)
                .Take(5)  // Take the first 5 rows (this gets the last 5 after the order)
                //.OrderBy(title => title.TitleId)  // Reorder the results in ascending order if needed
                .ToListAsync();

        }           
        
    }
}