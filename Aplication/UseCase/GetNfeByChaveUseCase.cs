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

        public async Task<PdfNfe> Execute(Usuario usuario)
        {
            var endpoint = "https://back-dfe.4lions.tec.br/dfe/v1/public/GetNFeByChave/:idEmpresa/:chNFe";

            var data = await _apiService.GetDataAsync(endpoint, usuario);
            return JsonSerializer.Deserialize<PdfNfe>(data);
        }
    }
}
