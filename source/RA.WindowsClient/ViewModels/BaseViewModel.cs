using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RA.WindowsClient.ViewModels
{
    public class BaseViewModel<T>
    {
        public IList<T> Items { get; set; }

        public T SelectedItem { get; set; }

        public int SelectedIndex { get; set; }
    }
}