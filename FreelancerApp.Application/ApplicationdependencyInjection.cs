using FluentValidation;
using FreelancerApp.Application.Services.Abstracts;
using FreelancerApp.Application.Services.Implementations;
using Microsoft.Extensions.DependencyInjection;
using SharpGrip.FluentValidation.AutoValidation.Mvc.Extensions;
using System.Reflection;

namespace FreelancerApp.Application
{
    public static class ApplicationdependencyInjection
    {

        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            services.AddScoped<IProjectService , ProjectService>();
            services.AddScoped<IFreelancerService, FreelancerService>();



            services.AddFluentValidationAutoValidation();
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            return services;
        }

    }
}
