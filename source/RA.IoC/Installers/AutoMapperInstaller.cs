using AutoMapper;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using RA.IoC.Factories;

namespace RA.IoC.Installers
{
    public class AutoMapperInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                 Component.For<IMapper>()
                     .UsingFactoryMethod(x => MappingFactory.GetMapper())
                     .LifestyleSingleton()
             );
        }
    }
}
