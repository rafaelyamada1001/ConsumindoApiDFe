using Aplication.DTO;
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

        public async Task<ResponseDefault<DetalhesNfe>> Execute(Usuario usuario, Parametros parametros)
        {
            var endpoint = "https://back-dfe.4lions.com.br/dfe/v1/public/GetNFe";
            var response = await _apiService.GetDataAsync(endpoint, usuario, parametros);

            if (!response.Sucesso) return new ResponseDefault<DetalhesNfe>(false, response.Mensagem, null);

            var detalhesNfe = JsonSerializer.Deserialize<DetalhesNfe>(response.Dados);

            if (detalhesNfe == null) return new ResponseDefault<DetalhesNfe>(false, "Falha ao tentar deserealizar os Detalhes da NF-e", null);

            return new ResponseDefault<DetalhesNfe>(true, "OK", detalhesNfe);
        }
    }
}
