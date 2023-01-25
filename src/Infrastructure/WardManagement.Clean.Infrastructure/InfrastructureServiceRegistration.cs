using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace WardManagement.Clean.Infrastructure
{
    public static class InfrastructureServiceRegistration
    {
       public static IServiceCollection ConfigureInfrastructureService(this IServiceCollection services, IConfiguration configuration)
       {
           return services;
       }

    }
}
