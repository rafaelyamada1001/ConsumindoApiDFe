using Aplication.Interfaces;
using Domain.Models;
using System.Text.Json;

namespace Aplication.UseCase
{
    public class GetNfeUseCase
    {
        private readonly IApiService _apiService;

        public GetNfeUseCase(IApiService apiService)
        {
            _apiService = apiService;
        }

        public async Task<Rootobject2>Execute(Usuario usuario, Parametros parametros)
        {
            var endpoint = "https://back-dfe.4lions.com.br/dfe/v1/public/GetNFe";

            var data = await _apiService.GetDataAsync(endpoint, usuario, parametros);
            return JsonSerializer.Deserialize<Rootobject2>(data);
        }
    }
}
