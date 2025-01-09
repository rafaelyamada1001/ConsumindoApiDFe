using Aplication.DTO;
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

        public async Task<ResponseDefault<string>> GetDataAsync(string endpoint, Usuario usuario, Parametros parametros)
        {
            var uriBuilder = new UriBuilder(endpoint);

            var query = new List<string>();

            if (!string.IsNullOrEmpty(parametros.Empresa))
                query.Add($"empresa={Uri.EscapeDataString(parametros.Empresa)}");

            if (!string.IsNullOrEmpty(parametros.Chave))
                query.Add($"chave={Uri.EscapeDataString(parametros.Chave)}");

            if (!string.IsNullOrEmpty(parametros.DataInicial))
                query.Add($"dataInicial={Uri.EscapeDataString(parametros.DataInicial)}");

            if (!string.IsNullOrEmpty(parametros.DataFinal))
                query.Add($"dataFinal={Uri.EscapeDataString(parametros.DataFinal)}");

            if (!string.IsNullOrEmpty(parametros.Modelo))
                query.Add($"modelo={Uri.EscapeDataString(parametros.Modelo)}");

            if (!string.IsNullOrEmpty(parametros.Tipo))
                query.Add($"tipo={Uri.EscapeDataString(parametros.Tipo)}");

            if (!string.IsNullOrEmpty(parametros.Emissao))
                query.Add($"emissao={Uri.EscapeDataString(parametros.Emissao)}");

            if (!string.IsNullOrEmpty(parametros.Numero))
                query.Add($"numero={Uri.EscapeDataString(parametros.Numero)}");

            if (!string.IsNullOrEmpty(parametros.CnpjCpf))
                query.Add($"cnpjcpf={Uri.EscapeDataString(parametros.CnpjCpf)}");

            if (!string.IsNullOrEmpty(parametros.RazaoSocial))
                query.Add($"razaoSocial={Uri.EscapeDataString(parametros.RazaoSocial)}");

            query.Add("page=1");

            uriBuilder.Query = string.Join("&", query);


            var request = new HttpRequestMessage(HttpMethod.Get, uriBuilder.Uri);

            request.Headers.Add("email", usuario.Email);
            request.Headers.Add("senha", usuario.Token);

            try
            {
                var response = await _httpClient.SendAsync(request);
                response.EnsureSuccessStatusCode();
                var data = await response.Content.ReadAsStringAsync();


                return new ResponseDefault<string>(true,"OK", data);
            }
            catch (Exception ex)
            {
                return new ResponseDefault<string>(false, $"Erro:{ex.Message}", null);
            }
        }
        public async Task<ResponseDefault<string>> PostDataAsync(string endpoint, string jsonContent)
        {
            try
            {
                var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
                var response = await _httpClient.PostAsync(endpoint, content);
                response.EnsureSuccessStatusCode();

                var data = await response.Content.ReadAsStringAsync();

                return new ResponseDefault<string>(true,"OK", data);
            }
            catch (Exception ex)
            {
                return new ResponseDefault<string>(false, $"Erro{ex.Message}", null);
            }
        }

    }
}
