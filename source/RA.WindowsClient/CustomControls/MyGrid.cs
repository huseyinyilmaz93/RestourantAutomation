using RA.WindowsClient.Attributes;
using System.ComponentModel;
using System.Linq;
using System.Windows.Controls;

namespace RA.WindowsClient.CustomControls
{
    public class MyGrid : DataGrid
    {
        protected override void OnAutoGeneratingColumn(DataGridAutoGeneratingColumnEventArgs e)
        {
            ListViewAttribute listView = ((MemberDescriptor)e.PropertyDescriptor).Attributes.OfType<ListViewAttribute>().FirstOrDefault();

            if (listView != null)
            {
                e.Column.Visibility = listView.Visibility;
                e.Column.Header = listView.ResourceName;
            }

            base.OnAutoGeneratingColumn(e);
        }
    }
}
