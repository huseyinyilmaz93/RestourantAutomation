using Microsoft.EntityFrameworkCore;
using RA.Kernel.Entities;

namespace RA.Persistence.Mssql.Common
{
    public class MyDbContext : DbContext, IDbContext
    {
        public MyDbContext(DbContextOptions options) : base(options) 
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<OrderEntity> OrderEntities { get; set; }

        public DbSet<OrderDetailEntity> OrderDetailEntities { get; set; }
    }
}
