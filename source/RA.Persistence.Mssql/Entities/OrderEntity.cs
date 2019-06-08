using RA.Persistence.Interfaces;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace RA.Persistence.Mssql.Entities
{
    [Table("Order")]
    public class OrderEntity : BaseEntity
    {
        public int Id { get; set; }

        public string OrderNumber { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime? ModifiedDate { get; set; }
    }
}
