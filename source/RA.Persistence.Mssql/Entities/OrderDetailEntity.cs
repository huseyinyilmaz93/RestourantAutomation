using RA.Persistence.Interfaces;
using System;

namespace RA.Persistence.Mssql.Entities
{
    public class OrderDetailEntity : BaseEntity
    {
        public int Id { get; set; }

        public string OrderId { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime? ModifiedDate { get; set; }
    }
}
