﻿using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPages.Models;

namespace RazorPages.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly RazorPages.Data.RazorPagesContext _context;

        public IndexModel(RazorPages.Data.RazorPagesContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Movie != null)
            {
                Movie = await _context.Movie.ToListAsync();
            }
        }
    }
}
