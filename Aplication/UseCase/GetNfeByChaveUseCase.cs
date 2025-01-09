using Aplication.DTO;
using Aplication.Interfaces;
using Domain.Models;
using Microsoft.VisualBasic;
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

        public async Task<ResponseDefault<DanfeNfe>> Execute(Usuario usuario, Parametros parametros)
        {
            var endpoint = "https://backend.4lions.tec.br/dfe/v1/public/GetDANFE";
            var response = await _apiService.GetDataAsync(endpoint, usuario, parametros);

            if (!response.Sucesso) return new ResponseDefault<DanfeNfe>(false, response.Mensagem, null);

            var danfeNfe = JsonSerializer.Deserialize<DanfeNfe>(response.Dados);

            if (danfeNfe == null) return new ResponseDefault<DanfeNfe>(false, "Falha ao tentar deserealizar a DANFE da NF-e", null);

            return new ResponseDefault<DanfeNfe>(true, "OK", danfeNfe);
        }
    }
}
