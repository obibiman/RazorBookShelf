using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookListWeb.Context;
using BookListWeb.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookListWeb.Pages.BookList
{
    public class DetailModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public DetailModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Book Book { get; set; }

        public async Task OnGet(int Id)
        {
            Book = await _db.Books.FindAsync(Id);
        }
    }
}