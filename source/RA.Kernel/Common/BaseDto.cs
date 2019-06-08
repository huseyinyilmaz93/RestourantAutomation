using System;

namespace RA.Kernel.Common
{
    public class BaseDto
    {
        int Id { get; set; }
        
        DateTime CreatedDate { get; set; }
        
        DateTime? ModifiedDate { get; set; }
    }
}
