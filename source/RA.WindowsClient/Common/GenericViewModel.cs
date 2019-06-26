using System.Collections.Generic;

namespace RA.WindowsClient.Common
{
    public class GenericViewModel<T>
    {
        public IList<T> Items { get; set; }

        public T SelectedItem { get; set; }

        public int SelectedIndex { get; set; }
    }
}