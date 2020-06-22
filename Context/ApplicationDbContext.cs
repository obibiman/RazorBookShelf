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
        public DbSet<BookGenre> BookGenres { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().ToTable("Book");
            modelBuilder.Entity<BookGenre>().ToTable("BookGenre");
            //modelBuilder.EnableSensitiveDataLogging();

            modelBuilder.Entity<BookGenre>().HasData(new BookGenre { Id = 100, GenreName = "Sql Server" });
            modelBuilder.Entity<BookGenre>().HasData(new BookGenre { Id = 200, GenreName = ".NET Core" });
            modelBuilder.Entity<BookGenre>().HasData(new BookGenre { Id = 300, GenreName = "Salesforce" });
            modelBuilder.Entity<BookGenre>().HasData(new BookGenre { Id = 400, GenreName = "Bootstrap" });
            modelBuilder.Entity<BookGenre>().HasData(new BookGenre { Id = 500, GenreName = "jQuery" });
            modelBuilder.Entity<BookGenre>().HasData(new BookGenre { Id = 600, GenreName = "Java" });
            modelBuilder.Entity<BookGenre>().HasData(new BookGenre { Id = 700, GenreName = "PhP" });
            modelBuilder.Entity<BookGenre>().HasData(new BookGenre { Id = 800, GenreName = "Python" });
            modelBuilder.Entity<BookGenre>().HasData(new BookGenre { Id = 900, GenreName = "Oracle" });
            modelBuilder.Entity<BookGenre>().HasData(new BookGenre { Id = 1000, GenreName = "Linux" });
            modelBuilder.Entity<BookGenre>().HasData(new BookGenre { Id = 1100, GenreName = "Networking" });
            modelBuilder.Entity<BookGenre>().HasData(new BookGenre { Id = 1200, GenreName = "Javascript" });
            modelBuilder.Entity<BookGenre>().HasData(new BookGenre { Id = 1300, GenreName = "Pearl" });
            modelBuilder.Entity<BookGenre>().HasData(new BookGenre { Id = 1400, GenreName = "PowerBI" });
            modelBuilder.Entity<BookGenre>().HasData(new BookGenre { Id = 1500, GenreName = "Design Patterns" });
            modelBuilder.Entity<BookGenre>().HasData(new BookGenre { Id = 1600, GenreName = "VB.Net" });
            modelBuilder.Entity<BookGenre>().HasData(new BookGenre { Id = 1700, GenreName = "SqlLite" });
            modelBuilder.Entity<BookGenre>().HasData(new BookGenre { Id = 1800, GenreName = "C++" });
            modelBuilder.Entity<BookGenre>().HasData(new BookGenre { Id = 1900, GenreName = "Objective C" });
            modelBuilder.Entity<BookGenre>().HasData(new BookGenre { Id = 2000, GenreName = "SAS" });
            modelBuilder.Entity<BookGenre>().HasData(new BookGenre { Id = 2100, GenreName = "Cobol" });
            modelBuilder.Entity<BookGenre>().HasData(new BookGenre { Id = 2200, GenreName = "Excel" });
            modelBuilder.Entity<BookGenre>().HasData(new BookGenre { Id = 2300, GenreName = "Splunk" });
            modelBuilder.Entity<BookGenre>().HasData(new BookGenre { Id = 2400, GenreName = "DB2" });
            modelBuilder.Entity<BookGenre>().HasData(new BookGenre { Id = 2500, GenreName = "Angular" });
            modelBuilder.Entity<BookGenre>().HasData(new BookGenre { Id = 2600, GenreName = "Vue" });
            modelBuilder.Entity<BookGenre>().HasData(new BookGenre { Id = 2700, GenreName = "Docker" });
            modelBuilder.Entity<BookGenre>().HasData(new BookGenre { Id = 2800, GenreName = "Git" });
            modelBuilder.Entity<BookGenre>().HasData(new BookGenre { Id = 2900, GenreName = "React" });
            modelBuilder.Entity<BookGenre>().HasData(new BookGenre { Id = 3000, GenreName = "Jira" });
            modelBuilder.Entity<BookGenre>().HasData(new BookGenre { Id = 3100, GenreName = "Octopus" });
            modelBuilder.Entity<BookGenre>().HasData(new BookGenre { Id = 3200, GenreName = "ECMAScript" });
            modelBuilder.Entity<BookGenre>().HasData(new BookGenre { Id = 3300, GenreName = "Kubernetes" });
        }
    }
}
