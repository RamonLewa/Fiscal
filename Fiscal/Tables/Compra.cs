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
    public class Compra
    {
        [DisplayName("CONTROLE")]
        public int Controle { get; set; }

        [DisplayName("NUMERONOTA")]
        public int? NumeroNota { get; set; }

        [DisplayName("NATUREZAOPERACAO")]
        public string NaturezaOperacao { get; set; }

        [DisplayName("MODELO")]
        public string Modelo { get; set; }

        [DisplayName("SERIE")]
        public string Serie { get; set; }

        [DisplayName("SUBSERIE")]
        public string SubSerie { get; set; }

        [DisplayName("DATAHORACADASTRO")]
        public DateTime? DataHoraCadastro { get; set; }

        [DisplayName("DATAEMISSAO")]
        public DateTime? DataEmissao { get; set; }

        [DisplayName("DATARECEBIMENTO")]
        public DateTime? DataRecebimento { get; set; }

        [DisplayName("CODFORNECEDOR")]
        public int? CodFornecedor { get; set; }

        [DisplayName("FORNECEDOR")]
        public string Fornecedor { get; set; }

        [DisplayName("CODTRANSPORTADORA")]
        public int? CodTransportadora { get; set; }

        [DisplayName("TRANSPORTADORA")]
        public string Transportadora { get; set; }

        [DisplayName("BASECALCICMS")]
        public decimal? BaseCalcICMS { get; set; }

        [DisplayName("VALORICMS")]
        public decimal? ValorICMS { get; set; }

        [DisplayName("TOTALREDUCAOICMS")]
        public decimal? TotalReducaoICMS { get; set; }

        [DisplayName("BASECALCICMSST")]
        public decimal? BaseCalcICMSST { get; set; }

        [DisplayName("VALORICMSSUBSTITUICAO")]
        public decimal? ValorICMSSubstituicao { get; set; }

        [DisplayName("TOTALBCIPI")]
        public decimal? TotalBCIPI { get; set; }

        [DisplayName("VALORTOTALIPI")]
        public decimal? ValorTotalIPI { get; set; }

        [DisplayName("TOTALPIS")]
        public decimal? TotalPIS { get; set; }

        [DisplayName("TOTALPISSUB")]
        public decimal? TotalPISSub { get; set; }

        [DisplayName("TOTALCOFINS")]
        public decimal? TotalCOFINS { get; set; }

        [DisplayName("TOTALCOFINSSUB")]
        public decimal? TotalCOFINSSub { get; set; }

        [DisplayName("MODOFRETE")]
        public string ModoFrete { get; set; }

        [DisplayName("TIPOFRETE")]
        public string TipoFrete { get; set; }

        [DisplayName("VALORICMSFRETE")]
        public decimal? ValorICMSFrete { get; set; }

        [DisplayName("VALORFRETE")]
        public decimal? ValorFrete { get; set; }

        [DisplayName("VALORSEGURO")]
        public decimal? ValorSeguro { get; set; }

        [DisplayName("PERCDESCONTO")]
        public decimal? PercDesconto { get; set; }

        [DisplayName("VALORDESCONTO")]
        public decimal? ValorDesconto { get; set; }

        [DisplayName("OUTRASDESPESAS")]
        public decimal? OutrasDespesas { get; set; }

        [DisplayName("TOTALSERVICOS")]
        public decimal? TotalServicos { get; set; }

        [DisplayName("VALORTOTALPRODUTO")]
        public decimal? ValorTotalProduto { get; set; }

        [DisplayName("VALORENTRADA")]
        public decimal? ValorEntrada { get; set; }

        [DisplayName("VALORTOTALNOTA")]
        public decimal? ValorTotalNota { get; set; }

        [DisplayName("NFE")]
        public string NFE { get; set; }

        [DisplayName("PROTOCOLODANFE")]
        public string ProtocoloDaNFE { get; set; }

        [DisplayName("CHAVEACESSODANFE")]
        public string ChaveAcessoDaNFE { get; set; }

        [DisplayName("INFORMACOESCOMPLEMENTARES")]
        public string InformacoesComplementares { get; set; }

        [DisplayName("CPF")]
        public string CPF { get; set; }

        [DisplayName("CNPJ")]
        public string CNPJ { get; set; }

        [DisplayName("IE")]
        public string IE { get; set; }

        [DisplayName("IESUBSTITUTOTRIBUTARIO")]
        public string IESubstitutoTributario { get; set; }

        [DisplayName("CODCIDADE")]
        public int? CodCidade { get; set; }

        [DisplayName("CIDADE")]
        public string Cidade { get; set; }

        [DisplayName("UF")]
        public string UF { get; set; }

        [DisplayName("CEP")]
        public string CEP { get; set; }

        [DisplayName("ENDERECO")]
        public string Endereco { get; set; }

        [DisplayName("BAIRRO")]
        public string Bairro { get; set; }

        [DisplayName("TELEFONE")]
        public string Telefone { get; set; }

        [DisplayName("EMAIL")]
        public string Email { get; set; }

        [DisplayName("SITEFORNECEDOR")]
        public string SiteFornecedor { get; set; }

        [DisplayName("HORASAIDA")]
        public TimeSpan? HoraSaida { get; set; }

        [DisplayName("CODIGOANTT")]
        public string CodigoANTT { get; set; }

        [DisplayName("PLACAVAICULO")]
        public string PlacaVeiculo { get; set; }

        [DisplayName("UFTRANSPORTADORA")]
        public string UFTransportadora { get; set; }

        [DisplayName("CNPJTRANSPORTADORA")]
        public string CNPJTransportadora { get; set; }

        [DisplayName("CPFTRANSPORTADORA")]
        public string CPFTransportadora { get; set; }

        [DisplayName("ENDERECOTRANSPORTADORA")]
        public string EnderecoTransportadora { get; set; }

        [DisplayName("CODCIDADETRANSPORTADORA")]
        public int? CodCidadeTransportadora { get; set; }

        [DisplayName("CIDADETRANSPORTADORA")]
        public string CidadeTransportadora { get; set; }

        [DisplayName("BAIRROTRANSPORTADORA")]
        public string BairroTransportadora { get; set; }

        [DisplayName("CEPTRANSPORTADORA")]
        public string CEPTransportadora { get; set; }

        [DisplayName("IETRANSPORTADORA")]
        public string IETransportadora { get; set; }

        [DisplayName("QTDEVOLUME")]
        public decimal? QtdVolume { get; set; }

        [DisplayName("ESPECIEVOLUME")]
        public string EspecieVolume { get; set; }

        [DisplayName("MARCAVOLUME")]
        public string MarcaVolume { get; set; }

        [DisplayName("NUMEROVOLUME")]
        public string NumeroVolume { get; set; }

        [DisplayName("PESOBRUTONOTA")]
        public decimal? PesoBrutoNota { get; set; }

        [DisplayName("PESOLIQUIDONOTA")]
        public decimal? PesoLiquidoNota { get; set; }

        [DisplayName("OBS")]
        public string Observacao { get; set; }

        [DisplayName("FORMAPAGAMENTO")]
        public string FormaPagamento { get; set; }

        [DisplayName("CODOPERACAO")]
        public int? CodOperacao { get; set; }

        [DisplayName("TIPOOPERACAO")]
        public string TipoOperacao { get; set; }

        [DisplayName("MOVIMENTAESTOQUE")]
        public string MovimentaEstoque { get; set; }

        [DisplayName("MOVIMENTAFINANCEIRO")]
        public string MovimentaFinanceiro { get; set; }

        [DisplayName("AVISTA")]
        public string AVista { get; set; }

        [DisplayName("TOTALBCIPPI")]
        public decimal? TotalBCIPPI { get; set; }

        [DisplayName("CONFIRMADA")]
        public int? Confirmada { get; set; }
    }

    public class CompraTypeConfiguration : IEntityTypeConfiguration<Compra>
    {
        public void Configure(EntityTypeBuilder<Compra> builder)
        {
            builder.ToTable("TCOMPRA");

            builder.HasKey(e => e.Controle);

            builder.Property(e => e.Controle).HasColumnName("CONTROLE").IsRequired();

            builder.Property(e => e.NumeroNota).HasColumnName("NUMERONOTA");

            builder.Property(e => e.NaturezaOperacao).HasColumnName("NATUREZAOPERACAO");

            builder.Property(e => e.Modelo).HasColumnName("MODELO");

            builder.Property(e => e.Serie).HasColumnName("SERIE");

            builder.Property(e => e.SubSerie).HasColumnName("SUBSERIE");

            builder.Property(e => e.DataHoraCadastro).HasColumnName("DATAHORACADASTRO");

            builder.Property(e => e.DataEmissao).HasColumnName("DATAEMISSAO");

            builder.Property(e => e.DataRecebimento).HasColumnName("DATARECEBIMENTO");

            builder.Property(e => e.CodFornecedor).HasColumnName("CODFORNECEDOR");

            builder.Property(e => e.Fornecedor).HasColumnName("FORNECEDOR");

            builder.Property(e => e.CodTransportadora).HasColumnName("CODTRANSPORTADORA");

            builder.Property(e => e.Transportadora).HasColumnName("TRANSPORTADORA");

            builder.Property(e => e.BaseCalcICMS).HasColumnName("BASECALCICMS");

            builder.Property(e => e.ValorICMS).HasColumnName("VALORICMS");

            builder.Property(e => e.TotalReducaoICMS).HasColumnName("TOTALREDUCAOICMS");

            builder.Property(e => e.BaseCalcICMSST).HasColumnName("BASECALCICMSST");

            builder.Property(e => e.ValorICMSSubstituicao).HasColumnName("VALORICMSSUBSTITUICAO");

            builder.Property(e => e.TotalBCIPI).HasColumnName("TOTALBCIPI");

            builder.Property(e => e.ValorTotalIPI).HasColumnName("VALORTOTALIPI");

            builder.Property(e => e.TotalPIS).HasColumnName("TOTALPIS");

            builder.Property(e => e.TotalPISSub).HasColumnName("TOTALPISSUB");

            builder.Property(e => e.TotalCOFINS).HasColumnName("TOTALCOFINS");

            builder.Property(e => e.TotalCOFINSSub).HasColumnName("TOTALCOFINSSUB");

            builder.Property(e => e.ModoFrete).HasColumnName("MODOFRETE");

            builder.Property(e => e.TipoFrete).HasColumnName("TIPOFRETE");

            builder.Property(e => e.ValorICMSFrete).HasColumnName("VALORICMSFRETE");

            builder.Property(e => e.ValorFrete).HasColumnName("VALORFRETE");

            builder.Property(e => e.ValorSeguro).HasColumnName("VALORSEGURO");

            builder.Property(e => e.PercDesconto).HasColumnName("PERCDESCONTO");

            builder.Property(e => e.ValorDesconto).HasColumnName("VALORDESCONTO");

            builder.Property(e => e.OutrasDespesas).HasColumnName("OUTRASDESPESAS");

            builder.Property(e => e.TotalServicos).HasColumnName("TOTALSERVICOS");

            builder.Property(e => e.ValorTotalProduto).HasColumnName("VALORTOTALPRODUTO");

            builder.Property(e => e.ValorEntrada).HasColumnName("VALORENTRADA");

            builder.Property(e => e.ValorTotalNota).HasColumnName("VALORTOTALNOTA");

            builder.Property(e => e.NFE).HasColumnName("NFE");

            builder.Property(e => e.ProtocoloDaNFE).HasColumnName("PROTOCOLODANFE");

            builder.Property(e => e.ChaveAcessoDaNFE).HasColumnName("CHAVEACESSODANFE");

            builder.Property(e => e.InformacoesComplementares).HasColumnName("INFORMACOESCOMPLEMENTARES");

            builder.Property(e => e.CPF).HasColumnName("CPF");

            builder.Property(e => e.CNPJ).HasColumnName("CNPJ");

            builder.Property(e => e.IE).HasColumnName("IE");

            builder.Property(e => e.IESubstitutoTributario).HasColumnName("IESUBSTITUTOTRIBUTARIO");

            builder.Property(e => e.CodCidade).HasColumnName("CODCIDADE");

            builder.Property(e => e.Cidade).HasColumnName("CIDADE");

            builder.Property(e => e.UF).HasColumnName("UF");

            builder.Property(e => e.CEP).HasColumnName("CEP");

            builder.Property(e => e.Endereco).HasColumnName("ENDERECO");

            builder.Property(e => e.Bairro).HasColumnName("BAIRRO");

            builder.Property(e => e.Telefone).HasColumnName("TELEFONE");

            builder.Property(e => e.Email).HasColumnName("EMAIL");

            builder.Property(e => e.SiteFornecedor).HasColumnName("SITEFORNECEDOR");

            builder.Property(e => e.HoraSaida).HasColumnName("HORASAIDA");

            builder.Property(e => e.CodigoANTT).HasColumnName("CODIGOANTT");

            builder.Property(e => e.PlacaVeiculo).HasColumnName("PLACAVAICULO");

            builder.Property(e => e.UFTransportadora).HasColumnName("UFTRANSPORTADORA");

            builder.Property(e => e.CNPJTransportadora).HasColumnName("CNPJTRANSPORTADORA");

            builder.Property(e => e.CPFTransportadora).HasColumnName("CPFTRANSPORTADORA");

            builder.Property(e => e.EnderecoTransportadora).HasColumnName("ENDERECOTRANSPORTADORA");

            builder.Property(e => e.CodCidadeTransportadora).HasColumnName("CODCIDADETRANSPORTADORA");

            builder.Property(e => e.CidadeTransportadora).HasColumnName("CIDADETRANSPORTADORA");

            builder.Property(e => e.BairroTransportadora).HasColumnName("BAIRROTRANSPORTADORA");

            builder.Property(e => e.CEPTransportadora).HasColumnName("CEPTRANSPORTADORA");

            builder.Property(e => e.IETransportadora).HasColumnName("IETRANSPORTADORA");

            builder.Property(e => e.QtdVolume).HasColumnName("QTDEVOLUME");

            builder.Property(e => e.EspecieVolume).HasColumnName("ESPECIEVOLUME");

            builder.Property(e => e.MarcaVolume).HasColumnName("MARCAVOLUME");

            builder.Property(e => e.NumeroVolume).HasColumnName("NUMEROVOLUME");

            builder.Property(e => e.PesoBrutoNota).HasColumnName("PESOBRUTONOTA");

            builder.Property(e => e.PesoLiquidoNota).HasColumnName("PESOLIQUIDONOTA");

            builder.Property(e => e.Observacao).HasColumnName("OBS");

            builder.Property(e => e.FormaPagamento).HasColumnName("FORMAPAGAMENTO");

            builder.Property(e => e.CodOperacao).HasColumnName("CODOPERACAO");

            builder.Property(e => e.TipoOperacao).HasColumnName("TIPOOPERACAO");

            builder.Property(e => e.MovimentaEstoque).HasColumnName("MOVIMENTAESTOQUE");

            builder.Property(e => e.MovimentaFinanceiro).HasColumnName("MOVIMENTAFINANCEIRO");

            builder.Property(e => e.AVista).HasColumnName("AVISTA");

            builder.Property(e => e.TotalBCIPPI).HasColumnName("TOTALBCIPPI");

            builder.Property(e => e.Confirmada).HasColumnName("CONFIRMADA");
        }
    }
}
