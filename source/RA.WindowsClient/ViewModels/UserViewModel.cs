using RA.Kernel.Enumeration.User;
using RA.WindowsClient.Attributes;
using RA.WindowsClient.Common;
using RA.WindowsClient.Properties;
using System.ComponentModel.DataAnnotations;
using System.Windows;

namespace RA.WindowsClient.ViewModels
{
    public class UserViewModel : BaseViewModel
    {
        [ListView("", Visibility.Hidden)]
        [DetailView("txtPin")]
        [Required(ErrorMessageResourceName = "PinRequired", ErrorMessageResourceType = typeof(Resource))]
        [Compare(  "PinAgain", ErrorMessageResourceName = "PinFieldsMustMatch", ErrorMessageResourceType = typeof(Resource))]
        public string Pin { get; set; }

        [ListView("", Visibility.Hidden)]
        [DetailView("txtPinAgain")]
        [Required(ErrorMessageResourceName = "PinAgainRequired", ErrorMessageResourceType = typeof(Resource))]
        public string PinAgain { get; set; }

        [ListView("UserName", Visibility.Visible)]
        [DetailView("txtUsername")]
        [Required(ErrorMessageResourceName = "UserNameRequired", ErrorMessageResourceType = typeof(Resource))]
        public string UserName { get; set; }

        [ListView("UserType", Visibility.Visible)]
        [DetailView("cbbUserTypes")]
        [Required(ErrorMessageResourceName = "UserTypeRequired", ErrorMessageResourceType = typeof(Resource))]
        public UserType UserType { get; set; }

    }
}
