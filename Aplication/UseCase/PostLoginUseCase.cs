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

        public async Task Execute()
        {
            var data = await _apiService.GetDataAsync("https://back-dfe.4lions.com.br/dfe/v1/public/PostLogin");
            var usuarios = JsonSerializer.Deserialize<List<Usuario>>(data);
        }
    }
}
