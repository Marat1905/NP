using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using NP.Break.Services;
using NP.Break.Services.Interfaces;
using NP.DAL.Entityes;
using NP.DAL.Interfaces;
using System.Runtime.InteropServices.JavaScript;
using TestConsole.Data;

namespace TestConsole
{
    public class Program
    {
        private static IHost __Host;
        public static async Task Main(string[] args)
        {
            IServiceCollection services = new ServiceCollection();
            // Startup.cs finally :)
            Startup startup = new Startup();
            startup.ConfigureServices(services);
            IServiceProvider serviceProvider = services.BuildServiceProvider();


            IRepository<BreakDbModel>? repository = serviceProvider.GetService<IRepository<BreakDbModel>>();
            IBreakService? breakService = serviceProvider.GetService<IBreakService>();
            breakService.Notify += BreakService_Notify;

        }

        private static void BreakService_Notify(BreakService sender, NP.Break.Infrastructure.EventArgs.BreakEventArgs e)
        {
            throw new NotImplementedException();
        }

        public class Startup
        {
            IConfigurationRoot Configuration { get; }
            private static IHost __Host;
            public Startup()
            {
                var builder = new ConfigurationBuilder()
                    .AddJsonFile("appsettings.json");

                Configuration = builder.Build();


                // IHost Host = __Host ??= Program.CreateHostBuilder(Environment.GetCommandLineArgs()).Build();
                //  IServiceProvider Services = Host.Services;
            }

            public void ConfigureServices(IServiceCollection services) => services
                  .AddLogging()
                  .AddSingleton<IConfigurationRoot>(Configuration)
                  .AddDatabase(Configuration.GetSection("Database"))
                  .AddBreakServices()
                // __Host?.Services.CreateScope().ServiceProvider.GetService<IRepository<BreakDbModel>>()
                ;
            public IHostBuilder CreateHostBuilder(string[] args) =>
             Host.CreateDefaultBuilder(args)
                 .ConfigureServices(ConfigureServices)
              ;


            //{
            //    services.AddLogging();
            //    services.AddSingleton<IConfigurationRoot>(Configuration);
            //    services.AddSingleton<IMyService, MyService>();
            //}
        }
    }
}
