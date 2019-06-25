using RA.Kernel.Common;
using System;
using System.Windows;
using System.Windows.Controls;

namespace RA.WindowsClient.InterfaceHelpers
{
    public static class ResponseExtensions 
    {
        public static void Continue<T>(this Response<T> response, Action<Response<T>> action)
        {
            Application.Current.Dispatcher.Invoke(delegate
            {
                ProgressBar progressBar = (Application.Current.MainWindow.FindName("progressBar") as ProgressBar);
                if (progressBar != null)
                    progressBar.Opacity = 0;
                action(response);
            });
        }
    }
}
