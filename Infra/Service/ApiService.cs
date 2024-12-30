using Aplication.Interfaces;
using Domain.Models;
using System.Net.Http;
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

        public async Task<string> GetDataAsync(string endpoint, Usuario usuario)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, endpoint);

            // Adicionando os headers
            request.Headers.Add("email", usuario.Email);
            request.Headers.Add("senha", usuario.Token);

            // Enviando a requisição
            var response = await _httpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsStringAsync();
        }
        public async Task<string> PostDataAsync(string endpoint, string jsonContent)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, endpoint)
            {
                Content = new StringContent(jsonContent, Encoding.UTF8, "application/json")
            };

            var response = await _httpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsStringAsync();
        }

    }
}
