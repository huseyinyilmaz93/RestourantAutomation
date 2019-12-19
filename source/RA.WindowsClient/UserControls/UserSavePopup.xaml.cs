using RA.Kernel.Enumeration.User;
using RA.WindowsClient.Helpers;
using RA.WindowsClient.ViewModels;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace RA.WindowsClient.UserControls
{
    public partial class UserSavePopup
    {
        public UserViewModel CurrentUser { get; set; }

        public UserSavePopup()
        {
            InitializeComponent();
            if (CurrentUser == null)
                CurrentUser = new UserViewModel() { UserType = UserType.Anroid };

                DataContext = CurrentUser;

            ComboBoxHelper.BindEnum<UserType>(cbbUserTypes);
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            ValidationHelper.Validate(this, CurrentUser);
        }

        private void HandleDigit(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            e.Handled = FormHelper.IsLastCharDigit(e.Text);
        }
    }
}