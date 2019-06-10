using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using RA.Persistence.Interfaces;
using RA.Persistence.Mssql.Common;

namespace RA.IoC.Installers
{
    public class RepositoryInstaller : IWindsorInstaller
    {
        private readonly string _connectionString;

        public RepositoryInstaller(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            //IoCHelper.RegisterLayerWithConnectionString(new IocRegisterDto()
            //{
            //    RegisterInterface = typeof(IQueryOrderRepository),
            //    RegisterClass = typeof(QueryOrderRepository),
            //    ClassNamespace = "RA.Persistence.Mssql.Repositories.",
            //    InterfaceNamespace = "RA.Persistence.Interfaces.",
            //    ConnectionString = _connectionString,
            //}, CQRS_TYPE.None);

            container.Register(Component.For(typeof(ICommandUnitOfWorkRepository<>))
                .ImplementedBy(typeof(AbstractCommandUnitOfWorkRepository<>))
                .LifestyleSingleton());
        }
    }
}
