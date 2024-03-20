using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BubberDinner.Application.Services.Authentication;
using Microsoft.Extensions.DependencyInjection;
namespace BubberDinner.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            return services.AddScoped<IAuthenticationService, AuthenticationService>();
        }
    }
}
 