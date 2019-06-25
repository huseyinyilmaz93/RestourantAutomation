using RA.WindowsClient.IoC.Interceptors;
using RA.WindowsConnector.ConnectorInterfaces;
using RA.WindowsConnector.Conntectors;
using Unity;
using Unity.Interception;
using Unity.Interception.ContainerIntegration;
using Unity.Interception.Interceptors.InstanceInterceptors.InterfaceInterception;

namespace RA.WindowsClient.IoC
{
    public class IoCHelper
    {
        public static IUnityContainer _container { get; set; }

        public static T Resolve<T>()
        {
            if(_container == null)
            {
                _container = new UnityContainer();
                _container.AddNewExtension<Interception>();
                _container.RegisterType<IUserWindowsConnector, UserWindowsConnector>(
                        new Interceptor<InterfaceInterceptor>(),
                        new InterceptionBehavior<ConnectorInterceptor>()
                    );
            }
            return _container.Resolve<T>();
        }
    }
}
