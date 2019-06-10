using System;
using System.ComponentModel.DataAnnotations;

namespace RA.Kernel.Common
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

    }
}
