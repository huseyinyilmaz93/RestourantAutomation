using Microsoft.EntityFrameworkCore;
using RA.Kernel.Entities;

namespace RA.Persistence.Mssql.Common
{
    public interface IDbContext
    {
        DbSet<OrderEntity> OrderEntities { get; set; }

        DbSet<OrderDetailEntity> OrderDetailEntities { get; set; }

        DbSet<UserEntity> UserEntities { get; set; }
    }
}
