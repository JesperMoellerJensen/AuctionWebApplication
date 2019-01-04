using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AuctionWebAPI.Entities
{
    public class AuctionContext : DbContext
    {
        public DbSet<AuctionItem> AuctionItems { get; set; }

        public AuctionContext(DbContextOptions<AuctionContext> options) : base(options)
        {
            Database.Migrate();
        }
    }
}
