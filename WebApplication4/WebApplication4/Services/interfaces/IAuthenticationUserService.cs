using data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestWeb.Services.interfaces
{
    public interface IAuthenticationUserService
    {
        public UserLogin Authenticate(string loginName, string pass);
    }
}
