using data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestWeb.Identity.interfaces
{
    public interface ITokenGenerator
    {
        public string GenerateToken(UserLogin user);
    }
}
