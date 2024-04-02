using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiscal.Tables
{
    public class VendaNFe
    {
        [DisplayName("Código")]
        public int Controle { get; set; }

        [DisplayName("Data de Cadastro")]
        public DateTime? DataCadastro { get; set; }

        [DisplayName("Hora de Cadastro")]
        public TimeSpan? HoraCadastro { get; set; }

        [DisplayName("Nota")]
        public int? Nota { get; set; }

        [DisplayName("Série")]
        public string Serie { get; set; }

        [DisplayName("Data de Emissão")]
        public DateTime? DataEmissao { get; set; }

        [DisplayName("Data de Saída/Entrada")]
        public DateTime? DataSaidaEntrada { get; set; }

        [DisplayName("Hora de Entrada/Saída")]
        public TimeSpan? HoraEntradaSaida { get; set; }

        [DisplayName("Cancelada")]
        public string Cancelada { get; set; }

        [DisplayName("Inutilizada")]
        public string Inutilizada { get; set; }

        [DisplayName("Denegada")]
        public string Denegada { get; set; }

        [DisplayName("Chave de Acesso")]
        public string ChaveAcesso { get; set; }

        [DisplayName("Protocolo")]
        public string Protocolo { get; set; }

        [DisplayName("Status de Envio")]
        public string StatusEnvio { get; set; }

        [DisplayName("Identificação do Ambiente")]
        public string IdentificacaoAmbiente { get; set; }

        [DisplayName("Código da Operação")]
        public int? CodOperacao { get; set; }

        [DisplayName("Natureza da Operação")]
        public string NaturezaOperacao { get; set; }

        [DisplayName("Finalidade da Operação")]
        public string FinalidadeOperacao { get; set; }

        [DisplayName("Tipo da Operação")]
        public string TipoOperacao { get; set; }

        [DisplayName("Tipo de Emissão")]
        public string TipoEmissao { get; set; }

        [DisplayName("Finalidade de Emissão")]
        public string FinalidadeEmissao { get; set; }

        [DisplayName("Código do Funcionário")]
        public int? CodFuncionario { get; set; }

        [DisplayName("Funcionário")]
        public string Funcionario { get; set; }

        [DisplayName("Código do Vendedor")]
        public int? CodVendedor { get; set; }

        [DisplayName("Vendedor")]
        public string Vendedor { get; set; }

        [DisplayName("Tipo de Venda")]
        public string TipoVenda { get; set; }

        [DisplayName("Código do Cliente")]
        public int? CodCliente { get; set; }

        [DisplayName("Código do Fornecedor")]
        public int? CodFornecedor { get; set; }

        [DisplayName("CNPJ do Destinatário")]
        public string CNPJDestinatario { get; set; }

        [DisplayName("CPF do Destinatário")]
        public string CPFDestinatario { get; set; }

        [DisplayName("Razão Social do Destinatário")]
        public string RazaoSocialDestinatario { get; set; }

        [DisplayName("Endereço do Destinatário")]
        public string EnderecoDestinatario { get; set; }

        [DisplayName("Número do Destinatário")]
        public string NumeroDestinatario { get; set; }

        [DisplayName("Bairro do Destinatário")]
        public string BairroDestinatario { get; set; }

        [DisplayName("Código da Cidade do Destinatário")]
        public int? CodCidadeDestinatario { get; set; }

        [DisplayName("Cidade do Destinatário")]
        public string CidadeDestinatario { get; set; }

        [DisplayName("Código do Município")]
        public int? CodigoMunicipio { get; set; }

        [DisplayName("UF do Destinatário")]
        public string UFDestinatario { get; set; }

        [DisplayName("IE do Destinatário")]
        public string IEDestinatario { get; set; }

        [DisplayName("CEP do Destinatário")]
        public string CEPDestinatario { get; set; }

        [DisplayName("País do Destinatário")]
        public string PaisDestinatario { get; set; }

        [DisplayName("Telefone do Destinatário")]
        public string TelefoneDestinatario { get; set; }

        [DisplayName("Email do Destinatário")]
        public string EmailDestinatario { get; set; }

        [DisplayName("Código da Transportadora")]
        public int? CodTransportadora { get; set; }

        [DisplayName("CPF da Transportadora")]
        public string CPFTransportadora { get; set; }

        [DisplayName("CNPJ da Transportadora")]
        public string CNPJTransportadora { get; set; }

        [DisplayName("IE da Transportadora")]
        public string IETransportadora { get; set; }

        [DisplayName("Endereço da Transportadora")]
        public string EnderecoTransportadora { get; set; }

        [DisplayName("UF da Transportadora")]
        public string UFTransportadora { get; set; }

        [DisplayName("Cidade da Transportadora")]
        public string CidadeTransportadora { get; set; }

        [DisplayName("ANTT da Transportadora")]
        public string ANTTransportadora { get; set; }

        [DisplayName("Placa da Transportadora")]
        public string PlacaTransportadora { get; set; }

        [DisplayName("UF da Placa")]
        public string UFPlaca { get; set; }

        [DisplayName("Quantidade")]
        public decimal? Quantidade { get; set; }

        [DisplayName("Espécie")]
        public string Especie { get; set; }

        [DisplayName("Marca")]
        public string Marca { get; set; }

        [DisplayName("Numeração")]
        public string Numeracao { get; set; }

        [DisplayName("Peso Bruto")]
        public decimal? PesoBruto { get; set; }

        [DisplayName("Peso Líquido")]
        public decimal? PesoLiquido { get; set; }

        [DisplayName("Base de Cálculo do ICMS")]
        public decimal? BaseCalculoICMS { get; set; }

        [DisplayName("Valor Total do ICMS")]
        public decimal? ValorTotalICMS { get; set; }

        [DisplayName("Valor Total da Base de Cálculo do Serviço")]
        public decimal? ValorTotalBCServico { get; set; }

        [DisplayName("Total do ISS")]
        public decimal? TotalISS { get; set; }

        [DisplayName("Base de Cálculo do ICMS ST")]
        public decimal? BaseCalculoICMSST { get; set; }

        [DisplayName("Valor Total do ICMS ST")]
        public decimal? ValorTotalICMSST { get; set; }

        [DisplayName("Valor Total do Frete")]
        public decimal? ValorTotalFrete { get; set; }

        [DisplayName("Valor Total do Seguro")]
        public decimal? ValorTotalSeguro { get; set; }

        [DisplayName("Valor Total do Desconto")]
        public decimal? ValorTotalDesconto { get; set; }

        [DisplayName("Valor do Desconto do Item")]
        public decimal? ValorDescontoItem { get; set; }

        [DisplayName("Valor Total do II")]
        public decimal? ValorTotalII { get; set; }

        [DisplayName("Valor Total do IPI")]
        public decimal? ValorTotalIPI { get; set; }

        [DisplayName("Valor Total do PIS")]
        public decimal? ValorTotalPIS { get; set; }

        [DisplayName("Valor Retido do PIS")]
        public decimal? ValorRetidoPIS { get; set; }

        [DisplayName("Valor Total da COFINS")]
        public decimal? ValorTotalCOFINS { get; set; }

        [DisplayName("Valor Retido da COFINS")]
        public decimal? ValorTotalCOFINSRet { get; set; }

        [DisplayName("Valor Retido da CSLL")]
        public decimal? ValorCSLLRet { get; set; }

        [DisplayName("Valor Total da Base de Cálculo do IRRF")]
        public decimal? ValorTotalBCIRRF { get; set; }

        [DisplayName("Valor Total do IRRF")]
        public decimal? ValorTotalIRRF { get; set; }

        [DisplayName("Valor Total da Base de Cálculo da Previdência")]
        public decimal? ValorTotalBCPrevRet { get; set; }

        [DisplayName("Valor Total da Previdência Retida")]
        public decimal? ValorTotalPrevRet { get; set; }

        [DisplayName("Valor do ICMS do Destinatário")]
        public decimal? ValorICMSUFDest { get; set; }

        [DisplayName("Valor do ICMS do Remetente")]
        public decimal? ValorICMSUFRemet { get; set; }

        [DisplayName("Outras Despesas")]
        public decimal? OutrasDespesas { get; set; }

        [DisplayName("Total do Custo do Produto")]
        public decimal? TotalCustoProduto { get; set; }

        [DisplayName("Total dos Produtos")]
        public decimal? TotalProdutos { get; set; }

        [DisplayName("Total do Serviço")]
        public decimal? TotalServico { get; set; }

        [DisplayName("Valor Total da Nota Fiscal")]
        public decimal? ValorTotalNF { get; set; }

        [DisplayName("Valor de Entrada")]
        public decimal? ValorEntrada { get; set; }

        [DisplayName("Percentual de Imposto Médio")]
        public decimal? PercImpostoMedio { get; set; }

        [DisplayName("Valor do Imposto Médio")]
        public decimal? ValorImpostoMedio { get; set; }

        [DisplayName("Informações Complementares")]
        public string InformacoesComplementares { get; set; }

        [DisplayName("Informações Fiscais")]
        public string InformacoesFisco { get; set; }

        [DisplayName("Razão Social da Transportadora")]
        public string RazaoSocialTransportadora { get; set; }

        [DisplayName("Modelo")]
        public string Modelo { get; set; }

        [DisplayName("Formato de Impressão")]
        public string FormatoImpressao { get; set; }

        [DisplayName("CPF do Emitente")]
        public string CPFEmitente { get; set; }

        [DisplayName("Fatura/Duplicata")]
        public string FaturaDuplicata { get; set; }

        [DisplayName("Contingência")]
        public string Contingencia { get; set; }

        [DisplayName("Indicador de Pagamento")]
        public string IndicadorPagamento { get; set; }

        [DisplayName("Código do OS")]
        public int? CodigoOS { get; set; }

        [DisplayName("Código do Orçamento")]
        public int? CodigoOrcamento { get; set; }

        [DisplayName("Checado")]
        public string Checado { get; set; }

        [DisplayName("Código Condicional")]
        public int? CodigoCondicional { get; set; }

        [DisplayName("UF de Embarque")]
        public string UFEmbarque { get; set; }

        [DisplayName("Local de Embarque")]
        public string LocalEmbarque { get; set; }

        [DisplayName("Código CCF/ECF")]
        public string CodigoCCFECF { get; set; }

        [DisplayName("Código do Pedido de Venda")]
        public int? CodigoPedidoVenda { get; set; }

        [DisplayName("Espécie de Pagamento")]
        public string EspeciePagamento { get; set; }

        [DisplayName("Informação Fiscal")]
        public string InformacaoFiscal { get; set; }

        [DisplayName("ID Estrangeiro")]
        public string IDEstrangeiro { get; set; }

        [DisplayName("Status")]
        public string Status { get; set; }

        [DisplayName("Modo de Frete")]
        public string ModoFrete { get; set; }

        [DisplayName("À Vista")]
        public string AVista { get; set; }

        [DisplayName("Já Faturada")]
        public string JAFaturada { get; set; }

        [DisplayName("Sequência CCE")]
        public string SequenciaCCE { get; set; }

        [DisplayName("Código do Status do Cancelamento")]
        public int? CodigoStatusCancelamento { get; set; }

        [DisplayName("Data e Hora do Cancelamento")]
        public DateTime? DataEHoraCancelamento { get; set; }

        [DisplayName("Protocolo do Cancelamento")]
        public string ProtocoloCancelamento { get; set; }

        [DisplayName("Justificativa")]
        public string Justificativa { get; set; }

        [DisplayName("Motivo do Cancelamento")]
        public string MotivoCancelamento { get; set; }

        [DisplayName("Indicador")]
        public string Indicador { get; set; }

        [DisplayName("Número da Nota")]
        public int? NumeroNota { get; set; }

        [DisplayName("Código do Produto")]
        public int? CodigoProduto { get; set; }

        [DisplayName("MD5J1")]
        public string MD5J1 { get; set; }

        [DisplayName("Valor Total do FCP ST")]
        public decimal? ValorTotalFCPST { get; set; }

        [DisplayName("Indicador de Consumidor Final")]
        public string IndicadorConsumidorFinal { get; set; }

        [DisplayName("Código da Nota Manual")]
        public int? CodigoNotaManual { get; set; }

        [DisplayName("Verificado")]
        public string Verificado { get; set; }

        [DisplayName("CNAE")]
        public string CNAE { get; set; }

        [DisplayName("CNF")]
        public string CNF { get; set; }

        [DisplayName("Número da Compra")]
        public int? NumeroCompra { get; set; }
    }

    public class VendaNFeTypeConfiguration : IEntityTypeConfiguration<VendaNFe>
    {
        public void Configure(EntityTypeBuilder<VendaNFe> builder)
        {
            builder.ToTable("TVENDANFE");

            builder.HasKey(e => e.Controle);

            builder.Property(e => e.Controle).HasColumnName("CONTROLE").IsRequired();

            builder.Property(e => e.DataCadastro).HasColumnName("DATACADASTRO").IsRequired();

            builder.Property(e => e.HoraCadastro).HasColumnName("CLIENTE");

            builder.Property(e => e.Nota).HasColumnName("NOTA");

            builder.Property(e => e.Serie).HasColumnName("SERIE");

            builder.Property(e => e.DataEmissao).HasColumnName("DATAEMISSAO");

            builder.Property(e => e.DataSaidaEntrada).HasColumnName("DATASAIDAEMTRADA");

            builder.Property(e => e.HoraEntradaSaida).HasColumnName("HORAENTRADASAIDA");

            builder.Property(e => e.Cancelada).HasColumnName("CANCELADA");

            builder.Property(e => e.Inutilizada).HasColumnName("INUTILIZADA");

            builder.Property(e => e.Denegada).HasColumnName("DENEGADA");

            builder.Property(e => e.ChaveAcesso).HasColumnName("CHAVEACESSO");

            builder.Property(e => e.Protocolo).HasColumnName("PROTOCOLO");

            builder.Property(e => e.StatusEnvio).HasColumnName("STATUSDEENVIO");

            builder.Property(e => e.IdentificacaoAmbiente).HasColumnName("IDENTIFICACAOAMBIENTE");

            builder.Property(e => e.CodOperacao).HasColumnName("CODOPERACAO");

            builder.Property(e => e.NaturezaOperacao).HasColumnName("NATUREZAOPERACAO");

            builder.Property(e => e.FinalidadeOperacao).HasColumnName("FINALIDADEOPERACAO");

            builder.Property(e => e.TipoOperacao).HasColumnName("TIPOOPERACAO");

            builder.Property(e => e.TipoEmissao).HasColumnName("TIPOEMISSAO");

            builder.Property(e => e.FinalidadeEmissao).HasColumnName("FINALIDADEEMISSAO");

            builder.Property(e => e.CodFuncionario).HasColumnName("CODFUNCIONARIO");

            builder.Property(e => e.Funcionario).HasColumnName("FUNCIONARIO");

            builder.Property(e => e.CodVendedor).HasColumnName("CODVENDEDOR");

            builder.Property(e => e.Vendedor).HasColumnName("VENDEDOR");

            builder.Property(e => e.TipoVenda).HasColumnName("TIPODEVENDA");

            builder.Property(e => e.CodCliente).HasColumnName("CODCLIENTE");

            builder.Property(e => e.CodFornecedor).HasColumnName("CODFORNECEDOR");

            builder.Property(e => e.CNPJDestinatario).HasColumnName("CNPJDESTINATARIO");

            builder.Property(e => e.CPFDestinatario).HasColumnName("CPFDESTINATARIO");

            builder.Property(e => e.RazaoSocialDestinatario).HasColumnName("RAZAOSOCIALDESTINATARIO");

            builder.Property(e => e.EnderecoDestinatario).HasColumnName("ENDERECODESTINATARIO");

            builder.Property(e => e.NumeroDestinatario).HasColumnName("NUMERODESTINATARIO");

            builder.Property(e => e.BairroDestinatario).HasColumnName("BAIRRODESTINATARIO");

            builder.Property(e => e.CodCidadeDestinatario).HasColumnName("CODCIDADEDESTINATARIO");

            builder.Property(e => e.CidadeDestinatario).HasColumnName("CIDADEDESTINATARIO");

            builder.Property(e => e.CodigoMunicipio).HasColumnName("CODIGOMUNICIPIO");

            builder.Property(e => e.UFDestinatario).HasColumnName("UFDESTINATARIO");

            builder.Property(e => e.IEDestinatario).HasColumnName("IEDESTINATARIO");

            builder.Property(e => e.CEPDestinatario).HasColumnName("CEPDESTINATARIO");

            builder.Property(e => e.PaisDestinatario).HasColumnName("PAISDESTINATARIO");

            builder.Property(e => e.TelefoneDestinatario).HasColumnName("TELEFONEDESTINATARIO");

            builder.Property(e => e.EmailDestinatario).HasColumnName("EMAILDESTINATARIO");

            builder.Property(e => e.CodTransportadora).HasColumnName("CODTRANSPORTADORA");

            builder.Property(e => e.CPFTransportadora).HasColumnName("CPFTRANSPORTADORA");

            builder.Property(e => e.CNPJTransportadora).HasColumnName("CNPJTRANSPORTADORA");

            builder.Property(e => e.IETransportadora).HasColumnName("IETRANSPORTADORA");

            builder.Property(e => e.EnderecoTransportadora).HasColumnName("ENDERECOTRANSPORTADORA");

            builder.Property(e => e.UFTransportadora).HasColumnName("UFTRANSPORTADORA");

            builder.Property(e => e.CidadeTransportadora).HasColumnName("CIDADETRANSPORTADORA");

            builder.Property(e => e.ANTTransportadora).HasColumnName("ANTTTRANSPORTADORA");

            builder.Property(e => e.PlacaTransportadora).HasColumnName("PLACATRANSPORTADORA");

            builder.Property(e => e.UFPlaca).HasColumnName("UFPLACA");

            builder.Property(e => e.Quantidade).HasColumnName("QUANTIDADE");

            builder.Property(e => e.Especie).HasColumnName("ESPECIE");

            builder.Property(e => e.Marca).HasColumnName("MARCA");

            builder.Property(e => e.Numeracao).HasColumnName("NUMERACAO");

            builder.Property(e => e.PesoBruto).HasColumnName("PESOBRUTO");

            builder.Property(e => e.PesoLiquido).HasColumnName("PESOLIQUIDO");

            builder.Property(e => e.BaseCalculoICMS).HasColumnName("BASECALCULOICMS");

            builder.Property(e => e.ValorTotalICMS).HasColumnName("VALORTOTALICMS");

            builder.Property(e => e.ValorTotalBCServico).HasColumnName("VALORTOTALBCSERVICO");

            builder.Property(e => e.TotalISS).HasColumnName("TOTALISS");

            builder.Property(e => e.BaseCalculoICMSST).HasColumnName("BASECALCULOICMSST");

            builder.Property(e => e.ValorTotalICMSST).HasColumnName("VALORTOTALICMSST");

            builder.Property(e => e.ValorTotalFrete).HasColumnName("VALORTOTALFRETE");

            builder.Property(e => e.ValorTotalSeguro).HasColumnName("VALORTOTALSEGURO");

            builder.Property(e => e.ValorTotalDesconto).HasColumnName("VALORTOTALDESCONTO");

            builder.Property(e => e.ValorDescontoItem).HasColumnName("VALORDESCONTOITEM");

            builder.Property(e => e.ValorTotalII).HasColumnName("VALORTOTALII");

            builder.Property(e => e.ValorTotalIPI).HasColumnName("VALORTOTALIPI");

            builder.Property(e => e.ValorTotalPIS).HasColumnName("VALORTOTALPIS");

            builder.Property(e => e.ValorTotalPrevRet).HasColumnName("VALORTOTALPISRET");

            builder.Property(e => e.ValorTotalCOFINS).HasColumnName("VALORTOTALCOFINS");

            builder.Property(e => e.ValorTotalCOFINSRet).HasColumnName("VALORTOTALCOFINSRET");

            builder.Property(e => e.ValorCSLLRet).HasColumnName("VALORTOTALCSLLRET");

            builder.Property(e => e.ValorTotalBCIRRF).HasColumnName("VALORTOTALBCIRRF");

            builder.Property(e => e.ValorTotalIRRF).HasColumnName("VALORTOTALIRRF");

            builder.Property(e => e.ValorTotalBCPrevRet).HasColumnName("VALORTOTALBCPREVRET");

            builder.Property(e => e.ValorTotalPrevRet).HasColumnName("VALORTOTALPREVRET");

            builder.Property(e => e.ValorICMSUFDest).HasColumnName("VALORICMSUFDEST");

            builder.Property(e => e.ValorICMSUFRemet).HasColumnName("VALORICMSUFREMET");

            builder.Property(e => e.OutrasDespesas).HasColumnName("OUTRASDESPESAS");

            builder.Property(e => e.TotalCustoProduto).HasColumnName("TOTALCUSTOPRODUTO");

            builder.Property(e => e.TotalProdutos).HasColumnName("TOTALPRODUTOS");

            builder.Property(e => e.TotalServico).HasColumnName("TOTALSERVICO");

            builder.Property(e => e.ValorTotalNF).HasColumnName("VALORTOTALNFE");

            builder.Property(e => e.ValorEntrada).HasColumnName("VALORENTRADA");

            builder.Property(e => e.PercImpostoMedio).HasColumnName("PERCIMPOSTOMEDIO");

            builder.Property(e => e.ValorImpostoMedio).HasColumnName("VALORIMPOSTOMEDIO");

            builder.Property(e => e.InformacoesComplementares).HasColumnName("INFORMACOESCOMPLEMENTARES");

            builder.Property(e => e.InformacoesFisco).HasColumnName("INFORMACOESFISCO");

            builder.Property(e => e.RazaoSocialTransportadora).HasColumnName("RAZAOSOCIALTRANSPORTADORA");

            builder.Property(e => e.Modelo).HasColumnName("MODELO");

            builder.Property(e => e.FormatoImpressao).HasColumnName("FORMATOIMPRESSAO");

            builder.Property(e => e.CPFEmitente).HasColumnName("CPFEMITENTE");

            builder.Property(e => e.FaturaDuplicata).HasColumnName("FATURADUPLICATA");

            builder.Property(e => e.Contingencia).HasColumnName("CONTINGENCIA");

            builder.Property(e => e.IndicadorPagamento).HasColumnName("INDICADORPAGAMENTO");

            builder.Property(e => e.CodigoOS).HasColumnName("CODOS");

            builder.Property(e => e.CodigoOrcamento).HasColumnName("CODORCAMENTO");

            builder.Property(e => e.Checado).HasColumnName("CHECADO");

            builder.Property(e => e.CodigoCondicional).HasColumnName("CODCONDICIONAL");

            builder.Property(e => e.UFEmbarque).HasColumnName("UFEMBARQUE");

            builder.Property(e => e.LocalEmbarque).HasColumnName("LOCALEMBARQUE");

            builder.Property(e => e.CodigoCCFECF).HasColumnName("CODCCFECF");

            builder.Property(e => e.CodigoPedidoVenda).HasColumnName("CODPEDIDOVENDA");

            builder.Property(e => e.EspeciePagamento).HasColumnName("ESPECIEPAGAMENTO");

            builder.Property(e => e.InformacaoFiscal).HasColumnName("INFORMACAOFISCAL");

            builder.Property(e => e.IDEstrangeiro).HasColumnName("IDESTRANGEIRO");

            builder.Property(e => e.Status).HasColumnName("STATUS");

            builder.Property(e => e.ModoFrete).HasColumnName("MODOFRETE");

            builder.Property(e => e.AVista).HasColumnName("AVISTA");

            builder.Property(e => e.JAFaturada).HasColumnName("JAFATURADA");

            builder.Property(e => e.SequenciaCCE).HasColumnName("SEQUENCIACCE");

            builder.Property(e => e.CodigoStatusCancelamento).HasColumnName("CODIGOSTATUSCANCELAMENTO");

            builder.Property(e => e.DataEHoraCancelamento).HasColumnName("DATAEHORACANCELAMENTO");

            builder.Property(e => e.ProtocoloCancelamento).HasColumnName("PROTOCOLOCANCELAMENTO");

            builder.Property(e => e.Justificativa).HasColumnName("JUSTIFICATIVA");

            builder.Property(e => e.MotivoCancelamento).HasColumnName("MOTIVOCANCELAMENTO");

            builder.Property(e => e.Indicador).HasColumnName("INDICADOR");

            builder.Property(e => e.NumeroNota).HasColumnName("NUMERONOTA");

            builder.Property(e => e.CodigoProduto).HasColumnName("CODPRODUTO");

            builder.Property(e => e.MD5J1).HasColumnName("MD5J1");

            builder.Property(e => e.ValorTotalFCPST).HasColumnName("VALORTOTALFCPST");

            builder.Property(e => e.IndicadorConsumidorFinal).HasColumnName("INDCONSUMIDORFINAL");

            builder.Property(e => e.CodigoNotaManual).HasColumnName("CODNOTAMANUAL");

            builder.Property(e => e.Verificado).HasColumnName("VERIFICADO");

            builder.Property(e => e.CNAE).HasColumnName("CNAE");

            builder.Property(e => e.CNF).HasColumnName("CNF");

            builder.Property(e => e.NumeroCompra).HasColumnName("NUMEROCOMPRA");
        }
    }
}
