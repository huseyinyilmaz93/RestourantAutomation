using RA.Kernel.Common;
using RA.Kernel.Entities;
using System;
using System.Threading.Tasks;

namespace RA.WindowsConnector.ConnectorInterfaces
{
    public interface IUserWindowsConnector : IWindowsConnector<UserEntity>
    {
        Response<UserEntity> Login(UserEntity input);
    }
}