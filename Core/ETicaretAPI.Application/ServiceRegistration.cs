using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace ETicaretAPI.Application
{
    public static class ServiceRegistration
    {
        public static void AddAplicationServices(this IServiceCollection collection)
        {
            //bulunan projedeki tüm handler sınıflarını bulur ve ioc conteyner'ine ekler
            collection.AddMediatR(typeof(ServiceRegistration));
        }
    }
}
