using Aplication.Interfaces;
using Aplication.UseCase;
using Infra.Service;
using Microsoft.Extensions.DependencyInjection;

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
            // Registro de servi�os HTTP
            services.AddHttpClient<IApiService, ApiService>();

            // Registro dos casos de uso
            services.AddTransient<PostLoginUseCase>();
            services.AddTransient<GetListaNfeUseCase>();
            services.AddTransient<GetEventosNfeUseCase>();
            services.AddTransient<GetNfeUseCase>();
            services.AddTransient<GetNfeByChaveUseCase>();

            // Registro dos formul�rios
            services.AddTransient<Login>();
            services.AddTransient<GerenciadorDeOpcoes>();
            services.AddTransient<MenuDetalhesNfe>();
            services.AddTransient<DetalhesNfe>();
            services.AddTransient<Totais>();
            services.AddTransient<Transporte>();
            services.AddTransient<Informacoes>();
        }
    }
}