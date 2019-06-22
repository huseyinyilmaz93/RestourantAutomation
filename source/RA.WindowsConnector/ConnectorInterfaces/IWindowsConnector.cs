using System.Collections.Generic;

namespace RA.WindowsConnector.ConnectorInterfaces
{
    public interface IWindowsConnector<T>
    {
        T Get(string path);

        T Post(string path, T input);

        bool Delete(string path, int id);
    }
}
