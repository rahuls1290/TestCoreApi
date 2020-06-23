using Microsoft.Extensions.DependencyInjection;
using Services.Employee;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public static class ServiceRegistration
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddTransient<IStaffService, StaffService>();
        }
    }
}
