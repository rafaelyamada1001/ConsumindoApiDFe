using System.Text.Json.Serialization;

namespace Domain.Models
{
    public class Parametros
    {
        [JsonPropertyName("idEmpresa")]
        public string? Empresa { get; set; }
        [JsonPropertyName("chNFe")]
        public string? Chave { get; set; }
        public string? DataInicial { get; set; }
        public string? DataFinal { get; set; }
        public string? Modelo { get; set; }
        public string? Tipo { get; set; }
        public string? Emissao { get; set; }
        public string? Numero { get; set; }
        public string? CnpjCpf { get; set; }
        public string? RazaoSocial { get; set; }
    }

}

