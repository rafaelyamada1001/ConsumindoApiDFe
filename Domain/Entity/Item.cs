using System.Text.Json.Serialization;

namespace Domain.Entity
{
    public class Item
    {
        [JsonPropertyName("item.id")]
        public int Id { get; private set; }

        [JsonPropertyName("item.codigo")]
        public int Codigo { get; private set; }

        [JsonPropertyName("item.ean")]
        public int Gtin { get; private set; }

        [JsonPropertyName("item.descricao")]
        public string Descricao { get; private set; }

        [JsonPropertyName("item.unidade")]
        public string UnidadeMedida { get; private set; }

        [JsonPropertyName("item.ncm")]
        public int Ncm { get; private set; }

        [JsonPropertyName("item.cfop")]
        public int Cfop { get; private set; }

        [JsonPropertyName("item.qtde")]
        public int Quantidade { get; private set; }

        [JsonPropertyName("item.vlrUnit")]
        public decimal ValorUnitario { get; private set; }

        [JsonPropertyName("item.vlrTotal")]
        public decimal ValorTotal { get; private set; }
    }
}
