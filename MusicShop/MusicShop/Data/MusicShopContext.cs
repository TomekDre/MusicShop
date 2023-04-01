using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
