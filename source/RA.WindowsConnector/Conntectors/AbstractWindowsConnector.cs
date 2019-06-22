using RA.WindowsConnector.ConnectorInterfaces;
using RA.WindowsConnector.Helpers;

namespace RA.WindowsConnector.Conntectors
{
    public abstract class AbstractWindowsConnector<T> : IWindowsConnector<T>
    {
        public T Get(string path)
        {
            return HttpClientHelper.Get<T>(path);
        }

        public T Post(string path, T input)
        {
            return HttpClientHelper.Post(path, input);
        }

        public bool Delete(string path, int id)
        {
            return HttpClientHelper.Delete(path, id);
        }
    }
}
