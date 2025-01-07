using System.Text.Json.Serialization;

namespace Domain.Entity
{
    public class EmitenteEndereco
    {
        [JsonPropertyName("logradouro")]
        public string Logradouro { get; private set; }

        [JsonPropertyName("nro")]
        public string Numero { get; private set; }

        [JsonPropertyName("bairro")]
        public string Bairro { get; private set; }

        [JsonPropertyName("municipio")]
        public string Municipio { get; private set; }

        [JsonPropertyName("cep")]
        public string Cep { get; private set; }

    }
}
