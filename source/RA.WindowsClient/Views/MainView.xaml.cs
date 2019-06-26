using MaterialDesignThemes.Wpf;
using RA.Kernel.Common;
using RA.Kernel.Entities;
using RA.WindowsClient.Helpers;
using RA.WindowsClient.InterfaceHelpers;
using RA.WindowsClient.IoC;
using RA.WindowsConnector.ConnectorInterfaces;
using RA.WindowsConnector.Conntectors;
using System;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace RA.WindowsClient.Views
{
    public partial class MainView : Window
    {
        private readonly IUserWindowsConnector _userWindowsConnector = null;

        public MainView()
        {
            InitializeComponent();
            _userWindowsConnector = IoCHelper.Resolve<IUserWindowsConnector>();
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

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            Task.Run(() => {
                _userWindowsConnector.Login(new UserEntity
                {
                    Pin = txtPassword.Password,
                }).Continue(LoginCallBack);
            });
        }

        private void LoginCallBack(Response<UserEntity> response)
        {
            if (response.HasError)
                MessageHelper.Show("Hata", response.Message, ShowDialogButtons.OnlyOk);
            else
            {
                DefinitionView view = new DefinitionView();
                view.Owner = this;
                if (view.ShowDialog() != null)
                    txtPassword.Password = string.Empty;
            }
        }

        private void HandleDigit(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            e.Handled = FormHelper.IsLastCharDigit(e.Text);
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


    }
}