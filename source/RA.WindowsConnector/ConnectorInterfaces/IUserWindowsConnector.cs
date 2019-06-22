using RA.Kernel.Entities;

namespace RA.WindowsConnector.ConnectorInterfaces
{
    public interface IUserWindowsConnector : IWindowsConnector<UserEntity>
    {
        UserEntity Login(UserEntity input);
    }
}