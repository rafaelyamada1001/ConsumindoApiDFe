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
            var response = await _apiService.PostDataAsync("https://back-dfe.4lions.com.br/dfe/v1/public/PostLogin", json);
            
            return JsonSerializer.Deserialize<Usuario>(response);
        }
    }
}
