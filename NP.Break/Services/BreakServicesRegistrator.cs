using Microsoft.Extensions.DependencyInjection;
using NP.Break.Services.Interfaces;
using NP.DAL.Entityes;
using NP.DAL.Interfaces;

namespace NP.Break.Services
{
    public static class BreakServicesRegistrator
    {
        public static IServiceCollection AddBreakServices(this IServiceCollection services) => services
          .AddSingleton<IBreakService, BreakService>(sp =>
          {
              var BreakService = sp.GetRequiredService<IRepository<BreakDbModel>>();
              return new BreakService(BreakService);
          })
         ;
    }
}
