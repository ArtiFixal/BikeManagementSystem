using BikeManagementSystemLib;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BikeManagementSystemDesktop
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json",false,true)
                .Build();
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IConfiguration>(config)
                .AddDbContext<BikeManagementDbContext>(options =>
                    options.UseSqlServer(config.GetConnectionString("DefaultConnection"))
                )
                .BuildServiceProvider();
            var dbContext=serviceProvider.GetRequiredService<BikeManagementDbContext>();
            ApplicationConfiguration.Initialize();
            Application.Run(new MainView(dbContext));
        }
    }
}