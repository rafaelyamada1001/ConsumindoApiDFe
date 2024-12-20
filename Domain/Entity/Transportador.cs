using System.Text.Json.Serialization;

namespace Domain.Entity
{
    public class Transportador
    {
        [JsonPropertyName("transp.modFrete")]
        public string ModalidadeFrete { get; private set; }

        [JsonPropertyName("transp.transporta_CNPJ")]
        public int Documento { get; private set; }

        [JsonPropertyName("transp.transporta_xNome")]
        public string RazaoSocial { get; private set; }

        [JsonPropertyName("transp.transporta_IE")]
        public int InscricaoEstadual { get; private set; }

        [JsonPropertyName("transp.transporta_xEnder")]
        public string Endereco { get; private set; }

        [JsonPropertyName("transp.transporta_xMun")]
        public string Municipio { get; private set; }

        [JsonPropertyName("transp.transporta_UF")]
        public string UfTrasnportador { get; private set; }

        [JsonPropertyName("transp.retTransp_vServ")]
        public decimal ValorServico { get; private set; }

        [JsonPropertyName("transp.retTransp_vBCRet")]
        public int RetencaoBc { get; private set; }

        [JsonPropertyName("transp.retTransp_pICMSRet")]
        public int AliquotaRetencao { get; private set; }

        [JsonPropertyName("transp.retTransp_vICMSRet")]
        public decimal IcmsRetido { get; private set; }

        [JsonPropertyName("transp.retTransp_CFOP ")]
        public int Cfop { get; private set; }

        [JsonPropertyName("transp.retTransp_cMunFG")]
        public int CodigoMunicipio { get; private set; }

        [JsonPropertyName("transp.veicTransp_placa")]
        public string PlacaVeiculo { get; private set; }

        [JsonPropertyName("transp.veicTransp_UF")]
        public string UfVeiculo { get; private set; }

        [JsonPropertyName("transp.veicTransp_RNTC")]
        public int RegistroTransportador { get; private set; }

        [JsonPropertyName("transp.reboque_placa")]
        public string PlacaVeiculoReboque { get; private set; }

        [JsonPropertyName("transp.reboque_UF")]
        public string UfReboque { get; private set; }

        [JsonPropertyName("transp.reboque_RNTC ")]
        public int RegistroTransportadorReboque { get; private set; }

        [JsonPropertyName("transp.reboque_vagao")]
        public string IdentificacaoVagaoReboque { get; private set; }

        [JsonPropertyName("transp.reboque_balsa")]
        public string IdentificacaoBalsaReboque { get; private set; }

        [JsonPropertyName("transp.vol_qVol")]
        public string QuantidadeVolumes { get; private set; }

        [JsonPropertyName("transp.vol_esp")]
        public string EspecieVolumes { get; private set; }

        [JsonPropertyName("transp.vol_marca")]
        public string MarcaVolumes { get; private set; }

        [JsonPropertyName("transp.vol_nVol")]
        public int NumeracaoVolumes { get; private set; }

        [JsonPropertyName("transp.vol_pesoL")]
        public int PesoLiquido { get; private set; }
        
        [JsonPropertyName("transp.vol_pesoB")]
        public int PesoBruto { get; private set; }

        [JsonPropertyName("transp.lacres_nlacre")]
        public int NumeroLacre { get; private set; }
    }
}
