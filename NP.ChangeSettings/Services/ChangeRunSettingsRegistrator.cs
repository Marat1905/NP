using Microsoft.Extensions.DependencyInjection;
using NP.ChangeSettings.Services.Interfaces;
using NP.DAL.Entityes;
using NP.DAL.Interfaces;

namespace NP.ChangeSettings.Services
{
    public static class ChangeRunSettingsRegistrator
    {
        public static IServiceCollection AddChangeRunSettingsServices(this IServiceCollection services) => services
         .AddSingleton<IChangeRunSettingsService, ChangeRunSettingsService>(sp =>
         {
             var repository = sp.GetRequiredService<IRepository<СhangeSettingsDbModel>>();
             return new ChangeRunSettingsService(repository);
         })
        ;
    }
}
