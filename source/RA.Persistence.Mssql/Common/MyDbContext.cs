using Microsoft.EntityFrameworkCore;
using RA.Persistence.Mssql.Entities;

namespace RA.Persistence.Mssql.Common
{
    public class MyDbContext : DbContext, IDbContext
    {
        public MyDbContext(DbContextOptions options)
        {

        }

        public DbSet<OrderEntity> OrderEntities { get; set; }

        public DbSet<OrderDetailEntity> OrderDetailEntities { get; set; }
    }
}
