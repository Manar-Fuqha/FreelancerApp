using FreelancerApp.Domain;
using FreelancerApp.Domain.Abstracts;
using FreelancerApp.Infrastructure.Implementation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreelancerApp.Infrastructure
{
    public static class InfrastructuredependencyInjection
    {

        public static IServiceCollection AddInfrastuctureServices (this IServiceCollection services)
        {

            services.AddScoped<IProjectRepository , ProjectRepository>();
            services.AddScoped<IFreelancerRepository , FreelancerRepository>();
            services.AddScoped(typeof(IUnitOfWork<>), typeof(UnitOfWork<>));

            return services;
        }

    }
}
