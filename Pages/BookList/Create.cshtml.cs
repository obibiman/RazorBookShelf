using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using BookListWeb.Context;
using BookListWeb.Model;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;

namespace BookListWeb.Pages.BookList
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        private IWebHostEnvironment _environment;
        public CreateModel(ApplicationDbContext db, IWebHostEnvironment environment)
        {
            _db = db;
            _environment = environment;
        }

        [BindProperty]
        public Book Book { get; set; }

        [BindProperty]
        public IFormFile Photo { get; set; }

        public IEnumerable<BookGenre> Genres { get; set; }

        public async Task OnGet()
        {
            //Genres = new List<BookGenre> {
            //    new BookGenre { Id = 1, GenreName="Programming" },
            //    new BookGenre { Id = 2, GenreName="Database" },
            //    new BookGenre { Id = 3, GenreName=".NET Core" },
            //    new BookGenre { Id = 4, GenreName="Java" },
            //    new BookGenre { Id = 5, GenreName="Fiction" },
            //    new BookGenre { Id = 6, GenreName="Cloud" },
            //    new BookGenre { Id = 7, GenreName="Csharp" },
            //    new BookGenre { Id = 8, GenreName="Messaging" }
            //};
            Genres = await _db.BookGenres.ToListAsync();
        }

        public async Task<IActionResult> OnPost()
        {
            
            if (ModelState.IsValid)
            {
                var bk = new Book
                {
                    Name = Book.Name,
                    Author = Book.Author,
                    Price = Book.Price,
                    ISBN = Book.ISBN,
                    Edition = Book.Edition,
                    Year = Book.Year,
                    Genre = Book.Genre,
                    SubTitle = Book.SubTitle,
                    Photo = Book.Photo,
                    Description = Book.Description,
                    PageCount = Book.PageCount,
                    Publisher = Book.Publisher,
                    CreatedBy = Book.CreatedBy,
                    CreatedDate = DateTime.UtcNow,
                    ModifiedDate = Book.ModifiedDate,
                    ModifiedBy = Book.ModifiedBy
                };

                //await _db.Books.AddAsync(Book);
                await _db.Books.AddAsync(bk);
                await _db.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }
    }
}