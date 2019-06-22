using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using RA.BusinessService.BusinessServices;
using RA.BusinessService.Interfaces;
using RA.IoC.Container;
using RA.IoC.Factories;
using RA.Kernel.Enumeration.Common;
using RA.Kernel.HelperDto;
using RA.Persistence.Interfaces;
using RA.Persistence.Interfaces.Order;
using RA.Persistence.Mssql.Common;
using RA.Persistence.Mssql.Repositories.Order;

namespace RA.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            RegisterLayer(services, new IocRegisterDto()
            {
                RegisterInterface = typeof(IQueryOrderRepository),
                RegisterClass = typeof(QueryOrderRepository),
                ClassNamespace = "RA.Persistence.Mssql.Repositories.",
                InterfaceNamespace = "RA.Persistence.Interfaces.",
            }, CQRS_TYPE.None);

            RegisterLayer(services, new IocRegisterDto()
            {
                RegisterInterface = typeof(IOrderBusinessService),
                RegisterClass = typeof(OrderBusinessService),
                ClassNamespace = "RA.BusinessService.BusinessServices.",
                InterfaceNamespace = "RA.BusinessService.Interfaces.",
            }, CQRS_TYPE.None);

            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "RA.Api..connstr";

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (StreamReader reader = new StreamReader(stream))
            {
                var connection = reader.ReadToEnd();
                services.AddDbContext<MyDbContext>(options => options.UseSqlServer(connection));
            }

            services.AddSingleton(typeof(IMapper), MappingFactory.GetMapper());
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default_route",
                    template: "{controller}/{action}/{id?}",
                    defaults: new { controller = "Home", action = "Index" }
                );
            });

            using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                MyDbContext context = serviceScope.ServiceProvider.GetService<MyDbContext>();
                context.Database.EnsureCreated();
            }
        }

        public static void RegisterLayer(IServiceCollection services, IocRegisterDto input, CQRS_TYPE cqrsType)
        {
            var interfaces = GetObjectsFromNamespace(input.RegisterInterface, input.InterfaceNamespace, cqrsType);

            var classes = GetObjectsFromNamespace(input.RegisterClass, input.ClassNamespace, cqrsType);

            foreach (Type typeClass in classes)
            {
                Type typeInterface = interfaces.Find(x => x.IsAssignableFrom(typeClass));
                if (typeInterface == null)
                    continue;

                services.AddTransient(typeInterface, typeClass);
            }
        }

        private static List<Type> GetObjectsFromNamespace(Type objectType, string objectNamespace, CQRS_TYPE cqrsType)
        {
            if (cqrsType == CQRS_TYPE.None)
                return objectType.Assembly.GetExportedTypes().Where(x => x.FullName.StartsWith(objectNamespace)).ToList();

            return objectType.Assembly.GetExportedTypes().Where(x => x.FullName.StartsWith(objectNamespace) && x.FullName.Contains(Enum.GetName(typeof(CQRS_TYPE), cqrsType))).ToList();
        }

    }
}
