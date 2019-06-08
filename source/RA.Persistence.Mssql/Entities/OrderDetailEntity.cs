using RA.Persistence.Interfaces;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace RA.Persistence.Mssql.Entities
{
    [Table("OrderDetail")]
    public class OrderDetailEntity : BaseEntity
    {
        public int Id { get; set; }

        public string OrderId { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime? ModifiedDate { get; set; }
    }
}
