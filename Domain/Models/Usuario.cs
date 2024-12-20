using System.Text.Json.Serialization;

namespace Domain.Models
{
    public class Usuario
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }

        [JsonPropertyName("senha")]
        public string Token { get; private set; }
        public string? Menssagem { get; private set; }
        public string Status { get; private set; }
    }
}
