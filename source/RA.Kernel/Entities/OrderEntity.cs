using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using RA.Kernel.Common;

namespace RA.Kernel.Entities
{
    [Table("Order")]
    public class OrderEntity : BaseEntity
    {
        [Required]
        [StringLength(100)]
        public string OrderNumber { get; set; }

        IEnumerator<OrderDetailEntity> OrderDetailList { get; set; }
    }
}
