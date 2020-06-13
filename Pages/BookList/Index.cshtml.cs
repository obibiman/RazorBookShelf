using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookListWeb.Context;
using BookListWeb.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace BookListWeb.Pages.BookList
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;
      private readonly ILogger<IndexModel> _logger;    
        public IndexModel(ApplicationDbContext db, ILogger<IndexModel> logger)
        {
            _db = db;
            _logger = logger;
        }

        public IEnumerable<Book> Books { get; set; }

        public async Task OnGet()
        {
            //Books = await _db.Books.ToListAsync();
            var books = await _db.Books
                //.Include(y => y.BookAuthors)
                //.Include(y=>y.Author)
                .Include(y=>y.BookGenre)
                .ToListAsync();
            _logger.LogInformation(books.Count().ToString());
        }

        //delete
        public async Task<IActionResult> OnPostBookDelete(int Id)
        {
            Book book = await _db.Books.FindAsync(Id);
            if (book != null)
            {
                 _db.Books.Remove(book);
                await _db.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            return RedirectToPage();
        }
    }
}