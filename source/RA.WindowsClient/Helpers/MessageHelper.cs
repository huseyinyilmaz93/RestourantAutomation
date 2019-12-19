using RA.WindowsClient.Enumerations;
using RA.WindowsClient.UserControls;
using System.Windows;

namespace RA.WindowsClient.Helpers
{
    public class MessageHelper
    {
        public static ShowDialogResult Show(string title, string message)
        {
            ShowDialog messageBox = new ShowDialog(title, message);
            messageBox.ShowDialog();

            return messageBox.Result;
        }

        public static ShowDialogResult Show(string title, string message, ShowDialogButtons showDialog)
        {
            ShowDialog messageBox = new ShowDialog(title, message);
            messageBox.btnCancel.Visibility = Visibility.Hidden;
            messageBox.ShowDialog();

            return messageBox.Result;
        }
    }

    public enum ShowDialogButtons
    {
        OnlyOk,
    }
}
