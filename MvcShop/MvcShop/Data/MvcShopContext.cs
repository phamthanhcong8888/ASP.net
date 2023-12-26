using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcShop.Models;

namespace MvcShop.Data
{
    public class MvcShopContext : DbContext
    {
        public MvcShopContext (DbContextOptions<MvcShopContext> options)
            : base(options)
        {
        }

        public DbSet<MvcShop.Models.Shop> Shop { get; set; } = default!;
    }
}
