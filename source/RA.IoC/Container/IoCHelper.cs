using Castle.Facilities.TypedFactory;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Microsoft.Extensions.DependencyInjection;
using RA.IoC.Installers;
using RA.Kernel.Enumeration.Common;
using RA.Kernel.HelperDto;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RA.IoC.Container
{
    public class IoCHelper
    {
        private static string connectionString { get; set; }

        private static IWindsorContainer _container { get; set; }

        private static IWindsorContainer Register()
        {
            IWindsorInstaller[] installers = new IWindsorInstaller[]
               {
                    new AutoMapperInstaller(),
                    new RepositoryInstaller(connectionString),
                    new BusinessServiceInstaller()
               };
            _container = new WindsorContainer().AddFacility<TypedFactoryFacility>();

            return _container.Install(installers);
        }

        public static IWindsorContainer GetContainer()
        {
            if (_container == null)
                throw new Exception("Container cannnot because it has not registered yet.");
            return _container;
        }

        public static T Resolve<T>()
        {
            if (_container == null)
                _container = Register();
            return _container.Resolve<T>();
        }
    }
}
