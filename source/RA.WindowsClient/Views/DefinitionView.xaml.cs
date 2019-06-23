using MaterialDesignThemes.Wpf;
using RA.WindowsClient.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RA.WindowsClient.Views
{
    public partial class DefinitionView : Window
    {
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
            var a = e;

            Show();
        }
    }
}
