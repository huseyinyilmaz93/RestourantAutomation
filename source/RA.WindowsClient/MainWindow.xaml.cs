using System.Windows;
using System.Windows.Controls;

namespace RA.WindowsClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void KeyPad_Click(object sender, RoutedEventArgs e)
        {
            if (txtPassword.Password.Length < txtPassword.MaxLength)
            {
                Button button = sender as Button;
                txtPassword.Password = string.Concat(txtPassword.Password, button.ToolTip);
            }
        }

        private void DeleteKey_Click(object sender, RoutedEventArgs e)
        {
            if (txtPassword.Password.Length != 0)
                txtPassword.Password = txtPassword.Password.Substring(0, txtPassword.Password.Length - 1);
        }
    }
}
