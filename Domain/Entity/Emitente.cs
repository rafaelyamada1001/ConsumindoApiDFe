using System.Text.Json.Serialization;

namespace Domain.Entity
{
    public class Emitente
    {
        [JsonPropertyName("cnpj")]
        public string Cnpj { get; private set; }

        [JsonPropertyName("razaoSocial")]
        public string RazaoSocial { get; private set; }

        [JsonPropertyName("nomeFantasia")]
        public string NomeFantasia { get; private set; }

        [JsonPropertyName("endereco")]
        public EmitenteEndereco Endereco { get; private set; }
    }
}
