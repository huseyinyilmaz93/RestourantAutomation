using Microsoft.EntityFrameworkCore;
using RA.Persistence.Mssql.Entities;

namespace RA.Persistence.Mssql.Common
{
    public interface IDbContext
    {
        DbSet<OrderEntity> OrderEntities { get; set; }

        DbSet<OrderDetailEntity> OrderDetailEntities { get; set; }
    }
}
