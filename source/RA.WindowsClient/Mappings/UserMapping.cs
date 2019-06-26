using AutoMapper;
using RA.Kernel.Entities;
using RA.WindowsClient.ViewModels;

namespace RA.WindowsClient.Mappings
{
    public class UserMapping : Profile
    {
        public UserMapping()
        {
            CreateMap<UserViewModel, UserEntity>().ReverseMap();
        }
    }
}
