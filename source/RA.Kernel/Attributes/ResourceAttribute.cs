using System;

namespace RA.Kernel.Attributes
{
    public class ResourceAttribute : Attribute
    {
        public string ResourceName { get; set; }

        public ResourceAttribute(string resourceName)
        {
            ResourceName = resourceName;
        }
    }
}
