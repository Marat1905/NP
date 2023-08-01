using Microsoft.Extensions.DependencyInjection;
using NP.Break.Services.Interfaces;

namespace NP.Break.Services
{
    public static class BreakServicesRegistrator
    {
        public static IServiceCollection AddBreakServices(this IServiceCollection services) => services
          .AddTransient<IBreakService, BreakService>()
         ;
    }
}
