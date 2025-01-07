using Aplication.Interfaces;
using Domain.Models;
using System.Text.Json;

namespace Aplication.UseCase
{
    public class GetListaNfeUseCase
    {
        private readonly IApiService _apiService;

        public GetListaNfeUseCase(IApiService apiService)
        {
            _apiService = apiService;
        }

        public async Task<Rootobject> Execute(Usuario usuario, Parametros parametros)
        {
            var endpoint = "https://back-dfe.4lions.com.br/dfe/v1/public/GetListaNFe";

            var data = await _apiService.GetDataAsync(endpoint, usuario, parametros);
            return JsonSerializer.Deserialize<Rootobject>(data);
        }
    }
}

