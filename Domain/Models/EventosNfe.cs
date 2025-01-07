using System.Text.Json.Serialization;

namespace Domain.Models
{
    public class EventosNfe
    {
        [JsonPropertyName("sucesso")]
        public bool Retorno { get; set; }

        [JsonPropertyName("msg")]
        public string Mensagem { get; set; }

        [JsonPropertyName("listaEvento")]
        public List<EventoNfe> ListaEvento { get; set; }
    }

    public class EventoNfe
    {
        [JsonPropertyName("orgao")]
        public int CodigoOrgao { get; set; }

        [JsonPropertyName("dhEvento")]
        public DateTime HoraEvento { get; set; }

        [JsonPropertyName("tpEvento")]
        public string TipoEvento { get; set; }

        [JsonPropertyName("seqEvento")]
        public int SequencialEvento { get; set; }

        [JsonPropertyName("descEvento")]
        public string Descricao { get; set; }

        [JsonPropertyName("nProt")]
        public string Protocolo { get; set; } // Corrigido para string conforme o JSON

        [JsonPropertyName("xJust")]
        public string Justificativa { get; set; }

        [JsonPropertyName("xCorrecao")]
        public string Motivo { get; set; }

        [JsonPropertyName("xCondUso")]
        public string Condicao { get; set; }

        [JsonPropertyName("periodo")]
        public string Periodo { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("idEvento")]
        public string IdEvento { get; set; }

        [JsonPropertyName("tpEventoInterno")]
        public int TipoEventoInterno { get; set; }
    }
}
