using System;
using System.Windows;

namespace RA.WindowsClient.Attributes
{
    public class ListViewAttribute : Attribute
    {
        public string ResourceName { get; set; }

        public Visibility Visibility { get; set; }

        public ListViewAttribute(string resourceName, Visibility visibility)
        {
            ResourceName = resourceName;
            Visibility = visibility;
        }
    }
}
