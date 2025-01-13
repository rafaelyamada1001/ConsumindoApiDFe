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
                var loginForm = serviceProvider.GetRequiredService<LoginForm>();

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
            services.AddTransient<GetDanfeNfeUseCase>();

            // Registro dos formul�rios
            services.AddTransient<LoginForm>();
            services.AddTransient<GerenciadorDeOpcoesForm>();
            services.AddTransient<MenuDetalhesNfeForm>();
            services.AddTransient<DetalhesNfeForm>();
            services.AddTransient<TotaisForm>();
            services.AddTransient<TransporteForm>();
            services.AddTransient<Informacoes>();
            services.AddTransient<EventosNfeForm>();
        }
    }
}