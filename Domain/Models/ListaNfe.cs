using System.Text.Json.Serialization;

namespace Domain.Models
{
    public class ListaNfe
    {
        [JsonPropertyName("ret.sucesso")]
        public bool Retorno { get; private set; }

        [JsonPropertyName("ret.msg")]
        public string Menssagem { get; private set; }

        [JsonPropertyName("listaNFe.idEmpresa")]
        public int IdEmpresa { get; private set; }

        [JsonPropertyName("listaNFe.id")]
        public int IdNfe { get; private set; }

        [JsonPropertyName("listaNFe.chave")]
        public int Chave { get; private set; }

        [JsonPropertyName("listaNFe.natOp")]
        public int NaturezaOperacao { get; private set; }

        [JsonPropertyName("listaNFe.numero")]
        public int Numero { get; private set; }

        [JsonPropertyName("listaNFe.serie")]
        public int Serie { get; private set; }

        [JsonPropertyName("listaNFe.modelo")]
        public int Modelo { get; private set; }

        //CNPJ/CPF do emitente da nota fiscal
        [JsonPropertyName("listaNFe.cnpjcpf")]
        public int Documento { get; private set; }

        [JsonPropertyName("listaNFe.razaoSocial")]
        public string RazaoSocial { get; private set; }

        [JsonPropertyName("listaNFe.dthrEmissao")]
        public DateTime Emissao { get; private set; }

        [JsonPropertyName("listaNFe.tipo")]
        public string TipoNfe { get; private set; }

        [JsonPropertyName("listaNFe.emissao")]
        public string TipoEmissao { get; private set; }

        [JsonPropertyName("listaNFe.valor")]
        public decimal Valor { get; private set; }

        [JsonPropertyName("listaNFe.situacao")]
        public string SituacaoNfe { get; private set; }

        //Data e hora que entrou no sistema
        [JsonPropertyName("listaNFe.dthrCad")]
        public DateTime EntradaSistema { get; private set; }

        [JsonPropertyName("listaNFe.cancelada")]
        public bool Cancelada { get; private set; }

        [JsonPropertyName("listaNFe.manifestada")]
        public bool Manifestada { get; private set; }

        [JsonPropertyName("listaNFe.ccorrecao")]
        public bool CartaCorrecao { get; private set; }

        [JsonPropertyName("listaNFe.conferida")]
        public bool Conferida { get; private set; }

        [JsonPropertyName("resumo.qtRegistros")]
        public int QtdeTotal { get; private set; }

        [JsonPropertyName("resumo.vlrTotal")]
        public decimal ValorTotal { get; private set; }

        [JsonPropertyName("resumo.qtRegistrosCanceladas")]
        public int QtdeTotalCanceladas { get; private set; }

        [JsonPropertyName("resumo.vlrCanceladas")]
        public decimal ValorTotalCanceladas { get; private set; }
    }
}
