using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace WardManagement.Clean.Application
{
    public static class ApplicationServiceRegistration
    {
       public static IServiceCollection ConfigureApplicationService(this IServiceCollection services, IConfiguration configuration)
       {
           return services;
       }
    }
}
