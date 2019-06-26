using AutoMapper;
using RA.WindowsClient.Mappings;

namespace RA.WindowsClient.IoC.Factories
{
    public class MappingFactory
    {
        private static IMapper _mapper { get; set; }

        public static IMapper GetMapper()
        {
            if (_mapper == null)
            {
                _mapper = new MapperConfiguration(cfg =>
                {
                    cfg.AddProfile<UserMapping>();
                }).CreateMapper();
            }
            return _mapper;
        }
    }
}
