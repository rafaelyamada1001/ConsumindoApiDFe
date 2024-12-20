using Aplication.Interfaces;
using Infra.Service;
using Microsoft.Extensions.DependencyInjection;
using System.Net.Http;

namespace ConsumindoAPIDFe
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            ApplicationConfiguration.Initialize();

            // Configura��o do cont�iner de servi�os
            var services = new ServiceCollection();
            ConfigureServices(services);

            using (var serviceProvider = services.BuildServiceProvider())
            {
                // Resolve o formul�rio principal
                var loginForm = serviceProvider.GetRequiredService<Login>();

                Application.Run(loginForm);
            }
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            // Registro de depend�ncias
            services.AddHttpClient<IApiService, ApiService>();

            // Registro dos formul�rios
            services.AddTransient<Login>();
            
        }
    }
}