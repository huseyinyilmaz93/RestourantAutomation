using RA.Kernel.Entities;
using RA.WindowsClient.IoC;
using RA.WindowsClient.ViewModels;
using RA.WindowsConnector.ConnectorInterfaces;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using RA.WindowsClient.InterfaceHelpers;
using RA.Kernel.Common;
using System;
using RA.WindowsClient.UserControls;
using RA.WindowsClient.Common;

namespace RA.WindowsClient.Views
{
    public partial class DefinitionView : Window
    {
        private const string Users = "1";
        private const string Logout = "2";

        IUserWindowsConnector _userWindowsConnector = IoCHelper.Resolve<IUserWindowsConnector>();

        public DefinitionView()
        {
            InitializeComponent();
            DataContext = new OrderViewModel();
        }

        private void CloseLeftMenu_Click(object sender, RoutedEventArgs e)
        {
            OpenLeftMenu.Visibility = Visibility.Visible;
            CloseLeftMenu.Visibility = Visibility.Collapsed;
        }

        private void OpenLeftMenu_Click(object sender, RoutedEventArgs e)
        {
            OpenLeftMenu.Visibility = Visibility.Collapsed;
            CloseLeftMenu.Visibility = Visibility.Visible;
        }

        private void ItemSelected(object sender, SelectionChangedEventArgs e)
        {
            if((e.AddedItems[0] as ListViewItem).Tag.ToString().Equals(Users))
            {
                Task.Run(() => {
                    _userWindowsConnector.GetList("/User/GetList")
                        .Continue(UserListCallBack);
                });
            }
            else if ((e.AddedItems[0] as ListViewItem).Tag.ToString().Equals(Logout))
            {
                this.Close();
            }
        }

        private void UserListCallBack(Response<IList<UserEntity>> obj)
        {
            GenericViewModel<UserEntity> context = new GenericViewModel<UserEntity>();
            context.Items = obj.Result;
            DataContext = context;
        }

        private void ListViewItem_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {

        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            Type type = DataContext.GetType();

            UserSavePopup messageBox = new UserSavePopup();
            messageBox.ShowDialog();
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
