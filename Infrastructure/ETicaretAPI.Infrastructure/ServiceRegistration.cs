using ETicaretAPI.Application.Repositories;
using ETicaretAPI.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace ETicaretAPI.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddInfraStructureServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IFileService,IFileService>();   
        }
    }
}
