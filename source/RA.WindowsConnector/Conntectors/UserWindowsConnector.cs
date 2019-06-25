using RA.Kernel.Common;
using RA.Kernel.Entities;
using RA.WindowsConnector.ConnectorInterfaces;
using System;
using System.Threading.Tasks;

namespace RA.WindowsConnector.Conntectors
{
    public class UserWindowsConnector : AbstractWindowsConnector<UserEntity>, IUserWindowsConnector
    {
        public const string POST_LOGIN = "/User/Login";

        public Response<UserEntity> Login(UserEntity input)
        {
            return base.Post(POST_LOGIN, input);
        }
    }
}