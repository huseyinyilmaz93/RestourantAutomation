using System;
using RA.Kernel.Entities;

namespace RA.Kernel.Common
{
    public class Response<T> 
    {
        public T Result;

        public int StatusCode { get; set; }

        public bool HasError { get; set; }

        public string Message { get; set; }

        public Response<UserEntity> CallbackAction(object loginCallBack)
        {
            throw new NotImplementedException();
        }
    }
}
