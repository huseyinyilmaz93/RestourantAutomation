using RA.Kernel.Common;
using RA.Kernel.Enumeration.User;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RA.Kernel.Entities
{
    [Table("User")]
    public class UserEntity : BaseEntity
    {
        [Required]
        [StringLength(50)]
        public string Pin { get; set; }

        [Required]
        public UserType UserType { get; set; }
    }
}
