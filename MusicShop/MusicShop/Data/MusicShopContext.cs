using Microsoft.EntityFrameworkCore;



namespace MusicShop.Data
{
    public class MusicShopContext: DbContext
    {
        public MusicShopContext(DbContextOptions<MusicShopContext> options) : base(options)

        {

        }

        public DbSet<Music> Music { get; set; }

    }

}
