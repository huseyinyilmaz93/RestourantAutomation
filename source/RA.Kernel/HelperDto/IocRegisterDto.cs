using System;

namespace RA.Kernel.HelperDto
{
    public class IocRegisterDto
    {
        public Type RegisterInterface { get; set; }

        public Type RegisterClass { get; set; }

        public Type[] RegisterInterceptors { get; set; }

        public string ConnectionString { get; set; }

        public string InterfaceNamespace { get; set; }

        public string ClassNamespace { get; set; }
    }
}
