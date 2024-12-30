using System.Text.Json.Serialization;

namespace Domain.Models
{
    public class Perfil
    {
        [JsonPropertyName("nfeDownload")]
        public string NfeDownload { get; set; }

        [JsonPropertyName("cteDownload")]
        public string CteDownload { get; set; }

        [JsonPropertyName("nfseEmissao")]
        public string NfseEmissao { get; set; }
    }
}
