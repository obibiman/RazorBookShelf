using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookListWeb.Context;
using BookListWeb.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BookListWeb.Pages.BookList
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public IEnumerable<Book> Books { get; set; }

        public async Task OnGet()
        {
            Books = await _db.Books.ToListAsync();
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