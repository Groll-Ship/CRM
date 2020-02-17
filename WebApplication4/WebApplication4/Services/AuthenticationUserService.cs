using data;
using data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestWeb.Identity;
using TestWeb.Services.interfaces;

namespace TestWeb.Services
{
    public class AuthenticationUserService : IAuthenticationUserService
    {
        private ApplicationContext _context;

        private List<UserLogin> _users = new List<UserLogin>
        {
            new UserLogin { LoginName="adminName", Password="55", Role = "admin" },
            new UserLogin { LoginName="hrName", Password="5", Role = "hr" }
        };

        public AuthenticationUserService(ApplicationContext context) => _context = context;

        public UserLogin Authenticate(string loginName, string pass)
        {
            if (loginName == null || pass == null) return null;

            UserLogin user = _users.FirstOrDefault(user => user.LoginName == loginName && user.Password == pass);
            //UserLogin user = _context.UserLogins.FirstOrDefault(user => user.LoginName == loginName && user.Password == pass);
            if (user == null) return null;

            user.Password = null;

            return user;
        }
    }
}
