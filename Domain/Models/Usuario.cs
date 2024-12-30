using System.Text.Json.Serialization;

namespace Domain.Models
{
    public class Usuario
    {
        public Usuario(string token, string email)
        {
            Token = token;
            Email = email;
        }

        [JsonPropertyName("autorizado")]
        public bool Autorizado { get; private set; }

        [JsonPropertyName("id")]
        public int Id { get; private set; }

        [JsonPropertyName("nome")]
        public string Nome { get; private set; }

        [JsonPropertyName("senha")]
        public string Token { get; private set; }

        [JsonPropertyName("msg")]
        public string? Mensagem { get; private set; }

        [JsonPropertyName("status")]
        public string Status { get; private set; }
        public string Email { get;  set; }

        [JsonPropertyName("empresa")]
        public List<Empresa> Empresas { get; set; } // Lista de empresas associadas ao usuário
    }
}
