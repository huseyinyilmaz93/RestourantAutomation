using RA.Api.Common;
using RA.Api.Interfaces;
using RA.BusinessService.Interfaces;
using RA.Kernel.Entities;

namespace RA.Api.Controllers
{
    public class UserController : AbstractController<UserEntity>, IUserController
    {

        public UserController(IUserBusinessService userBusinessService) : base(userBusinessService)
        {
        }
    }
}
