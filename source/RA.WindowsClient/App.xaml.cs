using RA.WindowsClient.Helpers;
using RA.WindowsClient.Properties;
using System.Globalization;
using System.Threading;
using System.Windows;
using System.Windows.Controls;

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
            (this.MainWindow.FindName("progressBar") as ProgressBar).Opacity = 0;
            MessageHelper.Show("ERR", e.Exception.Message, ShowDialogButtons.OnlyOk);
            e.Handled = true;
        }
    }
}