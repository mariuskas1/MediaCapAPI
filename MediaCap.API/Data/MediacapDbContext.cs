using MediaCap.API.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace MediaCap.API.Data
{
    public class MediacapDbContext: DbContext
    {
        public MediacapDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<Book> Books{ get; set; }
        public DbSet<Film> Films { get; set; }
        public DbSet<Series> Series { get; set; }

    }
}
