using System.Text.Json.Serialization;

namespace Domain.Entity
{
    public class EmitenteEndereco
    {
        [JsonPropertyName("emitente.endereco.logradouro")]
        public string Logradouro { get; private set; }

        [JsonPropertyName("emitente.endereco.nro")]
        public int Numero { get; private set; }

        [JsonPropertyName("emitente.endereco.cpl")]
        public string? Complemento { get; private set; }

        [JsonPropertyName("emitente.endereco.bairro")]
        public string Bairro { get; private set; }

        [JsonPropertyName("emitente.endereco.municipio")]
        public string Municipio { get; private set; }

        [JsonPropertyName("emitente.endereco.cep")]
        public int Cep { get; private set; }

    }
}
