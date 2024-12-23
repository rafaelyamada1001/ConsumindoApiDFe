using Aplication.Interfaces;
using System.Text;

namespace Infra.Service
{
    public class ApiService : IApiService

    {
        private readonly HttpClient _httpClient;

        public ApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> GetDataAsync(string endpoint)
        {
            var response = await _httpClient.GetAsync(endpoint);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> PostDataAsync(string endpoint, string jsonContent)
        {
            try
            {
                // Configura o conteúdo da requisição
                var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                // Envia a requisição POST
                var response = await _httpClient.PostAsync(endpoint, content);

                // Verifica se a resposta indica sucesso
                response.EnsureSuccessStatusCode();

                // Retorna o conteúdo da resposta como string
                return await response.Content.ReadAsStringAsync();
            }
            catch (HttpRequestException ex)
            {
                // Log ou tratamento do erro para depuração
                throw new Exception($"Erro ao enviar requisição: {ex.Message}");
            }
        }
    }
}
