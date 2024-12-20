using System.Text.Json.Serialization;

namespace Domain.Entity
{
    public class FormaPagamento
    {
        [JsonPropertyName("fpgto.nro")]
        public int NumeroSequencia { get; private set; }

        [JsonPropertyName("fpgto.vencimento")]
        public DateTime Vencimento { get; private set; }

        [JsonPropertyName("fpgto.valor")]
        public decimal ValorCobranca { get; private set; }
    }
}
