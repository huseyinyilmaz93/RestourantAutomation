using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using RA.BusinessService.BusinessServices;
using RA.BusinessService.Interfaces;
using RA.IoC.Container;
using RA.Kernel.Enumeration.Common;
using RA.Kernel.HelperDto;
using System;

namespace RA.IoC.Installers
{
    public class BusinessServiceInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            //IoCHelper.RegisterLayerWithInterceptors(new IocRegisterDto()
            //{
            //    RegisterInterface = typeof(IOrderBusinessService),
            //    RegisterClass = typeof(OrderBusinessService),
            //    ClassNamespace = "RA.BusinessService.BusinessServices.",
            //    InterfaceNamespace = "RA.BusinessService.Interfaces.",
            //    RegisterInterceptors = new Type[] { }
            //}, CQRS_TYPE.None);
        }
    }
}
