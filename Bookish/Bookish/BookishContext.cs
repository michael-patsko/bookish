using Microsoft.EntityFrameworkCore;
namespace Bookish
{
    public class BookishContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Copy> Copies { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<MemberCopy> MemberCopies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=BookishDB;Trusted_Connection=True;");
        }

    }
}