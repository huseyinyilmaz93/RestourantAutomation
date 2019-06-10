using RA.Kernel.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RA.Kernel.Entities
{
    [Table("OrderDetail")]
    public class OrderDetailEntity : BaseEntity
    {
        [Required]
        public OrderEntity Order { get; set; }
    }
}
