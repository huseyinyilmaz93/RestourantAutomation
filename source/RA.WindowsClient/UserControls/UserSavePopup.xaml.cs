using RA.Kernel.Entities;
using RA.Kernel.Enumeration.User;
using RA.WindowsClient.Helpers;
using System;
using System.Windows;

namespace RA.WindowsClient.UserControls
{
    public partial class UserSavePopup
    {
        public UserSavePopup()
        {
            InitializeComponent();
            ComboBoxHelper.BindEnum<UserType>(cbbUserTypes);
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
        
        }

        private void HandleDigit(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            e.Handled = FormHelper.IsLastCharDigit(e.Text);
        }
    }
}