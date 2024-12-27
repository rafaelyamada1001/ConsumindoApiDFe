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
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, "https://back-dfe.4lions.com.br/dfe/v1/public/GetListaNFe");
            request.Headers.Add("email", usuario.Email);
            request.Headers.Add("senha", usuario.Token);
            
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();

            //var response = await _httpClient.GetAsync(endpoint);
            //response.EnsureSuccessStatusCode();
            //return await response.Content.ReadAsStringAsync();
        }
        public async Task<string> PostDataAsync(string endpoint, string jsonContent)
        {
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync(endpoint, content);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }

    }
}
