using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiscal
{
    public class Emitente
    {
        [DisplayName("Controle")]
        public int Controle { get; set; }

        [DisplayName("Nome fantasia")]
        public string NomeFantasia { get; set; }

        [DisplayName("Razão social")]
        public string RazaoSocial { get; set; }

        [DisplayName("Endereço")]
        public string Endereco { get; set; }

        [DisplayName("Complemento")]
        public string Complemento { get; set; }

        [DisplayName("Bairro")]
        public string Bairro { get; set; }

        [DisplayName("Código cidade")]
        public int CodCidade { get; set; }

        [DisplayName("Cidade")]
        public string Cidade { get; set; }

        [DisplayName("UF")]
        public string UF { get; set; }

        [DisplayName("CEP")]
        public string CEP { get; set; }

        [DisplayName("CNPJ")]
        public string CNPJ { get; set; }

        [DisplayName("IE")]
        public string IE { get; set; }

        [DisplayName("IM")]
        public string IM { get; set; }

        [DisplayName("Data e hora cadastro")]
        public DateTime DataHoraCadastro { get; set; }

        [DisplayName("Obs")]
        public string Obs { get; set; }

        [DisplayName("Telefone")]
        public string Telefone { get; set; }

        [DisplayName("Celular")]
        public string Celular { get; set; }

        [DisplayName("E-mail")]
        public string Email { get; set; }

        [DisplayName("FAX")]
        public string Fax { get; set; }

        [DisplayName("Atividade")]
        public string Atividade { get; set; }

        [DisplayName("CNAE")]
        public string CNAE { get; set; }

        [DisplayName("CRT")]
        public string CRT { get; set; }

        [DisplayName("Data fundação empresa")]
        public DateTime DataFundacaoEmpresa { get; set; }

        [DisplayName("Logotipo")]
        public string Logotipo { get; set; }

        [DisplayName("País")]
        public string Pais { get; set; }

        [DisplayName("Número")]
        public string Numero { get; set; }

        [DisplayName("Cód ICMS")]
        public int CodICMS { get; set; }

        [DisplayName("Cód cidade IBGE")]
        public string CodCidadeIBGE { get; set; }

        [DisplayName("Data movimento")]
        public DateTime DataMovimento { get; set; }

        [DisplayName("Hora primeiro documento ECF")]
        public DateTime HoraPrimeiroDocumentoECF { get; set; }

        [DisplayName("SUFRAMA")]
        public string SUFRAMA { get; set; }

        [DisplayName("Serie ECF")]
        public string SerieECF { get; set; }

        [DisplayName("Marca ECF")]
        public string MarcaECF { get; set; }

        [DisplayName("Modelo ECF")]
        public string ModeloECF { get; set; }

        [DisplayName("Tipo ECF")]
        public string TipoECF { get; set; }

        [DisplayName("MD5")]
        public string MD5 { get; set; }

        [DisplayName("Verificador FB")]
        public string VerificadorFB { get; set; }

        [DisplayName("Data e hora verificação RFB")]
        public DateTime DataHoraVerificacaoRFB { get; set; }

        [DisplayName("Captcha RFB")]
        public string CaptchaRFB { get; set; }

        [DisplayName("Retorno RFB")]
        public string RetornoRFB { get; set; }

        [DisplayName("Autorizado uso")]
        public string AutorizadoUso { get; set; }

        [DisplayName("MD5CNPJRAZAOUFRFB")]
        public string MD5CNPJRazaoUFRFB { get; set; }

        [DisplayName("Serial instalado")]
        public string SerialInstalado { get; set; }

        [DisplayName("Alíquota ISSQN")]
        public decimal AliquotaISSQN { get; set; }

        [DisplayName("Cód imposto ISS")]
        public int CodImpostoISS { get; set; }

        [DisplayName("Nota legal")]
        public string NotaLegalDF { get; set; }

        [DisplayName("E3 serie ECF")]
        public string E3SerieECF { get; set; }

        [DisplayName("E3 tipo ECF")]
        public string E3TipoECF { get; set; }

        [DisplayName("E3 marca ECF")]
        public string E3MarcaECF { get; set; }

        [DisplayName("E3 modelo ECF")]
        public string E3ModeloECF { get; set; }

        [DisplayName("Atacado e varejo")]
        public string AtacadoEVarejo { get; set; }

        [DisplayName("MD5BOS")]
        public string MD5BOS { get; set; }

        [DisplayName("MD5P")]
        public string MD5P { get; set; }

        [DisplayName("MD5L")]
        public string MD5L { get; set; }

        [DisplayName("CPF")]
        public string CPF { get; set; }

        [DisplayName("MD5V")]
        public string MD5V { get; set; }

        [DisplayName("RNTRC")]
        public string RNTRC { get; set; }

        [DisplayName("MD5B")]
        public string MD5B { get; set; }

        [DisplayName("Site 2")]
        public string SITE2 { get; set; }

        [DisplayName("Regime tributário ISSQN")]
        public string RegimeTributarioISSQN { get; set; }

        [DisplayName("Site")]
        public string SITE { get; set; }

        [DisplayName("CNPJ contador")]
        public string CNPJContador { get; set; }

        [DisplayName("Versão servidor")]
        public int VersaoServidor { get; set; }

        [DisplayName("Release servidor")]
        public int ReleaseServidor { get; set; }

        [DisplayName("Chave PP")]
        public string ChavePP { get; set; }

        [DisplayName("Controle SG")]
        public string ControleSG { get; set; }

        [DisplayName("MD5PAF")]
        public string MD5PAF { get; set; }

        [DisplayName("Perc ICMS")]
        public decimal PercICMS { get; set; }

        [DisplayName("OC")]
        public string OC { get; set; }

        [DisplayName("Date IE")]
        public DateTime DataIE { get; set; }

        [DisplayName("Número credenciamento")]
        public int NumeroCredenciamento { get; set; }

        [DisplayName("Possui IE substituto")]
        public string PossuiIESubstituto { get; set; }

        [DisplayName("Atualizar estoque")]
        public string AtualizarEstoque { get; set; }

        [DisplayName("Comparando")]
        public string Comparando { get; set; }

        [DisplayName("Estabelecimento único")]
        public string EstabelecimentoUnico { get; set; }

        [DisplayName("MD5CAD")]
        public string MD5CAD { get; set; }

        [DisplayName("Atualizar data venda compra")]
        public string AtualizarDataVendaCompra { get; set; }

        [DisplayName("Reservar produto aluguel condi")]
        public string ReservarProdAluguelCondi { get; set; }

        [DisplayName("Atualizar estoque parcial")]
        public string AtualizarEstoqueParcial { get; set; }

        [DisplayName("Utilizar")]
        public string UtilizarBaixaMP { get; set; }

        [DisplayName("Número licença")]
        public string NumLicenca { get; set; }

        [DisplayName("Número aut especial")]
        public string NumAutEspecial { get; set; }

        [DisplayName("Número aut funcionamento")]
        public string NumAutFuncionamento { get; set; }

        [DisplayName("MD5I")]
        public string MD5I { get; set; }

        [DisplayName("Sincronizado")]
        public string Sincronizado { get; set; }

        [DisplayName("Cód atividade")]
        public int CodAtividade { get; set; }

        [DisplayName("Empresa UUIDTEF")]
        public string EmpresaUUIDTEF { get; set; }
    }

    public class EmitenteEntityTypeConfiguration : IEntityTypeConfiguration<Emitente>
    {
        public void Configure(EntityTypeBuilder<Emitente> builder) 
        {
            builder.ToTable("TEMITENTE");

            builder.HasKey(e => e.Controle);

            builder.Property(e => e.Controle).HasColumnName("CONTROLE").IsRequired();

            builder.Property(e => e.NomeFantasia).HasColumnName("NOMEFANTASIA");

            builder.Property(e => e.RazaoSocial).HasColumnName("RAZAOSOCIAL").IsRequired();

            builder.Property(e => e.Endereco).HasColumnName("ENDERECO").IsRequired();

            builder.Property(e => e.Complemento).HasColumnName("COMPLEMENTO").IsRequired();

            builder.Property(e => e.Bairro).HasColumnName("BAIRRO");

            builder.Property(e => e.CodCidade).HasColumnName("CODCIDADE");

            builder.Property(e => e.Cidade).HasColumnName("CIDADE").IsRequired();

            builder.Property(e => e.UF).HasColumnName("UF").IsRequired();

            builder.Property(e => e.CEP).HasColumnName("CEP").IsRequired();

            builder.Property(e => e.CNPJ).HasColumnName("CNPJ");

            builder.Property(e => e.IE).HasColumnName("IE");

            builder.Property(e => e.IM).HasColumnName("IM");

            builder.Property(e => e.DataHoraCadastro).HasColumnName("DATAHORACADASTRO").IsRequired();

            builder.Property(e => e.Obs).HasColumnName("OBS");

            builder.Property(e => e.Telefone).HasColumnName("TELEFONE");

            builder.Property(e => e.Celular).HasColumnName("CELULAR");

            builder.Property(e => e.Email).HasColumnName("EMAIL");

            builder.Property(e => e.Fax).HasColumnName("FAX");

            builder.Property(e => e.Atividade).HasColumnName("ATIVIDADE");

            builder.Property(e => e.CNAE).HasColumnName("CNAE");

            builder.Property(e => e.CRT).HasColumnName("CRT");

            builder.Property(e => e.DataFundacaoEmpresa).HasColumnName("DATAFUNDACAOEMPRESA");

            builder.Property(e => e.Logotipo).HasColumnName("LOGOTIPO");

            builder.Property(e => e.Pais).HasColumnName("PAIS").IsRequired();

            builder.Property(e => e.Numero).HasColumnName("NUMERO");

            builder.Property(e => e.CodICMS).HasColumnName("CODICMS");

            builder.Property(e => e.CodCidadeIBGE).HasColumnName("CODCIDADEIBGE").IsRequired();

            builder.Property(e => e.DataMovimento).HasColumnName("DATAMOVIMENTO");

            builder.Property(e => e.HoraPrimeiroDocumentoECF).HasColumnName("HORAPRIMEIRODOCUMENTOECF");

            builder.Property(e => e.SUFRAMA).HasColumnName("SUFRAMA");

            builder.Property(e => e.SerieECF).HasColumnName("SERIEECF");

            builder.Property(e => e.MarcaECF).HasColumnName("MARCAECF");

            builder.Property(e => e.ModeloECF).HasColumnName("MODELOECF");

            builder.Property(e => e.TipoECF).HasColumnName("TIPOECF");

            builder.Property(e => e.MD5).HasColumnName("MD5");

            builder.Property(e => e.VerificadorFB).HasColumnName("VERIFICADORFB").IsRequired();

            builder.Property(e => e.DataHoraVerificacaoRFB).HasColumnName("DATAHORAVERIFICACAORFB");

            builder.Property(e => e.CaptchaRFB).HasColumnName("CAPTCHARFB");

            builder.Property(e => e.RetornoRFB).HasColumnName("RETORNORFB");

            builder.Property(e => e.AutorizadoUso).HasColumnName("AUTORIZADOUSO").IsRequired();

            builder.Property(e => e.MD5CNPJRazaoUFRFB).HasColumnName("MD5CNPJRAZAOUFRFB");

            builder.Property(e => e.SerialInstalado).HasColumnName("SERIALINSTALADO");

            builder.Property(e => e.AliquotaISSQN).HasColumnName("ALIQUOTAISSQN");

            builder.Property(e => e.CodImpostoISS).HasColumnName("CODIMPOSTOISS");

            builder.Property(e => e.NotaLegalDF).HasColumnName("NOTALEGALDF");

            builder.Property(e => e.E3SerieECF).HasColumnName("E3SERIEECF");

            builder.Property(e => e.E3TipoECF).HasColumnName("E3TIPOECF");

            builder.Property(e => e.E3MarcaECF).HasColumnName("E3MARCAECF");

            builder.Property(e => e.E3ModeloECF).HasColumnName("E3MODELOECF");

            builder.Property(e => e.AtacadoEVarejo).HasColumnName("ATACADOEVAREJO");

            builder.Property(e => e.MD5BOS).HasColumnName("MD5BOS");

            builder.Property(e => e.MD5P).HasColumnName("MD5P");

            builder.Property(e => e.MD5L).HasColumnName("MD5L");

            builder.Property(e => e.CPF).HasColumnName("CPF");

            builder.Property(e => e.MD5V).HasColumnName("MD5V");

            builder.Property(e => e.RNTRC).HasColumnName("RNTRC");

            builder.Property(e => e.MD5B).HasColumnName("MD5B");

            builder.Property(e => e.SITE2).HasColumnName("SITE2");

            builder.Property(e => e.RegimeTributarioISSQN).HasColumnName("REGIMETRIBUTARIOISSQN");

            builder.Property(e => e.SITE).HasColumnName("SITE");

            builder.Property(e => e.CNPJContador).HasColumnName("CNPJCONTADOR");

            builder.Property(e => e.VersaoServidor).HasColumnName("VERSAOSERVIDOR");

            builder.Property(e => e.ReleaseServidor).HasColumnName("RELEASESERVIDOR");

            builder.Property(e => e.ChavePP).HasColumnName("CHAVEPP");

            builder.Property(e => e.ControleSG).HasColumnName("CONTROLESG");

            builder.Property(e => e.MD5PAF).HasColumnName("MD5PAF");

            builder.Property(e => e.PercICMS).HasColumnName("PERCICMS");

            builder.Property(e => e.OC).HasColumnName("OC");

            builder.Property(e => e.DataIE).HasColumnName("DATAIE");

            builder.Property(e => e.NumeroCredenciamento).HasColumnName("NUMEROCREDENCIAMENTO");

            builder.Property(e => e.PossuiIESubstituto).HasColumnName("POSSUIIESUBSTITUTO");

            builder.Property(e => e.AtualizarEstoque).HasColumnName("ATUALIZARESTOQUE").IsRequired();

            builder.Property(e => e.Comparando).HasColumnName("COMPARANDO").IsRequired();

            builder.Property(e => e.EstabelecimentoUnico).HasColumnName("ESTABELECIMENTOUNICO");

            builder.Property(e => e.MD5CAD).HasColumnName("MD5CAD");

            builder.Property(e => e.AtualizarDataVendaCompra).HasColumnName("ATUALIZARDATAVENDACOMPRA").IsRequired();

            builder.Property(e => e.ReservarProdAluguelCondi).HasColumnName("RESERVARPRODALUGUELCONDI").IsRequired();

            builder.Property(e => e.AtualizarEstoqueParcial).HasColumnName("ATUALIZARESTOQUEPARCIAL");

            builder.Property(e => e.UtilizarBaixaMP).HasColumnName("UTILIZARBAIXAMP");

            builder.Property(e => e.NumLicenca).HasColumnName("NUMLICENCA");

            builder.Property(e => e.NumAutEspecial).HasColumnName("NUMAUTESPECIAL");

            builder.Property(e => e.NumAutFuncionamento).HasColumnName("NUMAUTFUNCIONAMENTO");

            builder.Property(e => e.MD5I).HasColumnName("MD5I");

            builder.Property(e => e.Sincronizado).HasColumnName("SINCRONIZADO");

            builder.Property(e => e.CodAtividade).HasColumnName("CODATIVIDADE");

            builder.Property(e => e.EmpresaUUIDTEF).HasColumnName("EMPRESAUUIDTEF");
        }
    }
}