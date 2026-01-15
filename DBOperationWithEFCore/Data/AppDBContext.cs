using Microsoft.EntityFrameworkCore;

namespace DBOperationWithEFCore.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Currencies>().HasData(
             new Currencies() { Id = 1, tittle = "INR", Description = "INdia" },
             new Currencies() { Id = 2, tittle = "Doller", Description = "USA" },
             new Currencies() { Id = 3, tittle = "Euro", Description = "Europe" },
             new Currencies() { Id = 4, tittle = "Dinar", Description = "jsfhjdjf" }

                );

            modelBuilder.Entity<Language>().HasData(
            new Language() { Id = 1, tittle = "Hindi", Description = "INdia" },
            new Language() { Id = 2, tittle = "English", Description = "English" },
            new Language() { Id = 3, tittle = "Urdu", Description = "Urdu" },
            new Language() { Id = 4, tittle = "panjabi", Description = "panjabi" }

               );

        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Currencies> Currencies { get; set; }  
        public DbSet<BookPrices> bookPrices { get; set; }
    }
}
