using Domain.Entity;
using System.Text.Json.Serialization;

namespace Domain.Models
{
    public class DetalhesNfe
    {
        [JsonPropertyName("dataEmissao")]
        public DateTime DataEmissao { get; private set; }

        [JsonPropertyName("dataSaida")]
        public DateTime DataSaida { get; private set; }

        [JsonPropertyName("chNFe")]
        public int ChaveNfe { get; private set; }

        [JsonPropertyName("numero")]
        public int NumeroDocumento { get; private set;}
        
        [JsonPropertyName("modelo")]
        public int ModeloDocumento { get; private set;} 
        
        [JsonPropertyName("serie")]
        public int SerieDocumento { get; private set;}

        [JsonPropertyName("natureza")]
        public string DescricaoNatureza { get; private set; }

        [JsonPropertyName("tipoOperacao")]
        public string TipoOperacaoDocumento { get; private set; }

        [JsonPropertyName("tipoEmissao")]
        public string TipoEmissaoDocumento { get; private set; }

        [JsonPropertyName("destinoOperacao")]
        public string DestinoOperacao { get; private set; }

        [JsonPropertyName("finalidade")]
        public string FinalidadeDocumento { get; private set; }

        [JsonPropertyName("modalidadeFrete")]
        public string ModalidadeFrete { get; private set; }

        [JsonPropertyName("infCpl")]
        public string InformacoesComplementarDocumento { get; private set; }

        [JsonPropertyName("cancelada")]
        public bool Cancelada { get; private set; }

        [JsonPropertyName("manifestada")]
        public bool Manifestada { get; private set; }

        [JsonPropertyName("ccorrecao")]
        public bool CartaDeCorrecao { get; private set; }

        [JsonPropertyName("cnpjcpfDestinatario")]
        public int DocumentoDestinatario { get; private set; }

        [JsonPropertyName("razaoSocialDestinatario")]
        public string RazaoSocialDestinatrio { get; private set; }

        [JsonPropertyName("infAdProd")]
        public string InformacoesAdicionaisProduto { get; private set; }

        [JsonPropertyName("emitente")]
        public Emitente Emitente { get; private set; }

        [JsonPropertyName("emitente.endereco")]
        public EmitenteEndereco EnderecoEmitente { get; private set; }

        [JsonPropertyName("totais")]
        public Total Totais { get; private set; }

        [JsonPropertyName("item")]
        public Item Item { get; private set; }

        [JsonPropertyName("fpgto")]
        public FormaPagamento Pagamento { get; private set; }

        [JsonPropertyName("transp")]
        public Transportador Transportadora { get; private set; }

    }
}
