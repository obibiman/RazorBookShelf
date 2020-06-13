using BookListWeb.Model;
using Microsoft.EntityFrameworkCore;

namespace BookListWeb.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { }

        public DbSet<Book> Books { get; set; }
        public DbSet<BookAuthor> BookAuthors { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<BookGenre> BookGenres { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().ToTable("Book");
            modelBuilder.Entity<BookAuthor>().ToTable("BookAuthor");
            modelBuilder.Entity<Author>().ToTable("Author");
            modelBuilder.Entity<BookGenre>().ToTable("BookGenre");
        }
    }
}
