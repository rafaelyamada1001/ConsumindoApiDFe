using System.Text.Json.Serialization;

namespace Domain.Models
{
    public class ListaNfe
    {
        [JsonPropertyName("ret")]
        public Retorno Retorno { get; private set; }

        [JsonPropertyName("resumo")]
        public Resumo Resumo { get; private set; }

        [JsonPropertyName("listaNFe")]
        public List<NotaFiscal> Notas { get; private set; }
    }

    public class Retorno
    {
        [JsonPropertyName("sucesso")]
        public bool Sucesso { get; private set; }

        [JsonPropertyName("msg")]
        public string Mensagem { get; private set; }

        [JsonPropertyName("id")]
        public string Id { get; private set; }
    }

    public class Resumo
    {
        [JsonPropertyName("qtRegistros")]
        public int QtdeTotal { get; private set; }

        [JsonPropertyName("vlrTotal")]
        public decimal ValorTotal { get; private set; }

        [JsonPropertyName("qtRegistrosCanceladas")]
        public int QtdeCanceladas { get; private set; }

        [JsonPropertyName("vlrCanceladas")]
        public decimal ValorCancelado { get; private set; }
    }

    public class NotaFiscal
    {
        [JsonPropertyName("idEmpresa")]
        public int IdEmpresa { get; private set; }

        [JsonPropertyName("id")]
        public int Id { get; private set; }

        [JsonPropertyName("chave")]
        public string Chave { get; private set; }

        [JsonPropertyName("natOp")]
        public string NaturezaOperacao { get; private set; }

        [JsonPropertyName("numero")]
        public int Numero { get; private set; }

        [JsonPropertyName("serie")]
        public int Serie { get; private set; }

        [JsonPropertyName("modelo")]
        public int Modelo { get; private set; }

        [JsonPropertyName("cnpjcpf")]
        public string DocumentoEmitente { get; private set; }

        [JsonPropertyName("razaoSocial")]
        public string RazaoSocial { get; private set; }

        [JsonPropertyName("dthrEmissao")]
        public DateTime DataHoraEmissao { get; private set; }

        [JsonPropertyName("tipo")]
        public string Tipo { get; private set; }

        [JsonPropertyName("emissao")]
        public string TipoEmissao { get; private set; }

        [JsonPropertyName("valor")]
        public decimal Valor { get; private set; }

        [JsonPropertyName("situacao")]
        public int Situacao { get; private set; }

        [JsonPropertyName("dthrCad")]
        public DateTime DataHoraCadastro { get; private set; }

        [JsonPropertyName("cancelada")]
        public bool Cancelada { get; private set; }

        [JsonPropertyName("manifestada")]
        public bool Manifestada { get; private set; }

        [JsonPropertyName("ccorrecao")]
        public bool CartaCorrecao { get; private set; }

        [JsonPropertyName("conferida")]
        public bool Conferida { get; private set; }

        [JsonPropertyName("tag")]
        public Tag Tag { get; private set; }
    }
    public class Tag
    {
        [JsonPropertyName("id")]
        public int Id { get; private set; }

        [JsonPropertyName("letra")]
        public string Letra { get; private set; }

        [JsonPropertyName("cor")]
        public string Cor { get; private set; }

        [JsonPropertyName("descricao")]
        public string Descricao { get; private set; }

        [JsonPropertyName("dtCadastro")]
        public DateTime? DataCadastro { get; private set; }

        [JsonPropertyName("dtAlteracao")]
        public DateTime? DataAlteracao { get; private set; }
    }
}
