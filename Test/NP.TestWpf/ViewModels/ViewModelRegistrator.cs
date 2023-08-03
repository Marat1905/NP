using Microsoft.Extensions.DependencyInjection;


namespace NP.TestWpf.ViewModels
{
    static class ViewModelRegistrator
    {
        public static IServiceCollection AddViewModels(this IServiceCollection services) => services
          .AddScoped<MainWindowViewModel>()
          ;
    }
}
