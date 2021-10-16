using Microsoft.Extensions.DependencyInjection;
using NumberEncoding.Data.Contract;
using NumberEncoding.Data.Implementation;
using NumberEncoding.Service.Contract;
using NumberEncoding.Service.Implementation;

namespace NumberEncoding.ConsoleApp
{
    public class ServiceRegistration
    {
        public static ServiceProvider GetServiceProvider()
        {
            var serviceProvider = new ServiceCollection()
                .AddTransient<INumberEncodingData, NumberEncodingData>()
                .AddTransient<INumberEncodingService, NumberEncodingService>()
                .BuildServiceProvider();

            return serviceProvider;
        }
    }
}
