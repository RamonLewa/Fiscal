using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiscal
{
    public class VendaNFCe
    {
        [DisplayName("Código")]
        public int Controle { get; set; }

        [DisplayName("Cliente")]
        public string Cliente { get; set; }

        [DisplayName("Data e Hora de Cadastro")]
        public DateTime? DataEHoraCadastro { get; set; }

        [DisplayName("Data de Emissão")]
        public DateTime? DataEmissao { get; set; }

        [DisplayName("Número NFCE")]
        public int? NumeroNFCE { get; set; }

        [DisplayName("Número SAT")]
        public int? NumeroSAT { get; set; }

        [DisplayName("Tipo de Ambiente")]
        public string TipoAmbiente { get; set; }

        [DisplayName("Chave NFCE")]
        public string ChaveNFCE { get; set; }

        [DisplayName("Protocolo")]
        public string Protocolo { get; set; }

        [DisplayName("Protocolo de Cancelamento")]
        public string ProtocoloCancelamento { get; set; }

        [DisplayName("Código de Status")]
        public int? CodigoStatus { get; set; }

        [DisplayName("Status de Envio")]
        public string StatusEnvio { get; set; }

        [DisplayName("Inutilizada")]
        public string Inutilizada { get; set; }

        [DisplayName("Código Cliente")]
        public int? CodCliente { get; set; }

        [DisplayName("Código Funcionário")]
        public int? CodFuncionario { get; set; }

        [DisplayName("Funcionário")]
        public string Funcionario { get; set; }

        [DisplayName("Código Centro de Custo")]
        public int? CodCentroCusto { get; set; }

        [DisplayName("Centro de Custo")]
        public string CentroCusto { get; set; }

        [DisplayName("Valor do Produto")]
        public decimal? ValorProduto { get; set; }

        [DisplayName("Percentual de Acréscimo")]
        public decimal? PercAcrescimo { get; set; }

        [DisplayName("Valor do Acréscimo")]
        public decimal? ValorAcrescimo { get; set; }

        [DisplayName("Percentual de Desconto")]
        public decimal? PercDesconto { get; set; }

        [DisplayName("Valor do Desconto")]
        public decimal? ValorDesconto { get; set; }

        [DisplayName("Valor do Desconto Item")]
        public decimal? ValorDescontoItem { get; set; }

        [DisplayName("Valor BC ICMS")]
        public decimal? ValorBCICMS { get; set; }

        [DisplayName("Valor ICMS")]
        public decimal? ValorICMS { get; set; }

        [DisplayName("Valor BC ST")]
        public decimal? ValorBCST { get; set; }

        [DisplayName("Valor ST")]
        public decimal? ValorST { get; set; }

        [DisplayName("Valor PIS")]
        public decimal? ValorPIS { get; set; }

        [DisplayName("Valor COFINS")]
        public decimal? ValorCOFINS { get; set; }

        [DisplayName("Valor do Seguro")]
        public decimal? ValorSeguro { get; set; }

        [DisplayName("Valor Outros")]
        public decimal? ValorOutros { get; set; }

        [DisplayName("Valor Outros Item")]
        public decimal? ValorOutrosItem { get; set; }

        [DisplayName("Valor BC Serviço")]
        public decimal? ValorBCServico { get; set; }

        [DisplayName("Valor ISS")]
        public decimal? ValorISS { get; set; }

        [DisplayName("Valor Serviço")]
        public decimal? ValorServico { get; set; }

        [DisplayName("Valor Total NFCE")]
        public decimal? ValorTotalNFCE { get; set; }

        [DisplayName("Natureza da Operação")]
        public string NaturezaOperacao { get; set; }

        [DisplayName("Modelo")]
        public string Modelo { get; set; }

        [DisplayName("Série")]
        public string Serie { get; set; }

        [DisplayName("Data Saída/Entrada")]
        public DateTime? DataSaidaEntrada { get; set; }

        [DisplayName("Hora Saída/Entrada")]
        public TimeSpan? HoraSaidaEntrada { get; set; }

        [DisplayName("Tipo de Emissão")]
        public string TipoEmissao { get; set; }

        [DisplayName("Telefone do Cliente")]
        public string FoneCliente { get; set; }

        [DisplayName("CEP do Cliente")]
        public string CEPCliente { get; set; }

        [DisplayName("Endereço do Cliente")]
        public string EnderecoCliente { get; set; }

        [DisplayName("Complemento do Cliente")]
        public string ComplementoCliente { get; set; }

        [DisplayName("UF do Cliente")]
        public string UFCliente { get; set; }

        [DisplayName("Cidade do Cliente")]
        public string CidadeCliente { get; set; }

        [DisplayName("Código da Cidade IBGE do Cliente")]
        public int? CodCidadeIBGECliente { get; set; }

        [DisplayName("CPF do Cliente")]
        public string CPFCliente { get; set; }

        [DisplayName("CNPJ do Cliente")]
        public string CNPJCliente { get; set; }

        [DisplayName("IM do Cliente")]
        public string IMCliente { get; set; }

        [DisplayName("CNAE do Cliente")]
        public string CNAECliente { get; set; }

        [DisplayName("Número do Cliente")]
        public string NumeroCliente { get; set; }

        [DisplayName("Bairro do Cliente")]
        public string BairroCliente { get; set; }

        [DisplayName("Justificativa de Cancelamento")]
        public string JustificativaCancelamento { get; set; }

        [DisplayName("Data e Hora de Cancelamento")]
        public DateTime? DataHoraCancelamento { get; set; }

        [DisplayName("E-mail")]
        public string Email { get; set; }

        [DisplayName("Código da Comanda")]
        public int? CodComanda { get; set; }

        [DisplayName("Código do DAV")]
        public int? CodDAV { get; set; }

        [DisplayName("Código da Pré-venda")]
        public int? CodPreVenda { get; set; }

        [DisplayName("Número do DAV")]
        public int? NumeroDAV { get; set; }

        [DisplayName("Valor do Troco")]
        public decimal? ValorTroco { get; set; }

        [DisplayName("Código OS")]
        public int? CodOS { get; set; }

        [DisplayName("Já Faturado")]
        public string JaFaturado { get; set; }

        [DisplayName("ID do Pagamento VFP")]
        public int? IDPagamentoVFP { get; set; }

        [DisplayName("ID da Resposta Fiscal")]
        public int? IDRespostaFiscal { get; set; }

        [DisplayName("SAT")]
        public string SAT { get; set; }

        [DisplayName("Informação Adicional")]
        public string InformacaoAdicional { get; set; }

        [DisplayName("Identificação")]
        public string Identificacao { get; set; }

        [DisplayName("Observação")]
        public string Obs { get; set; }

        [DisplayName("Código do Operador")]
        public int? CodOperador { get; set; }

        [DisplayName("Operador")]
        public string Operador { get; set; }

        [DisplayName("MD5J1")]
        public string MD5J1 { get; set; }

        [DisplayName("Indicador")]
        public string Indicador { get; set; }

        [DisplayName("Chave Anterior Contingência")]
        public string ChaveAnteriorContingencia { get; set; }

        [DisplayName("Verificado")]
        public string Verificado { get; set; }

        [DisplayName("CNF")]
        public int? CNF { get; set; }

        [DisplayName("Status Contingência")]
        public string StatusContingencia { get; set; }

        [DisplayName("Sincronizado")]
        public string Sincronizado { get; set; }

        [DisplayName("Código da Nota Manual")]
        public int? CodNotaManual { get; set; }

        [DisplayName("ID Estrangeiro")]
        public int? IDEstrangeiro { get; set; }
    }

    public class VendaNFCeTypeConfiguration : IEntityTypeConfiguration<VendaNFCe>
    {
        public void Configure(EntityTypeBuilder<VendaNFCe> builder)
        {
            builder.ToTable("TVENDANFCE");

            builder.HasKey(e => e.Controle);

            builder.Property(e => e.Controle).HasColumnName("CONTROLE").IsRequired();

            builder.Property(e => e.DataEHoraCadastro).HasColumnName("DATAEHORACADASTRO").IsRequired();

            builder.Property(e => e.DataEmissao).HasColumnName("DATAEMISSAO");

            builder.Property(e => e.NumeroNFCE).HasColumnName("NUMERONFCCE");

            builder.Property(e => e.NumeroSAT).HasColumnName("NUMEROSAT");

            builder.Property(e => e.TipoAmbiente).HasColumnName("TIPOAMBIENTE");

            builder.Property(e => e.ChaveNFCE).HasColumnName("CHAVENFCE");

            builder.Property(e => e.Protocolo).HasColumnName("PROTOCOLO");

            builder.Property(e => e.ProtocoloCancelamento).HasColumnName("PROTOCOLOCANCELAMENTO");

            builder.Property(e => e.CodigoStatus).HasColumnName("CODIGOSTATUS");

            builder.Property(e => e.StatusEnvio).HasColumnName("STATUSENVIO");

            builder.Property(e => e.Inutilizada).HasColumnName("INUTILIZADA");

            builder.Property(e => e.CodCliente).HasColumnName("CODCLIENTE");

            builder.Property(e => e.Cliente).HasColumnName("CLIENTE");

            builder.Property(e => e.CodFuncionario).HasColumnName("CODFUNCIONARIO");

            builder.Property(e => e.Funcionario).HasColumnName("FUNCIONARIO");

            builder.Property(e => e.CodCentroCusto).HasColumnName("CODCENTROCUSTO");

            builder.Property(e => e.CentroCusto).HasColumnName("CENTROCUSTO");

            builder.Property(e => e.ValorProduto).HasColumnName("VALORPRODUTO");

            builder.Property(e => e.PercAcrescimo).HasColumnName("PERCACRESCIMO");

            builder.Property(e => e.ValorAcrescimo).HasColumnName("VALORACRESCIMO");

            builder.Property(e => e.PercDesconto).HasColumnName("PERCDESCONTO");

            builder.Property(e => e.ValorDesconto).HasColumnName("VALORDESCONTO");

            builder.Property(e => e.ValorDescontoItem).HasColumnName("VALORDESCONTOITEM");

            builder.Property(e => e.ValorBCICMS).HasColumnName("VALORBCICMS");

            builder.Property(e => e.ValorICMS).HasColumnName("VALORICMS");

            builder.Property(e => e.ValorBCST).HasColumnName("VALORBCST");

            builder.Property(e => e.ValorST).HasColumnName("VALORST");

            builder.Property(e => e.ValorPIS).HasColumnName("VALORPIS");

            builder.Property(e => e.ValorCOFINS).HasColumnName("VALORCOFINS");

            builder.Property(e => e.ValorSeguro).HasColumnName("VALORSEGURO");

            builder.Property(e => e.ValorOutros).HasColumnName("VALOROUTROS");

            builder.Property(e => e.ValorOutrosItem).HasColumnName("VALOROUTROSITEM");

            builder.Property(e => e.ValorBCServico).HasColumnName("VALORBCSERVICO");

            builder.Property(e => e.ValorISS).HasColumnName("VALORISS");

            builder.Property(e => e.ValorServico).HasColumnName("VALORSERVICO");

            builder.Property(e => e.ValorTotalNFCE).HasColumnName("VALORTOTALNFCE");

            builder.Property(e => e.NaturezaOperacao).HasColumnName("NATUREZAOPERACAO");

            builder.Property(e => e.Modelo).HasColumnName("MODELO");

            builder.Property(e => e.Serie).HasColumnName("SERIE");

            builder.Property(e => e.DataSaidaEntrada).HasColumnName("DATASAIDAENTRADA");

            builder.Property(e => e.HoraSaidaEntrada).HasColumnName("HORASAIDAENTRADA");

            builder.Property(e => e.TipoEmissao).HasColumnName("TIPOEMISSAO");

            builder.Property(e => e.FoneCliente).HasColumnName("FONECLIENTE");

            builder.Property(e => e.CEPCliente).HasColumnName("CEPCLIENTE");

            builder.Property(e => e.EnderecoCliente).HasColumnName("ENDERECOCLIENTE");

            builder.Property(e => e.ComplementoCliente).HasColumnName("COMPLEMENTOCLIENTE");

            builder.Property(e => e.UFCliente).HasColumnName("UFCLIENTE");

            builder.Property(e => e.CidadeCliente).HasColumnName("CIDADECLIENTE");

            builder.Property(e => e.CodCidadeIBGECliente).HasColumnName("CODCIDADEIBGECLIENTE");

            builder.Property(e => e.CPFCliente).HasColumnName("CPFCLIENTE");

            builder.Property(e => e.CNPJCliente).HasColumnName("CNPJCLIENTE");

            builder.Property(e => e.IMCliente).HasColumnName("IMCLIENTE");

            builder.Property(e => e.CNAECliente).HasColumnName("CNAECLIENTE");

            builder.Property(e => e.NumeroCliente).HasColumnName("NUMEROCLIENTE");

            builder.Property(e => e.BairroCliente).HasColumnName("BAIRROCLIENTE");

            builder.Property(e => e.JustificativaCancelamento).HasColumnName("JUSTIFICATIVACANCELAMENTO");

            builder.Property(e => e.DataHoraCancelamento).HasColumnName("DATAEHORACANCELAMENTO");

            builder.Property(e => e.Email).HasColumnName("EMAIL");

            builder.Property(e => e.CodComanda).HasColumnName("CODCOMANDA");

            builder.Property(e => e.CodDAV).HasColumnName("CODDAV");

            builder.Property(e => e.CodPreVenda).HasColumnName("CODPREVENDA");

            builder.Property(e => e.NumeroDAV).HasColumnName("NUMERODAV");

            builder.Property(e => e.ValorTroco).HasColumnName("VALORTROCO");

            builder.Property(e => e.CodOS).HasColumnName("CODOS");

            builder.Property(e => e.JaFaturado).HasColumnName("JAFATURADO");

            builder.Property(e => e.IDPagamentoVFP).HasColumnName("IDPAGAMENTOVFP");

            builder.Property(e => e.IDRespostaFiscal).HasColumnName("IDRESPOSTAFISCAL");

            builder.Property(e => e.SAT).HasColumnName("SAT");

            builder.Property(e => e.InformacaoAdicional).HasColumnName("INFORMACAOADICIONAL");

            builder.Property(e => e.Identificacao).HasColumnName("IDENTIFICACAO");

            builder.Property(e => e.Obs).HasColumnName("OBS");

            builder.Property(e => e.CodOperador).HasColumnName("CODOPERADOR");

            builder.Property(e => e.Operador).HasColumnName("OPERADOR");

            builder.Property(e => e.MD5J1).HasColumnName("MD5J1");

            builder.Property(e => e.Indicador).HasColumnName("INDICADOR");

            builder.Property(e => e.ChaveAnteriorContingencia).HasColumnName("CHAVEANTERIORCONTINGENCIA");

            builder.Property(e => e.Verificado).HasColumnName("VERIFICADO");

            builder.Property(e => e.CNF).HasColumnName("CNF");

            builder.Property(e => e.StatusContingencia).HasColumnName("STATUSCONTINGENCIA");

            builder.Property(e => e.Sincronizado).HasColumnName("SINCRONIZADO");

            builder.Property(e => e.CodNotaManual).HasColumnName("CODNOTAMANUAL");

            builder.Property(e => e.IDEstrangeiro).HasColumnName("IDESTRANGEIRO");
        }
    }
}