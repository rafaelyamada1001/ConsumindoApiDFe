using Aplication.Interfaces;
using Domain.Models;
using System.Text.Json;

namespace Aplication.UseCase
{
    public class GetNfeByChaveUseCase
    {
        private readonly IApiService _apiService;

        public GetNfeByChaveUseCase(IApiService apiService)
        {
            _apiService = apiService;
        }

        public async Task<PdfNfe> Execute(Usuario usuario, Parametros parametros)
        {
            var endpoint = "https://backend.4lions.tec.br/dfe/v1/public/GetDANFE";

            var data = await _apiService.GetDataAsync(endpoint, usuario, parametros);
            return JsonSerializer.Deserialize<PdfNfe>(data);
        }
    }
}
