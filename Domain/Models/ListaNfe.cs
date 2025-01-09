namespace Domain.Models
{
    public class ListaNfe
    {
        public Ret ret { get; set; }
        public Resumo resumo { get; set; }
        public Listanfe[] listaNFe { get; set; }
    }

    public class Ret
    {
        public bool sucesso { get; set; }
        public string msg { get; set; }
        public string id { get; set; }
    }

    public class Resumo
    {
        public int qtRegistros { get; set; }
        public float vlrTotal { get; set; }
        public int qtRegistrosCanceladas { get; set; }
        public float vlrCanceladas { get; set; }
    }

    public class Listanfe
    {
        public bool flag { get; set; }
        public string chave { get; set; }
        public int numero { get; set; }
        public int modelo { get; set; }
        public string cnpjcpf { get; set; }
        public string razaoSocial { get; set; }
        public DateTime dthrEmissao { get; set; }
        public string natOp { get; set; }
        public string tipo { get; set; }
        public string emissao { get; set; }
        public float valor { get; set; }
        //public int idEmpresa { get; set; }
        //public int id { get; set; }
        //public int serie { get; set; }
        //public object dtEscrituracao { get; set; }
        //public int situacao { get; set; }
        //public DateTime dthrCad { get; set; }
        //public bool cancelada { get; set; }
        //public bool manifestada { get; set; }
        //public bool ccorrecao { get; set; }
        //public bool conferida { get; set; }
        //public Tag tag { get; set; }
    }

    public class Tag
    {
        public int id { get; set; }
        public string letra { get; set; }
        public string cor { get; set; }
        public string descricao { get; set; }
        public DateTime dtCadastro { get; set; }
        public DateTime dtAlteracao { get; set; }
    }
}
