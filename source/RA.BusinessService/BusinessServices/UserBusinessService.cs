using RA.BusinessService.Common;
using RA.BusinessService.Interfaces;
using RA.Kernel.Entities;
using RA.Persistence.Interfaces.User;

namespace RA.BusinessService.BusinessServices
{
    public class UserBusinessService : AbstractBusinessService<UserEntity>, IUserBusinessService
    {
        public IQueryUserRepository _queryUserRepository { get; set; }

        public ICommandUserRepository _commandUserRepository { get; set; }

        public UserBusinessService(IQueryUserRepository queryUserRepository, ICommandUserRepository commandUserRepository) : base(queryUserRepository, commandUserRepository)
        {
            _queryUserRepository = queryUserRepository;
            _commandUserRepository = commandUserRepository;
        }

        public UserEntity Login(UserEntity user)
        {
            return _queryUserRepository.Get(u => u.Pin == user.Pin);
        }
    }
}
