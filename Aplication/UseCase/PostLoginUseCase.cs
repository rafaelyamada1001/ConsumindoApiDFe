using Aplication.DTO;
using Aplication.Interfaces;
using Domain.Models;
using System.Text.Json;

namespace Aplication.UseCase
{
    public class PostLoginUseCase
    {
        private readonly IApiService _apiService;

        public PostLoginUseCase(IApiService apiService)
        {
            _apiService = apiService;
        }

        public async Task<ResponseDefault<Usuario>> Execute(string email, string senha)
        {
            var requestData = new
            {
                email,
                senha
            };

            var json = JsonSerializer.Serialize(requestData);
            var endpoint = "https://back-dfe.4lions.com.br/dfe/v2/public/PostLogin";            
            var response = await _apiService.PostDataAsync(endpoint, json);

            if (!response.Sucesso) return new ResponseDefault<Usuario>(false, response.Mensagem, null);

            var usuario = JsonSerializer.Deserialize<Usuario>(response.Dados);

            if(usuario == null) return new ResponseDefault<Usuario>(false, "Falha ao tentar deserealizar os Detalhes do Usuário", null);
            if (usuario != null) usuario.Email = email;

            return new ResponseDefault<Usuario>(true, "OK", usuario);
            
        }
    }
}

