using Microsoft.EntityFrameworkCore;
using music.Models;
using music.Models;

namespace music.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Artist> Artists { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<MusicVideo> MusicVideos { get; set; }
    }
}
