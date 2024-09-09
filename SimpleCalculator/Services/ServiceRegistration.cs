using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator.Services
{
    public static class ServiceRegistration
    {
        public static void AddMyServices(this IServiceCollection services)
        {
            services.AddTransient<IGreetingService, GreetingService>();
        }
    }
}
