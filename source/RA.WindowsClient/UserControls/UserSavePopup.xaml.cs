using RA.WindowsClient.Helpers;
using System.Windows;

namespace RA.WindowsClient.UserControls
{
    public partial class UserSavePopup
    {
        public UserSavePopup()
        {
            InitializeComponent();
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
