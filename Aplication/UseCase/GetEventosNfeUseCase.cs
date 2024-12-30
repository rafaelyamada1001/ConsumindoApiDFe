using Aplication.Interfaces;
using Domain.Models;
using System.Text.Json;

namespace Aplication.UseCase
{
    public class GetEventosNfeUseCase
    {
        private readonly IApiService _apiService;

        public GetEventosNfeUseCase(IApiService apiService)
        {
            _apiService = apiService;
        }

        public async Task<EventosNfe> Execute(Usuario usuario, Parametros paramentros)
        {
            var endpoint = "https://back-dfe.4lions.com.br/dfe/v1/public/GetEventosNFe";

            var data = await _apiService.GetDataAsync(endpoint, usuario, paramentros);
            return JsonSerializer.Deserialize<EventosNfe>(data);
        }
    }
}
