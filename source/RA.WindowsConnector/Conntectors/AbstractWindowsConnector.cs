using System.Collections.Generic;
using RA.Kernel.Common;
using RA.WindowsConnector.ConnectorInterfaces;
using RA.WindowsConnector.Helpers;

namespace RA.WindowsConnector.Conntectors
{
    public abstract class AbstractWindowsConnector<T> : IWindowsConnector<T>
    {
        public Response<T> Get(string path)
        {
            return HttpClientHelper.Get<T>(path);
        }

        public Response<IList<T>> GetList(string path)
        {
            return HttpClientHelper.Get<IList<T>>(path);
        }

        public Response<T> Post(string path, T input)
        {
            return HttpClientHelper.Post(path, input);
        }

        public Response<bool> Delete(string path, int id)
        {
            return HttpClientHelper.Delete(path, id);
        }

    }
}
