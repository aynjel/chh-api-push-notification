using chh_api_push_notification.Models;
using Microsoft.EntityFrameworkCore;

namespace chh_api_push_notification.Data
{
    public class NZWalksDbContext: DbContext
    {
        public NZWalksDbContext(DbContextOptions<NZWalksDbContext> options): base(options)
        {

        }

        public DbSet<Difficulty> Difficulties { get; set; }

        public DbSet<Regions> Regions { get; set; }

        public DbSet<Walks> Walks { get; set; }
    }
}
