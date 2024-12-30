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

        public async Task<Usuario?> Execute(string email, string senha)
        {
            var requestData = new
            {
                email,
                senha
            };

            var json = JsonSerializer.Serialize(requestData);
            var endpoint = "https://back-dfe.4lions.com.br/dfe/v2/public/PostLogin";
             
            var response = await _apiService.PostDataAsync(endpoint, json);

            var usuario = JsonSerializer.Deserialize<Usuario>(response);

            if (usuario != null)
            {
                usuario.Email = email;  // Atribui o email manualmente ao Usuario
            }

            return usuario;
        }
    }
}

