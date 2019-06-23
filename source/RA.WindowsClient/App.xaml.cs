using RA.WindowsClient.Properties;
using System.Globalization;
using System.Threading;
using System.Windows;

namespace RA.WindowsClient
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            Resource.Culture = Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
        }

        private void Dispatcher_UnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            MessageBox.Show(e.Exception.Message);
            e.Handled = true;
        }
    }
}