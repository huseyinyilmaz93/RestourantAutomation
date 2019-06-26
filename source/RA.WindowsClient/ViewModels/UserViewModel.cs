using RA.Kernel.Enumeration.User;
using RA.WindowsClient.Attributes;
using RA.WindowsClient.Common;
using System.Windows;

namespace RA.WindowsClient.ViewModels
{
    public class UserViewModel : BaseViewModel
    {
        [ListView("", Visibility.Hidden)]
        public string Pin { get; set; }

        [ListView("UserName", Visibility.Visible)]
        public string UserName { get; set; }

        [ListView("UserType", Visibility.Visible)]
        public UserType UserType { get; set; }

    }
}
