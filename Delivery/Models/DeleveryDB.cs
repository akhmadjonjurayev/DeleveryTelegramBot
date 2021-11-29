using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Delivery.Models
{
    public class DeleveryDB : DbContext
    {
        public DeleveryDB(DbContextOptions<DeleveryDB> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<MenuVersion> MenuVersions { get; set; }

        public DbSet<BotUser> Users { get; set; }

        public DbSet<BotButton> Buttons { get; set; }

        public DbSet<Products> Products { get; set; }

        public DbSet<Bascket> Basckets { get; set; }
    }
}
