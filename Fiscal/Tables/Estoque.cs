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
    public class Estoque
    {
        [DisplayName("Controle")]
        public int Controle { get; set; }

        [DisplayName("Produto")]
        public string Produto { get; set; }

        [DisplayName("Tipo de Barras")]
        public string TipoBarras { get; set; }

        [DisplayName("Código de Barras")]
        public string CodBarras { get; set; }

        [DisplayName("Unidade")]
        public string Unidade { get; set; }

        [DisplayName("Preço de Custo")]
        public decimal? PrecoCusto { get; set; }

        [DisplayName("Percentual de Lucro")]
        public decimal? PercLucro { get; set; }

        [DisplayName("Preço de Venda")]
        public decimal? PrecoVenda { get; set; }

        [DisplayName("Código do Grupo")]
        public int? CodGrupo { get; set; }

        [DisplayName("Grupo")]
        public string Grupo { get; set; }

        [DisplayName("Observações")]
        public string Obs { get; set; }

        [DisplayName("Código do Fornecedor")]
        public int? CodFornecedor { get; set; }

        [DisplayName("Fornecedor")]
        public string Fornecedor { get; set; }

        [DisplayName("Tamanho")]
        public string Tamanho { get; set; }

        [DisplayName("Peso")]
        public decimal? Peso { get; set; }

        [DisplayName("Custo Última Compra")]
        public decimal? CustoUltimaCompra { get; set; }

        [DisplayName("Custo Médio")]
        public decimal? CustoMedio { get; set; }

        [DisplayName("Quantidade Total Comprada")]
        public decimal? QtdeTotalComprada { get; set; }

        [DisplayName("Quantidade Total Vendida")]
        public decimal? QtdeTotalVendida { get; set; }

        [DisplayName("Data Última Compra")]
        public DateTime? DataUltimaCompra { get; set; }

        [DisplayName("Data Última Venda")]
        public DateTime? DataUltimaVenda { get; set; }

        [DisplayName("Data e Hora de Cadastro")]
        public DateTime? DataHoraCadastro { get; set; }

        [DisplayName("Quantidade Mínima")]
        public int? QtdeMinima { get; set; }

        [DisplayName("Quantidade Máxima")]
        public int? QtdeMaxima { get; set; }

        [DisplayName("Quantidade")]
        public int? Qtde { get; set; }

        [DisplayName("Ativo")]
        public string Ativo { get; set; }

        [DisplayName("NCM")]
        public string NCM { get; set; }

        [DisplayName("Percentual de Crédito ICMS")]
        public decimal? PercCreditoICMS { get; set; }

        [DisplayName("Usa Grade")]
        public string UsaGrade { get; set; }

        [DisplayName("Usa Serial")]
        public string UsaSerial { get; set; }

        [DisplayName("Origem")]
        public string Origem { get; set; }

        [DisplayName("Código Tributação IPI")]
        public string CodTributacaoIPI { get; set; }

        [DisplayName("Tributação IPI")]
        public string TributacaoIPI { get; set; }

        [DisplayName("Código Tributação PIS")]
        public string CodTributacaoPIS { get; set; }

        [DisplayName("Código Tributação COFINS")]
        public string CodTributacaoCOFINS { get; set; }

        [DisplayName("Tributação PIS")]
        public string TributacaoPIS { get; set; }

        [DisplayName("Tributação COFINS")]
        public string TributacaoCOFINS { get; set; }

        [DisplayName("Tipo de Tributação")]
        public string TipoTributacao { get; set; }

        [DisplayName("Percentual ICMS ST Interna")]
        public decimal? PercICMSSTInterna { get; set; }

        [DisplayName("Percentual MVA Original")]
        public decimal? PercMVAOriginal { get; set; }

        [DisplayName("Possui ICMS ST")]
        public string PossuiICMSST { get; set; }

        [DisplayName("Isento")]
        public string Isento { get; set; }

        [DisplayName("Percentual ICMS Próprio ST")]
        public decimal? PercICMSProprioST { get; set; }

        [DisplayName("IAT")]
        public string IAT { get; set; }

        [DisplayName("IPPT")]
        public string IPPT { get; set; }

        [DisplayName("Tributado")]
        public string Tributado { get; set; }

        [DisplayName("CSOSN")]
        public string CSOSN { get; set; }

        [DisplayName("Descrição CSOSN")]
        public string DescricaoCSOSN { get; set; }

        [DisplayName("Pesado")]
        public string Pesado { get; set; }

        [DisplayName("Base de Cálculo ICMS ST Retido")]
        public decimal? BaseCalculoICMSSTRetido { get; set; }

        [DisplayName("Valor ICMS ST Retido")]
        public decimal? ValorICMSSTRetido { get; set; }

        [DisplayName("Alíquota ICMS ECF")]
        public decimal? AliquotaICMSECF { get; set; }

        [DisplayName("Foto")]
        public string Foto { get; set; }

        [DisplayName("MD5")]
        public string MD5 { get; set; }

        [DisplayName("Mensagem NFe")]
        public string MensagemNFe { get; set; }

        [DisplayName("Código Mensagem NFe")]
        public int? CodMensagemNFe { get; set; }

        [DisplayName("Código Unidade de Medida")]
        public int? CodUnidadeMedida { get; set; }

        [DisplayName("Código Aplicação do Produto")]
        public int? CodAplicacaoProduto { get; set; }

        [DisplayName("Aplicação do Produto")]
        public string AplicacaoProduto { get; set; }

        [DisplayName("MD5E2")]
        public string MD5E2 { get; set; }

        [DisplayName("Quantidade Inicial")]
        public decimal? QtdeInicial { get; set; }

        [DisplayName("Alíquota ISS")]
        public decimal? AliquotaISS { get; set; }

        [DisplayName("Código Imposto Médio")]
        public int? CodImpostoMedio { get; set; }

        [DisplayName("Percentual Imposto Médio")]
        public decimal? PercImpostoMedio { get; set; }

        [DisplayName("Cód CST Origem")]
        public string CodCSTOrigem { get; set; }

        [DisplayName("Código CST Origem")]
        public string CodigoCSTOrigem { get; set; }

        [DisplayName("Código Emitente")]
        public string CodEmitente { get; set; }

        [DisplayName("Dias de Validade do Produto")]
        public string DiasValidadeProduto { get; set; }

        [DisplayName("Fator de Conversão")]
        public string FatorConversao { get; set; }

        [DisplayName("Tributação do Serviço")]
        public string TributacaoServico { get; set; }

        [DisplayName("Redução Base Cálculo Serviço")]
        public string ReducaoBaseCalculoServico { get; set; }

        [DisplayName("Status")]
        public string Status { get; set; }

        [DisplayName("Descrição Complementar")]
        public string DescricaoComplementar { get; set; }

        [DisplayName("Referência")]
        public string Referencia { get; set; }

        [DisplayName("Preço de Venda (USD)")]
        public decimal? PrecoVendaUSS { get; set; }

        [DisplayName("Percentual Máximo de Desconto")]
        public decimal? PercMaximoDesconto { get; set; }

        [DisplayName("Valor Comissão Fixo")]
        public decimal? ValorComissaoFixo { get; set; }

        [DisplayName("Percentual Comissão")]
        public decimal? PercComissao { get; set; }

        [DisplayName("Preço Mínimo (USD)")]
        public decimal? PrecoMinimoUSS { get; set; }

        [DisplayName("Preço Mínimo")]
        public decimal? PrecoMinimo { get; set; }

        [DisplayName("Código de Compra")]
        public string CodCompra { get; set; }

        [DisplayName("Valor Frete")]
        public decimal? ValorFrete { get; set; }

        [DisplayName("Valor Outros")]
        public decimal? ValorOutros { get; set; }

        [DisplayName("Valor ICMS ST")]
        public decimal? ValorICMSST { get; set; }

        [DisplayName("Valor IPI")]
        public decimal? ValorIPI { get; set; }

        [DisplayName("Valor Unitário de Compra")]
        public decimal? ValorUnitarioCompra { get; set; }

        [DisplayName("Percentual PIS")]
        public decimal? PercPIS { get; set; }

        [DisplayName("Percentual COFINS")]
        public string PercCOFINS { get; set; }

        [DisplayName("Valor Conversão")]
        public string ValorConversao { get; set; }

        [DisplayName("Campo 1")]
        public string Campo1 { get; set; }

        [DisplayName("Campo 2")]
        public string Campo2 { get; set; }

        [DisplayName("Campo 3")]
        public string Campo3 { get; set; }

        [DisplayName("Campo 4")]
        public string Campo4 { get; set; }

        [DisplayName("Campo 5")]
        public string Campo5 { get; set; }

        [DisplayName("Campo 6")]
        public string Campo6 { get; set; }

        [DisplayName("Campo 7")]
        public string Campo7 { get; set; }

        [DisplayName("Campo 8")]
        public string Campo8 { get; set; }

        [DisplayName("Campo 9")]
        public string Campo9 { get; set; }

        [DisplayName("Campo 10")]
        public string Campo10 { get; set; }

        [DisplayName("Código ANP")]
        public string CodigoANP { get; set; }

        [DisplayName("Marca")]
        public string Marca { get; set; }

        [DisplayName("Percentual Redução BC")]
        public decimal? PercReducaoBC { get; set; }

        [DisplayName("Percentual Redução BC ST")]
        public decimal? PercReducaoBCST { get; set; }

        [DisplayName("Código Subgrupo")]
        public string CodSubgrupo { get; set; }

        [DisplayName("Subgrupo")]
        public string Subgrupo { get; set; }

        [DisplayName("Controlar Validade")]
        public string ControlarValidade { get; set; }

        [DisplayName("Código Marca")]
        public string CodMarca { get; set; }

        [DisplayName("Preço de Revenda")]
        public decimal? PrecoRevenda { get; set; }

        [DisplayName("Percentual IPI")]
        public decimal? PercIPI { get; set; }

        [DisplayName("CFOP")]
        public string CFOP { get; set; }

        [DisplayName("Unidade Conversão Venda")]
        public string UnidadeConversaoVenda { get; set; }

        [DisplayName("Valor Conversão Venda")]
        public decimal? ValorConversaoVenda { get; set; }

        [DisplayName("Código Tabela de Preço")]
        public string CodTabelaPreco { get; set; }

        [DisplayName("Nome Tabela de Preço")]
        public string NomeTabelaPreco { get; set; }

        [DisplayName("Percentual Imposto Médio Estadual")]
        public decimal? PercImpostoMedioEstadual { get; set; }

        [DisplayName("Percentual Imposto Médio Municipal")]
        public decimal? PercImpostoMedioMunicipal { get; set; }

        [DisplayName("Código Enquadramento IPI")]
        public string CodigoEnquadramentoIPI { get; set; }

        [DisplayName("CEST")]
        public string CEST { get; set; }

        [DisplayName("Quantidade em Produção")]
        public decimal? QtdeEmProducao { get; set; }

        [DisplayName("Quantidade Pedido de Venda")]
        public decimal? QtdePedidoVenda { get; set; }

        [DisplayName("Quantidade Pedido de Compra")]
        public decimal? QtdePedidoCompra { get; set; }

        [DisplayName("Quantidade Reservada")]
        public decimal? QtdeReservada { get; set; }

        [DisplayName("Quantidade Real")]
        public decimal? QtdeReal { get; set; }

        [DisplayName("Quantidade em Produção MP")]
        public decimal? QtdeEmProducaoMP { get; set; }

        [DisplayName("Unidade Medida Etiqueta")]
        public string UnidadeMedidaEtiqueta { get; set; }

        [DisplayName("Fator Conversão Etiqueta")]
        public decimal? FatorConversaoEtiqueta { get; set; }

        [DisplayName("Selo IPI")]
        public string SeloIPI { get; set; }

        [DisplayName("Alíquota FCP")]
        public decimal? AliquotaFCP { get; set; }

        [DisplayName("Percentual FCP ST")]
        public decimal? PercFCPST { get; set; }

        [DisplayName("Descrição ANP")]
        public string DescricaoANP { get; set; }

        [DisplayName("Percentual GLP Combustível")]
        public decimal? PercGLPComb { get; set; }

        [DisplayName("Percentual GNN Combustível")]
        public decimal? PercGNNComb { get; set; }

        [DisplayName("Percentual GNI Combustível")]
        public decimal? PercGNIComb { get; set; }

        [DisplayName("Valor Partida Combustível")]
        public decimal? ValorPartidaComb { get; set; }

        [DisplayName("CNPJ Fabricante")]
        public string CNPJFabricante { get; set; }

        [DisplayName("Código Benefício Fiscal")]
        public string CodigoBeneficioFiscal { get; set; }

        [DisplayName("Código ANVISA")]
        public string CodigoANVISA { get; set; }

        [DisplayName("Código Unidade Tributável")]
        public int? CodigoUnidadeTributavel { get; set; }

        [DisplayName("Unidade Tributável")]
        public string UnidadeTributavel { get; set; }

        [DisplayName("Quantidade Tributável")]
        public decimal? QtdeTributavel { get; set; }

        [DisplayName("Desmontar na Venda")]
        public string DesmontarNaVenda { get; set; }

        [DisplayName("Alíquota ICMS ST Ret")]
        public decimal? AliquotaICMSSTRet { get; set; }

        [DisplayName("Valor BC ICMS ST Ret")]
        public decimal? ValorBCICMSSTRet { get; set; }

        [DisplayName("Valor ICMS ST Ret")]
        public decimal? ValorICMSSTRet { get; set; }

        [DisplayName("Alíquota ICMS Efetiva")]
        public decimal? AliquotaICMSEfet { get; set; }

        [DisplayName("Percentual Redução ICMS Efet")]
        public decimal? PercReducaoICMSEfet { get; set; }

        [DisplayName("Valor BC ICMS Efetiva")]
        public decimal? ValorBCICMSEfet { get; set; }

        [DisplayName("Valor ICMS Efetivo")]
        public decimal? ValorICMSEfet { get; set; }

        [DisplayName("Valor ICMS Substituto")]
        public decimal? ValorICMSSubstituto { get; set; }

        [DisplayName("Código Barras Caixa")]
        public string CodigoBarrasCaixa { get; set; }

        [DisplayName("Enviar Dados")]
        public string EnviarDados { get; set; }

        [DisplayName("Valor PMC")]
        public decimal? ValorPMC { get; set; }

        [DisplayName("MD5 Original")]
        public string MD5O { get; set; }

        [DisplayName("MD5 Substituto")]
        public string MD5S { get; set; }

        [DisplayName("Valor FCP ST")]
        public decimal? ValorFCPST { get; set; }

        [DisplayName("Localização")]
        public string Localizacao { get; set; }

        [DisplayName("Volume")]
        public decimal? Volume { get; set; }

        [DisplayName("Mostrar na Cozinha")]
        public string MostrarCozinha { get; set; }

        [DisplayName("Código Barras Interno")]
        public string CodigoBarrasInterno { get; set; }

        [DisplayName("Código Barras Tributável")]
        public string CodigoBarrasTrib { get; set; }

        [DisplayName("Vacina")]
        public string Vacina { get; set; }

        [DisplayName("Percentual Desconto Caixa")]
        public decimal? PercDescontoCaixa { get; set; }

        [DisplayName("Sincronizado")]
        public string Sincronizado { get; set; }

        [DisplayName("Percentual Cashback")]
        public decimal? PercCashback { get; set; }

    }

    public class EstoqueTypeConfiguration : IEntityTypeConfiguration<Estoque>
    {
        public void Configure(EntityTypeBuilder<Estoque> builder)
        {
            builder.ToTable("TESTOQUE");

            builder.HasKey(e => e.Controle);

            builder.Property(e => e.Controle).HasColumnName("CONTROLE").IsRequired();

            builder.Property(e => e.Produto).HasColumnName("PRODUTO");

            builder.Property(e => e.TipoBarras).HasColumnName("TIPOBARRA");

            builder.Property(e => e.CodBarras).HasColumnName("CODBARRAS");

            builder.Property(e => e.Unidade).HasColumnName("UNIDADE");

            builder.Property(e => e.PrecoCusto).HasColumnName("PRECOCUSTO");

            builder.Property(e => e.PercLucro).HasColumnName("PERCLUCRO");

            builder.Property(e => e.PrecoVenda).HasColumnName("PRECOVENDA");

            builder.Property(e => e.CodGrupo).HasColumnName("CODGRUPO");

            builder.Property(e => e.Grupo).HasColumnName("GRUPO");

            builder.Property(e => e.Obs).HasColumnName("OBS");

            builder.Property(e => e.CodFornecedor).HasColumnName("CODFORNECEDOR");

            builder.Property(e => e.Fornecedor).HasColumnName("FORNECEDOR");

            builder.Property(e => e.Tamanho).HasColumnName("TAMANHO");

            builder.Property(e => e.Peso).HasColumnName("PESO");

            builder.Property(e => e.CustoUltimaCompra).HasColumnName("CUSTOULTIMACOMPRA");

            builder.Property(e => e.CustoMedio).HasColumnName("CUSTOMEDIO");

            builder.Property(e => e.QtdeTotalComprada).HasColumnName("QTDETOTALCOMPRADA");

            builder.Property(e => e.QtdeTotalVendida).HasColumnName("QTDETOTALVENDIDA");

            builder.Property(e => e.DataUltimaCompra).HasColumnName("DATAULTIMACOMPRA");

            builder.Property(e => e.DataUltimaVenda).HasColumnName("DATAULTIMAVENDA");

            builder.Property(e => e.DataHoraCadastro).HasColumnName("DATAHORACADASTRO");

            builder.Property(e => e.QtdeMinima).HasColumnName("QTDEMINIMA");

            builder.Property(e => e.QtdeMaxima).HasColumnName("QTDEMAXIMA");

            builder.Property(e => e.Qtde).HasColumnName("QTDE");

            builder.Property(e => e.Ativo).HasColumnName("ATIVO");

            builder.Property(e => e.NCM).HasColumnName("NCM");

            builder.Property(e => e.PercCreditoICMS).HasColumnName("PERCREDITOCICMS");

            builder.Property(e => e.UsaGrade).HasColumnName("USAGRADE");

            builder.Property(e => e.UsaSerial).HasColumnName("USASERIAL");

            builder.Property(e => e.Origem).HasColumnName("ORIGEM");

            builder.Property(e => e.CodTributacaoIPI).HasColumnName("CODTRIBUTACAOIPI");

            builder.Property(e => e.TributacaoIPI).HasColumnName("TRIBUTACAOIPI");

            builder.Property(e => e.CodTributacaoPIS).HasColumnName("CODTRIBUTACAOPIS");

            builder.Property(e => e.CodTributacaoCOFINS).HasColumnName("CODTRIBUTACAOCOFINS");

            builder.Property(e => e.TributacaoPIS).HasColumnName("TRIBUTACAOPIS");

            builder.Property(e => e.TributacaoCOFINS).HasColumnName("TRIBUTACAOCOFINS");

            builder.Property(e => e.TipoTributacao).HasColumnName("TIPOTRIBUTACAO");

            builder.Property(e => e.PercICMSSTInterna).HasColumnName("PERCICMSSTINTERNA");

            builder.Property(e => e.PercMVAOriginal).HasColumnName("PERCMVAORIGINAL");

            builder.Property(e => e.PossuiICMSST).HasColumnName("POSSUIICMSST");

            builder.Property(e => e.Isento).HasColumnName("ISENTO");

            builder.Property(e => e.PercICMSProprioST).HasColumnName("PERCICMSPROPRIOST");

            builder.Property(e => e.IAT).HasColumnName("IAT");

            builder.Property(e => e.IPPT).HasColumnName("IPPT");

            builder.Property(e => e.Tributado).HasColumnName("TRIBUTADO");

            builder.Property(e => e.CSOSN).HasColumnName("CSOSN");

            builder.Property(e => e.DescricaoCSOSN).HasColumnName("DESCRICAOCSOSN");

            builder.Property(e => e.Pesado).HasColumnName("PESADO");

            builder.Property(e => e.BaseCalculoICMSSTRetido).HasColumnName("BASECALCULOICMSSTRETIDO");

            builder.Property(e => e.ValorICMSSTRetido).HasColumnName("VALORICMSSTRETIDO");

            builder.Property(e => e.AliquotaICMSECF).HasColumnName("ALIQUOTAICMSECF");

            builder.Property(e => e.Foto).HasColumnName("FOTO");

            builder.Property(e => e.MD5).HasColumnName("MD5");

            builder.Property(e => e.MensagemNFe).HasColumnName("MENSAGEMNFE");

            builder.Property(e => e.CodMensagemNFe).HasColumnName("CODMENSAGEMNFE");

            builder.Property(e => e.CodUnidadeMedida).HasColumnName("CODUNIDADEMEDIDA");

            builder.Property(e => e.CodAplicacaoProduto).HasColumnName("CODAPLICACAOPRODUTO");

            builder.Property(e => e.AplicacaoProduto).HasColumnName("APLICACAOPRODUTO");

            builder.Property(e => e.MD5E2).HasColumnName("MD5E2");

            builder.Property(e => e.QtdeInicial).HasColumnName("QTDEINICIAL");

            builder.Property(e => e.AliquotaISS).HasColumnName("ALIQUOTAISS");

            builder.Property(e => e.CodImpostoMedio).HasColumnName("CODIMPOSTOMEDIO");

            builder.Property(e => e.PercImpostoMedio).HasColumnName("PERCIMPOSTOMEDIO");

            builder.Property(e => e.CodCSTOrigem).HasColumnName("CODCSTORIGEM");

            builder.Property(e => e.CodigoCSTOrigem).HasColumnName("CODIGOCSTORIGEM");

            builder.Property(e => e.CodEmitente).HasColumnName("CODEMITENTE");

            builder.Property(e => e.DiasValidadeProduto).HasColumnName("DIASVALIDADEPRODUTO");

            builder.Property(e => e.FatorConversao).HasColumnName("FATORCONVERSAO");

            builder.Property(e => e.TributacaoServico).HasColumnName("TRIBUTACAOSERVICO");

            builder.Property(e => e.ReducaoBaseCalculoServico).HasColumnName("REDUCAOBASECALCULOSERVICO");

            builder.Property(e => e.Status).HasColumnName("STATUS");

            builder.Property(e => e.DescricaoComplementar).HasColumnName("DESCRICAOCOMPLEMENTAR");

            builder.Property(e => e.Referencia).HasColumnName("REFERENCIA");

            builder.Property(e => e.PrecoVendaUSS).HasColumnName("PRECOVENDAUSS");

            builder.Property(e => e.PercMaximoDesconto).HasColumnName("PERCMAXIMODESCONTO");

            builder.Property(e => e.ValorComissaoFixo).HasColumnName("VALORCOMISSAOFIXO");

            builder.Property(e => e.PercComissao).HasColumnName("PERCCOMISSAO");

            builder.Property(e => e.PrecoMinimoUSS).HasColumnName("PRECOMINIMOUSS");

            builder.Property(e => e.PrecoMinimo).HasColumnName("PRECOMINIMO");

            builder.Property(e => e.CodCompra).HasColumnName("CODCOMPRA");

            builder.Property(e => e.ValorFrete).HasColumnName("VALORFRETE");

            builder.Property(e => e.ValorOutros).HasColumnName("VALOROUTROS");

            builder.Property(e => e.ValorICMSST).HasColumnName("VALORICMSST");

            builder.Property(e => e.ValorIPI).HasColumnName("VALORIPI");

            builder.Property(e => e.ValorUnitarioCompra).HasColumnName("VALORUNITARIOCOMPRA");

            builder.Property(e => e.PercPIS).HasColumnName("PERCPIS");

            builder.Property(e => e.PercCOFINS).HasColumnName("PERCCOFINS");

            builder.Property(e => e.ValorConversao).HasColumnName("VALORCONVERSAO");

            builder.Property(e => e.Campo1).HasColumnName("CAMPO1");

            builder.Property(e => e.Campo2).HasColumnName("CAMPO2");

            builder.Property(e => e.Campo3).HasColumnName("CAMPO3");

            builder.Property(e => e.Campo4).HasColumnName("CAMPO4");

            builder.Property(e => e.Campo5).HasColumnName("CAMPO5");

            builder.Property(e => e.Campo6).HasColumnName("CAMPO6");

            builder.Property(e => e.Campo7).HasColumnName("CAMPO7");

            builder.Property(e => e.Campo8).HasColumnName("CAMPO8");

            builder.Property(e => e.Campo9).HasColumnName("CAMPO9");

            builder.Property(e => e.Campo10).HasColumnName("CAMPO10");

            builder.Property(e => e.CodigoANP).HasColumnName("CODIGOANP");

            builder.Property(e => e.Marca).HasColumnName("MARCA");

            builder.Property(e => e.PercReducaoBC).HasColumnName("PERCREDUCAOBC");

            builder.Property(e => e.PercReducaoBCST).HasColumnName("PERCREDUCAOBCST");

            builder.Property(e => e.CodSubgrupo).HasColumnName("CODSUBGRUPO");

            builder.Property(e => e.Subgrupo).HasColumnName("SUBGRUPO");

            builder.Property(e => e.ControlarValidade).HasColumnName("CONTROLARVALIDADE");

            builder.Property(e => e.CodMarca).HasColumnName("CODMARCA");

            builder.Property(e => e.PrecoRevenda).HasColumnName("PRECOREVENDA");

            builder.Property(e => e.PercIPI).HasColumnName("PERCIPI");

            builder.Property(e => e.CFOP).HasColumnName("CFOP");

            builder.Property(e => e.UnidadeConversaoVenda).HasColumnName("UNIDADECONVERSAOVENDA");

            builder.Property(e => e.ValorConversaoVenda).HasColumnName("VALORCONVERSAOVENDA");

            builder.Property(e => e.CodTabelaPreco).HasColumnName("CODTABELAPRECO");

            builder.Property(e => e.NomeTabelaPreco).HasColumnName("NOMETABELAPRECO");

            builder.Property(e => e.PercImpostoMedioEstadual).HasColumnName("PERCIMPOSTOMEDIOESTADUAL");

            builder.Property(e => e.PercImpostoMedioMunicipal).HasColumnName("PERCIMPOSTOMEDIOMUNICIPAL");

            builder.Property(e => e.CodigoEnquadramentoIPI).HasColumnName("CODIGOENQUADRAMENTOIPI");

            builder.Property(e => e.CEST).HasColumnName("CEST");

            builder.Property(e => e.QtdeEmProducao).HasColumnName("QTDEEMPRODUCAO");

            builder.Property(e => e.QtdePedidoVenda).HasColumnName("QTDEPEDIDOVENDA");

            builder.Property(e => e.QtdePedidoCompra).HasColumnName("QTDEPEDIDOCOMPRA");

            builder.Property(e => e.QtdeReservada).HasColumnName("QTDERESERVADA");

            builder.Property(e => e.QtdeReal).HasColumnName("QTDEREAL");

            builder.Property(e => e.QtdeEmProducaoMP).HasColumnName("QTDEEMPRODUCAOMP");

            builder.Property(e => e.UnidadeMedidaEtiqueta).HasColumnName("UNIDADEMEDIDAETIQUETA");

            builder.Property(e => e.FatorConversaoEtiqueta).HasColumnName("FATORCONVERSAOETIQUETA");

            builder.Property(e => e.SeloIPI).HasColumnName("SELOIPI");

            builder.Property(e => e.AliquotaFCP).HasColumnName("ALIQUOTAFCP");

            builder.Property(e => e.PercFCPST).HasColumnName("PERCFCPST");

            builder.Property(e => e.DescricaoANP).HasColumnName("DESCRICAOANP");

            builder.Property(e => e.PercGLPComb).HasColumnName("PERCGLPCOMB");

            builder.Property(e => e.PercGNNComb).HasColumnName("PERCGNNCOMB");

            builder.Property(e => e.PercGNIComb).HasColumnName("PERCGNICOMB");

            builder.Property(e => e.ValorPartidaComb).HasColumnName("VALORPARTIDACOMB");

            builder.Property(e => e.CNPJFabricante).HasColumnName("CNPJFABRICANTE");

            builder.Property(e => e.CodigoBeneficioFiscal).HasColumnName("CODBENEFICIOFISCAL");

            builder.Property(e => e.CodigoANVISA).HasColumnName("CODIGOANVISA");

            builder.Property(e => e.CodigoUnidadeTributavel).HasColumnName("CODUNIDADETRIBUTAVEL");

            builder.Property(e => e.UnidadeTributavel).HasColumnName("UNIDADETRIBUTAVEL");

            builder.Property(e => e.QtdeTributavel).HasColumnName("QTDETRIBUTAVEL");

            builder.Property(e => e.DesmontarNaVenda).HasColumnName("DESMONTARNAVENDA");

            builder.Property(e => e.AliquotaICMSSTRet).HasColumnName("ALIQUOTAICMSSTRET");

            builder.Property(e => e.ValorBCICMSSTRet).HasColumnName("VALORBCICMSSTRET");

            builder.Property(e => e.ValorICMSSTRet).HasColumnName("VALORICMSSTRET");

            builder.Property(e => e.AliquotaICMSEfet).HasColumnName("ALIQUOTAICMSEFET");

            builder.Property(e => e.PercReducaoICMSEfet).HasColumnName("PERCREDUCAOICMSEFET");

            builder.Property(e => e.ValorBCICMSEfet).HasColumnName("VALORBCICMSEFET");

            builder.Property(e => e.ValorICMSEfet).HasColumnName("VALORICMSEFET");

            builder.Property(e => e.ValorICMSSubstituto).HasColumnName("VALORICMSSUBSTITUTO");

            builder.Property(e => e.CodigoBarrasCaixa).HasColumnName("CODBARRASCAIXA");

            builder.Property(e => e.EnviarDados).HasColumnName("ENVIARDADOS");

            builder.Property(e => e.ValorPMC).HasColumnName("VALORPMC");

            builder.Property(e => e.MD5O).HasColumnName("MD5O");

            builder.Property(e => e.MD5S).HasColumnName("MD5S");

            builder.Property(e => e.ValorFCPST).HasColumnName("VALORFCPST");

            builder.Property(e => e.Localizacao).HasColumnName("LOCALIZACAO");

            builder.Property(e => e.Volume).HasColumnName("VOLUME");

            builder.Property(e => e.MostrarCozinha).HasColumnName("MOSTRARCOZINHA");

            builder.Property(e => e.CodigoBarrasInterno).HasColumnName("CODBARRASINTERNO");

            builder.Property(e => e.CodigoBarrasTrib).HasColumnName("CODBARRASTRIB");

            builder.Property(e => e.Vacina).HasColumnName("VACINA");

            builder.Property(e => e.PercDescontoCaixa).HasColumnName("PERCDESCONTOCAIXA");

            builder.Property(e => e.Sincronizado).HasColumnName("SINCRONIZADO");

            builder.Property(e => e.PercCashback).HasColumnName("PERCCASHBACK");
        }
    }
}
