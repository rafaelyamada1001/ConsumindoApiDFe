
namespace Domain.Models
{
    internal class TesteDeserializar2
    {
    }
}

public class Rootobject2
{
    public Doc doc { get; set; }
}

public class Doc
{
    public string dataEmissao { get; set; }
    public string dataSaida { get; set; }
    public string dataEscrituracao { get; set; }
    public string chNFe { get; set; }
    public string numero { get; set; }
    public string modelo { get; set; }
    public string serie { get; set; }
    public string natureza { get; set; }
    public string tipoOperacao { get; set; }
    public string tipoEmissao { get; set; }
    public string destinoOperacao { get; set; }
    public string finalidade { get; set; }
    public string modalidadeFrete { get; set; }
    public string infCpl { get; set; }
    public bool cancelada { get; set; }
    public bool manifestada { get; set; }
    public bool ccorrecao { get; set; }
    public Tag tag { get; set; }
    public object cnpjcpfDestinatario { get; set; }
    public object razaoSocialDestinatario { get; set; }
    public string infAdProd { get; set; }
    public Emitente emitente { get; set; }
    public Totais totais { get; set; }
    public Item[] item { get; set; }
    public Fpgto[] fpgto { get; set; }
    public Transp transp { get; set; }
}



public class Emitente
{
    public string cnpj { get; set; }
    public string razaoSocial { get; set; }
    public string nomeFantasia { get; set; }
    public string ie { get; set; }
    public object im { get; set; }
    public string uf { get; set; }
    public Endereco endereco { get; set; }
}

public class Endereco
{
    public string logradouro { get; set; }
    public string nro { get; set; }
    public object cpl { get; set; }
    public string bairro { get; set; }
    public string municipio { get; set; }
    public string cep { get; set; }
}

public class Totais
{
    public float totalBaseICMS { get; set; }
    public float totalICMS { get; set; }
    public float totalICMSDeson { get; set; }
    public float totalFCP { get; set; }
    public float totalBaseICMSST { get; set; }
    public float totalICMSST { get; set; }
    public float totalFCPST { get; set; }
    public float totalFCPSTRet { get; set; }
    public float totalProdutos { get; set; }
    public float totalFrete { get; set; }
    public float totalSeguro { get; set; }
    public float totalDesconto { get; set; }
    public float totalII { get; set; }
    public float totalIPI { get; set; }
    public float totalIPIDevol { get; set; }
    public float totalPIS { get; set; }
    public float totalCOFINS { get; set; }
    public float totalOutrasDesp { get; set; }
    public float totalNFe { get; set; }
}

public class Transp
{
    public string modFrete { get; set; }
    public string transporta_CNPJ { get; set; }
    public string transporta_xNome { get; set; }
    public string transporta_IE { get; set; }
    public string transporta_xEnder { get; set; }
    public string transporta_xMun { get; set; }
    public string transporta_UF { get; set; }
    public decimal? retTransp_vServ { get; set; }
    public decimal? retTransp_vBCRet { get; set; }
    public decimal? retTransp_pICMSRet { get; set; }
    public decimal? retTransp_vICMSRet { get; set; }
    public decimal? retTransp_CFOP { get; set; }
    public decimal? retTransp_cMunFG { get; set; }
    public string veicTransp_placa { get; set; }
    public string veicTransp_UF { get; set; }
    public string veicTransp_RNTC { get; set; }
    public string reboque_placa { get; set; }
    public string reboque_UF { get; set; }
    public string reboque_RNTC { get; set; }
    public string reboque_vagao { get; set; }
    public string reboque_balsa { get; set; }
    public decimal? vol_qVol { get; set; }
    public string vol_esp { get; set; }
    public string vol_marca { get; set; }
    public string vol_nVol { get; set; }
    public decimal? vol_pesoL { get; set; }
    public decimal? vol_pesoB { get; set; }
    public string lacres_nLacre { get; set; }
}

public class Item
{
    public int id { get; set; }
    public string codigo { get; set; }
    public string ean { get; set; }
    public string descricao { get; set; }
    public string unidade { get; set; }
    public string ncm { get; set; }
    public string cest { get; set; }
    public int codExTipi { get; set; }
    public string cfop { get; set; }
    public float qtde { get; set; }
    public float vlrUnit { get; set; }
    public float vlrTotal { get; set; }
    public string eanTrib { get; set; }
    public string unidadeTrib { get; set; }
    public string qtdeTrib { get; set; }
    public string vlrUnitTrib { get; set; }
    public int vlrFrete { get; set; }
    public int vlrSeg { get; set; }
    public float vlrDesc { get; set; }
    public int vlrOutro { get; set; }
    public string indTot { get; set; }
    public string indTotDesc { get; set; }
    public object nroPedido { get; set; }
    public int itemPedido { get; set; }
    public object nroFCI { get; set; }
    public Med med { get; set; }
    public Veicprod veicProd { get; set; }
    public Icms icms { get; set; }
    public Ipi ipi { get; set; }
    public Ii ii { get; set; }
    public Pis pis { get; set; }
    public Cofins cofins { get; set; }
    public Issqn issqn { get; set; }
    public Pisst pisST { get; set; }
    public Cofinsst cofinsST { get; set; }
}

