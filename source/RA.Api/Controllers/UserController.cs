using Microsoft.AspNetCore.Mvc;
using RA.Api.Common;
using RA.Api.Interfaces;
using RA.BusinessService.Interfaces;
using RA.Kernel.Entities;
using System.Threading.Tasks;

namespace RA.Api.Controllers
{
    public class UserController : AbstractController<UserEntity>, IUserController
    {
        private readonly IUserBusinessService _userBusinessService;

        public UserController(IUserBusinessService userBusinessService) : base(userBusinessService)
        {
            _userBusinessService = userBusinessService;
        }

        [HttpPost]
        public async Task<ActionResult<UserEntity>> Login(UserEntity user)
        {
            UserEntity entity = _userBusinessService.Login(user);
            if (entity == null)
                return await Task.FromResult(BadRequest("Pin değerine uygun kullanıcı bulunamadı."));
            else
                return await Task.FromResult(Ok(entity));
        }
    }
}
