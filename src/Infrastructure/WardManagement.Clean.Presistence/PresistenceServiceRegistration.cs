using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace WardManagement.Clean.Presistence
{
    public static class PresistenceServiceRegistration
    {
        public static IServiceCollection ConfigurePresistenceService(this IServiceCollection services, IConfiguration configuration)
        {
            return services;
        }
    }
}