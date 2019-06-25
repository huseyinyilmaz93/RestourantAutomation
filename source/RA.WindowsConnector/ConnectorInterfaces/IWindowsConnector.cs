using RA.Kernel.Common;
using System.Collections.Generic;

namespace RA.WindowsConnector.ConnectorInterfaces
{
    public interface IWindowsConnector<T>
    {
        Response<T> Get(string path);

        Response<IList<T>> GetList(string path);

        Response<T> Post(string path, T input);

        Response<bool> Delete(string path, int id);
    }
}
