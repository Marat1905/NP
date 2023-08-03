using Microsoft.Extensions.DependencyInjection;
using NP.DAL.Entityes;
using NP.DAL.Interfaces;

namespace NP.DAL
{
    public static class RepositoryRegistrator
    {
        public static IServiceCollection AddRepositoriesInDB(this IServiceCollection services) => services
        .AddTransient<IRepository<BreakDbModel>, EFRepository<BreakDbModel>>()
        .AddTransient<IRepository<СhangeSettingsDbModel>,EFRepository<СhangeSettingsDbModel>>()
          ;
    }
}
