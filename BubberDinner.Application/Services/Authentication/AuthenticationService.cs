using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubberDinner.Application.Services.Authentication
{
    public class AuthenticationService : IAuthenticationService
    {
        public AuthenticationResult Login(string email, string password)
        {
            return new AuthenticationResult(
              Guid.NewGuid(),
              "firstname",
              "lastname",
              email,
              password);
          
        }
        public AuthenticationResult Register(string firstname, string lastname, string email, string password)
        {
            return new AuthenticationResult(
              Guid.NewGuid(),
              firstname,
              lastname,
              email,
              password);
        }
    }
}
