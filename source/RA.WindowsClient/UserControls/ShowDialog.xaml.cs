using RA.WindowsClient.Enumerations;

namespace RA.WindowsClient.UserControls
{
    public partial class ShowDialog
    {
        public ShowDialogResult Result { get; set; }

        public ShowDialog(string title, string message)
        {
            InitializeComponent();
            this.Title = title;
            Content.Text = message;
            this.Result = ShowDialogResult.Cancelled;
        }

        private void Cancel_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Result = ShowDialogResult.CancelClick;
            this.Close();
        }

        private void Ok_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Result = ShowDialogResult.OkClick;
            this.Close();
        }
    }
}
