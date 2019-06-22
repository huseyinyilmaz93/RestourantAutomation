using Microsoft.EntityFrameworkCore;
using RA.Kernel.Entities;
using RA.Kernel.Enumeration.User;
using System;
using System.Text;

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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserEntity>().HasData(new UserEntity() { CreatedDate = DateTime.Now, Pin = "1234", UserType = UserType.Admin, Id = 1 });
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<OrderEntity> OrderEntities { get; set; }

        public DbSet<OrderDetailEntity> OrderDetailEntities { get; set; }

        public DbSet<UserEntity> UserEntities { get; set; }
    }
}
