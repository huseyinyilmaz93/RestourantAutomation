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
    }
}