using System.Text.Json.Serialization;

namespace Domain.Entity
{
    public class Emitente
    {
        [JsonPropertyName("emitente.cnpj")]
        public int Cnpj { get; private set; }

        [JsonPropertyName("emitente.razaoSocial")]
        public string RazaoSocial { get; private set; }

        [JsonPropertyName("emitente.ie")]
        public int InscricaoEstadual { get; private set; }
        
        [JsonPropertyName("emitente.im")]
        public int InscricaoMunicipal { get; private set; }

        [JsonPropertyName("emitente.uf")]
        public string UF { get; private set; }
    }
}
