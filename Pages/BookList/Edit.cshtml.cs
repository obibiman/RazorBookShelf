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
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public EditModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Book Book { get; set; }

        public async Task OnGet(int Id)
        {
            Book = await _db.Books.FindAsync(Id);
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                Book book = await _db.Books.FindAsync(Book.Id);
                book.Name = Book.Name;
                book.Author = Book.Author;
                book.Price = Book.Price;
                book.ISBN = Book.ISBN;
                book.Edition = Book.Edition;
                book.Year = Book.Year;
                book.Genre = Book.Genre;
                book.SubTitle = Book.SubTitle;
                book.Photo = Book.Photo;
                book.Description = Book.Description;
                book.PageCount = Book.PageCount;
                book.Publisher = Book.Publisher;
                book.CreatedBy = Book.CreatedBy;
                book.CreatedDate = Book.CreatedDate;
                book.ModifiedDate = DateTime.UtcNow;
                book.ModifiedBy = "System Admin";
                await _db.SaveChangesAsync();
                return RedirectToPage("Index");
            }     
                return RedirectToPage();
        }
    }
}