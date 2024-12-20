using System.Text.Json.Serialization;

namespace Domain.Models
{
    public class PdfNfe
    {
        public bool Sucesso { get; private set; }

        [JsonPropertyName("msg")]
        public string Mensssagem { get; private set; }
        public string? Id { get; private set; }
    }
}
