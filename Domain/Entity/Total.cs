using System.Text.Json.Serialization;

namespace Domain.Entity
{
    public class Total
    {
        [JsonPropertyName("totais.totalBaseICMS")]
        public decimal BaseIcms { get; private set; }
        
        [JsonPropertyName("totais.totalICMS")]
        public decimal Icms { get; private set; }
        
        [JsonPropertyName("totais.totalICMSDeson")]
        public decimal IcmsDesonerado { get; private set; }

        [JsonPropertyName("totais.totalFCP")]
        public decimal Fcp { get; private set; }
        
        [JsonPropertyName("totais.totalBaseICMSST")]
        public decimal BaseIcmsSt { get; private set; }

        [JsonPropertyName("totais.totalICMSST")]
        public decimal IcmsSt { get; private set; }

        [JsonPropertyName("totais.totalFCPST")]
        public decimal FcpSt { get; private set; }
        
        [JsonPropertyName("totais.totalFCPSTRet")]
        public decimal FcpStRetido { get; private set; }

        [JsonPropertyName("totais.totalProdutos")]
        public decimal Produtos { get; private set; }

        [JsonPropertyName("totais.totalFrete")]
        public decimal Frete { get; private set; }

        [JsonPropertyName("totais.totalSeguro")]
        public decimal Seguro { get; private set; }

        [JsonPropertyName("totais.totalDesconto")]
        public decimal Desconto { get; private set; }

        [JsonPropertyName("totais.totalII")]
        public decimal TotalII { get; private set; }

        [JsonPropertyName("totais.totalIPI")]
        public decimal Ipi { get; private set; }
        
        [JsonPropertyName("totais.totalIPIDevol")]
        public decimal IpiDevolvido { get; private set; }

        [JsonPropertyName("totais.totalPIS")]
        public decimal Pis { get; private set; }
        
        [JsonPropertyName("totais.totalCOFINS")]
        public decimal Cofins { get; private set; }
        
        [JsonPropertyName("totais.totalOutrasDesp")]
        public decimal OutrasDespesas { get; private set; }

        [JsonPropertyName("totais.totalNFe")]
        public decimal Nfe { get; private set; }

    }
}
