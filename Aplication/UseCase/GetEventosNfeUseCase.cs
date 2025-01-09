using Aplication.DTO;
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

        public async Task<ResponseDefault<EventosNfe>> Execute(Usuario usuario, Parametros paramentros)
        {
            var endpoint = "https://back-dfe.4lions.com.br/dfe/v1/public/GetEventosNFe";
            var response = await _apiService.GetDataAsync(endpoint, usuario, paramentros);

            if (!response.Sucesso) return new ResponseDefault<EventosNfe>(false, response.Mensagem, null);

            var eventosNfe =  JsonSerializer.Deserialize<EventosNfe>(response.Dados);

            if (eventosNfe == null) return new ResponseDefault<EventosNfe>(false, "Erro ao tentar deserealizar Eventos da NF-e", null);

            return new ResponseDefault<EventosNfe>(true, "OK", eventosNfe);
        }
    }
}