public class Med
{
    public object nLote { get; set; }
    public object qLote { get; set; }
    public object dFab { get; set; }
    public object dVal { get; set; }
    public object vPMC { get; set; }
}

public class Veicprod
{
    public object tpOp { get; set; }
    public object chassi { get; set; }
    public object cCor { get; set; }
    public object xCor { get; set; }
    public object pot { get; set; }
    public object cilin { get; set; }
    public object pesoL { get; set; }
    public object pesoB { get; set; }
    public object nSerie { get; set; }
    public object tpComb { get; set; }
    public object nMotor { get; set; }
    public object cmt { get; set; }
    public object dist { get; set; }
    public object anoMod { get; set; }
    public object anoFab { get; set; }
    public object tpPint { get; set; }
    public object tpVeic { get; set; }
    public object espVeic { get; set; }
    public object vin { get; set; }
    public object condVeic { get; set; }
    public object cMod { get; set; }
    public object cCorDENATRAN { get; set; }
    public object lota { get; set; }
    public object tpRest { get; set; }
}

public class Icms
{
    public string orig { get; set; }
    public string origDesc { get; set; }
    public string cst { get; set; }
    public string cstDesc { get; set; }
    public object modBC { get; set; }
    public object modBCDesc { get; set; }
    public decimal? vBC { get; set; }
    public decimal? pICMS { get; set; }
    public decimal? vICMS { get; set; }
    public string modBCST { get; set; }
    public decimal? pMVAST { get; set; }
    public decimal? pRedBCST { get; set; }
    public object pRedBC { get; set; }
    public decimal? vBCST { get; set; }
    public decimal? pICMSST { get; set; }
    public decimal? vICMSST { get; set; }
    public object vICMSOp { get; set; }
    public object pDif { get; set; }
    public object vICMSDif { get; set; }
    public object pCredSN { get; set; }
    public object vCredICMSSN { get; set; }
    public object vBCSTRet { get; set; }
    public object vICMSSTRet { get; set; }
    public object vICMSDeson { get; set; }
    public object motDesICMS { get; set; }
    public object pBCOp { get; set; }
    public object ufst { get; set; }
    public object vBCSTDest { get; set; }
    public object vICMSSTDest { get; set; }
}

public class Ipi
{
    public string cst { get; set; }
    public string cstDesc { get; set; }
    public object vBC { get; set; }
    public object clEnq { get; set; }
    public object cnpjProd { get; set; }
    public object cSelo { get; set; }
    public int qSelo { get; set; }
    public string cEnq { get; set; }
    public decimal? pIPI { get; set; }
    public object qUnid { get; set; }
    public object vUnid { get; set; }
    public decimal? vIPI { get; set; }
}

public class Ii
{
    public object vBC { get; set; }
    public object vDespAdu { get; set; }
    public object vII { get; set; }
    public object vIOF { get; set; }
}

public class Pis
{
    public string cst { get; set; }
    public string cstDesc { get; set; }
    public decimal? vBC { get; set; }
    public decimal? pPIS { get; set; }
    public decimal? vPIS { get; set; }
    public int? qBCProd { get; set; }
    public int? vAliqProd { get; set; }
}

public class Cofins
{
    public string cst { get; set; }
    public string cstDesc { get; set; }
    public decimal? vBC { get; set; }
    public decimal? pCOFINS { get; set; }
    public int? qBCProd { get; set; }
    public int? vAliqProd { get; set; }
    public decimal? vCOFINS { get; set; }
}

public class Issqn
{
    public object vBC { get; set; }
    public object vAliq { get; set; }
    public object vISSQN { get; set; }
    public object cMunFG { get; set; }
    public object cListServ { get; set; }
    public object vDeducao { get; set; }
    public object vOutro { get; set; }
    public object vDescIncond { get; set; }
    public object vDescCond { get; set; }
    public object vISSRet { get; set; }
    public object indISS { get; set; }
    public object cServico { get; set; }
    public object cMun { get; set; }
    public object cPais { get; set; }
    public object nProcesso { get; set; }
    public object indIncentivo { get; set; }
}

public class Pisst
{
    public object vBC { get; set; }
    public object pPIS { get; set; }
    public object qBCProd { get; set; }
    public object vAliqProd { get; set; }
    public object vPIS { get; set; }
}

public class Cofinsst
{
    public object vBC { get; set; }
    public object pCOFINS { get; set; }
    public object qBCProd { get; set; }
    public object vAliqProd { get; set; }
    public object vCOFINS { get; set; }
}

public class Fpgto
{
    public string nro { get; set; }
    public DateTime vencimento { get; set; }
    public float valor { get; set; }
}
