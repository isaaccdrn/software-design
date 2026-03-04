using Microsoft.EntityFrameworkCore;
using static lab6.Form1;

namespace lab6
{
    internal class BookstoreContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=BookstoreDB;Trusted_Connection=True;");
        }
    }
}