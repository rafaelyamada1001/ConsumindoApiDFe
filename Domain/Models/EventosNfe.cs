using System.Text.Json.Serialization;

namespace Domain.Models
{
    public class EventosNfe
    {
        [JsonPropertyName("ret.sucesso")]
        public bool Retorno { get; private set; }

        [JsonPropertyName("ret.msg")]
        public string Menssagem { get; private set; }

        [JsonPropertyName("listaEvento.orgao")]
        public int CodigoOrgao { get; private set; }

        [JsonPropertyName("listaEvento.dhEvento")]
        public DateTime HoraEvento { get; private set; }

        [JsonPropertyName("listaEvento.tpEvento")]
        public string TipoEvento { get; private set; }

        [JsonPropertyName("listaEvento.seqEvento")]
        public int SequencialEvento { get; private set; }

        [JsonPropertyName("listaEvento.descEvento")]
        public string Descricao { get; private set; }

        [JsonPropertyName("listaEvento.nProt")]
        public int Protocolo { get; private set; }

        [JsonPropertyName("listaEvento.xJust")]
        public string Justificativa { get; private set; }

        [JsonPropertyName("listaEvento.xCorrecao")]
        public string Motivo { get; private set; }

        [JsonPropertyName("listaEvento.xCondUso")]
        public string Condicao { get; private set; }

    }
}
