using Aplication.DTO;
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

        public async Task<ResponseDefault<ListaNfe>> Execute(Usuario usuario, Parametros parametros)
        {
            var endpoint = "https://back-dfe.4lions.com.br/dfe/v1/public/GetListaNFe";
            var response = await _apiService.GetDataAsync(endpoint, usuario, parametros);

            if (!response.Sucesso) return new ResponseDefault<ListaNfe>(false, response.Mensagem, null);

            var listaNfe = JsonSerializer.Deserialize<ListaNfe>(response.Dados);

            if (listaNfe == null) return new ResponseDefault<ListaNfe>(false, "Falha ao tentar deserealizar a Lista da NF-e", null);

            return new ResponseDefault<ListaNfe>(true, "OK", listaNfe);
        }
    }
}

