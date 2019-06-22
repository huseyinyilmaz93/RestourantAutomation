using RA.Kernel.Entities;
using RA.WindowsConnector.ConnectorInterfaces;

namespace RA.WindowsConnector.Conntectors
{
    public class UserWindowsConnector : AbstractWindowsConnector<UserEntity>, IUserWindowsConnector
    {
        public const string POST_LOGIN = "/User/Login";

        public UserEntity Login(UserEntity input)
        {
            return base.Post(POST_LOGIN, input);
        }
    }
}