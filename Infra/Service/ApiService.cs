using Aplication.Interfaces;
using Domain.Models;
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

        public async Task<string> GetDataAsync(string endpoint, Usuario usuario, Parametros parametros)
        {
            var uriBuilder = new UriBuilder(endpoint);

            var query = new List<string>
            {
                $"idEmpresa={Uri.EscapeDataString(parametros.Empresa)}",
                $"chNFe={Uri.EscapeDataString(parametros.Chave)}",
                //$"dataInicial={Uri.EscapeDataString(parametros.DataInicial)}",
                //$"dataFinal={Uri.EscapeDataString(parametros.DataFinal)}",
                //$"modelo={Uri.EscapeDataString(parametros.Modelo)}",
                //$"tipo={Uri.EscapeDataString(parametros.Tipo)}",
                //$"emissao={Uri.EscapeDataString(parametros.Emissao)}",
                //$"numero={Uri.EscapeDataString(parametros.Numero)}",
                //$"cnpjcpf={Uri.EscapeDataString(parametros.CnpjCpf)}",
                //$"razaoSocial={Uri.EscapeDataString(parametros.RazaoSocial)}",
                 
            };

            uriBuilder.Query = string.Join("&", query);

            var request = new HttpRequestMessage(HttpMethod.Get, uriBuilder.Uri);

            // Adiciona os headers necessários
            request.Headers.Add("email", usuario.Email);
            request.Headers.Add("senha", usuario.Token);

            // Envia a requisição
            var response = await _httpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsStringAsync();
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
