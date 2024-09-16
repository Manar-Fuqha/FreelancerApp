using FreelancerApp.Application.Services.Abstracts;
using FreelancerApp.Application.Services.Implementations;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreelancerApp.Application
{
    public static class ApplicationdependencyInjection
    {

        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            services.AddScoped<IProjectService , ProjectService>();
            services.AddScoped<IFreelancerService, FreelancerService>();

            return services;
        }

    }
}
