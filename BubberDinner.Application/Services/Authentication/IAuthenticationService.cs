using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubberDinner.Application.Services.Authentication
{
    public interface IAuthenticationService
    {
        public AuthenticationResult Login(string email, string password);

        public AuthenticationResult Register(string firstname, string lastname, string email, string password);

    }
}
