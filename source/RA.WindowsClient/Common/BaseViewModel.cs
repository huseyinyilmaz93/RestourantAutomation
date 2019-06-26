using RA.WindowsClient.Attributes;
using System;
using System.Windows;

namespace RA.WindowsClient.Common
{
    public class BaseViewModel
    {
        [ListView("", Visibility.Hidden)]
        public int Id { get; set; }

        [ListView("", Visibility.Hidden)]
        public DateTime CreatedDate { get; set; }

        [ListView("", Visibility.Hidden)]
        public DateTime? ModifiedDate { get; set; }
    }
}
