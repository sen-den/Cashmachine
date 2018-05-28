using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace cashmachine
{
    public class EfContext : DbContext
    {
        public EfContext(DbContextOptions<EfContext> options) : base(options)
        {
        }

        public DbSet<Card> Cards { get; set; }
        public DbSet<Operation> Operations { get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Card>().ToTable("Card");
            modelBuilder.Entity<Operation>().ToTable("Operation");
        }
    }

}