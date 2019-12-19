using System;

namespace RA.WindowsClient.Attributes
{
    public class DetailViewAttribute : Attribute
    {
        public string ControlName { get; set; }

        public DetailViewAttribute(string controlName)
        {
            ControlName = controlName;
        }
    }
}
