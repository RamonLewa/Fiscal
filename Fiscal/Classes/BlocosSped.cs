using Fiscal.Classes;
using Fiscal.Forms;
using Fiscal.Tables;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fiscal
{
    public class BlocosSped
    {
        public Sped sped;

        public string registroSped()
        {
            var registro = "";

            using (var dc = new DataContext())
            {
                DateTime dataInicial = sped.dateTimePickerDataInicio.Value;
                DateTime dataFinal = sped.dateTimePickerDataFinal.Value;

                var emitente = dc.Emitente.FirstOrDefault();
                var dadoContabilista = dc.DadoContabilista.FirstOrDefault();
                var fornecedor = dc.Fornecedor.ToList();
                var cliente = dc.Cliente.ToList();
                var estoque = dc.Estoque.ToList();

                var vendaNFCe = dc.VendaNFCe.ToList().Where(nfc => (nfc.StatusEnvio == "Autorizado o uso da NF-e" || nfc.StatusEnvio == "Emitida em contingência")
                    && nfc.Inutilizada == null
                    && nfc.ProtocoloCancelamento == null
                    && nfc.SAT == "NÃO"
                    && (nfc.DataEmissao >= dataInicial && nfc.DataEmissao <= dataFinal));

                var vendaNFe = dc.VendaNFe.ToList().Where(nfe => nfe.Cancelada != "SIM"
                    && nfe.TipoOperacao == "1"
                    && nfe.Protocolo != ""
                    && nfe.Denegada != "SIM"
                    && (nfe.DataEmissao >= dataInicial && nfe.DataEmissao <= dataFinal));

                var compras = dc.Compra.ToList().Where(com => com.Confirmada == 1
                && (com.DataEmissao >= dataInicial && com.DataEmissao <= dataFinal));

                #region Select 0150

                var select0150nfce = vendaNFCe.Join(cliente, nfc => nfc.CodCliente, cli => cli.Controle, (nfc, cli) => new
                {
                    nfc.DataEmissao,
                    cli.Controle,
                    cli.NomeCliente,
                    cli.CodigoPais,
                    cli.CNPJ,
                    cli.CPF,
                    cli.IE,
                    cli.CodigoCidadeIGBE,
                    cli.SUFRAMA,
                    cli.Endereco,
                    cli.Numero,
                    cli.Complemento,
                    cli.Bairro,
                    nfc.StatusEnvio,
                    nfc.Inutilizada,
                    nfc.ProtocoloCancelamento,
                    nfc.SAT
                });

                var select0150nfe = vendaNFe.Join(cliente, nfe => nfe.CodCliente, cli => cli.Controle, (nfe, cli) => new
                {
                    nfe.DataEmissao,
                    cli.Controle,
                    cli.NomeCliente,
                    cli.CodigoPais,
                    cli.CNPJ,
                    cli.CPF,
                    cli.IE,
                    cli.CodigoCidadeIGBE,
                    cli.SUFRAMA,
                    cli.Endereco,
                    cli.Numero,
                    cli.Complemento,
                    cli.Bairro,
                    nfe.Cancelada,
                    nfe.TipoOperacao,
                    nfe.Protocolo,
                    nfe.Denegada
                });

                var select0150compra = compras.Join(fornecedor, com => com.CodFornecedor, forn => forn.Controle, (com, forn) => new
                {
                    com.DataEmissao,
                    forn.Controle,
                    forn.RazaoSocial,
                    forn.CodigoPais,
                    forn.CNPJ,
                    forn.CPF,
                    forn.IE,
                    forn.CodigoCidadeIBGE,
                    forn.Suframa,
                    forn.Endereco,
                    forn.Numero,
                    forn.Complemento,
                    forn.Bairro,
                    com.Confirmada
                });

                var distinctSelect0150Nfce = select0150nfce.GroupBy(e => new {
                    e.Controle,
                    e.NomeCliente,
                    e.CodigoPais,
                    e.CNPJ,
                    e.CPF,
                    e.IE,
                    e.CodigoCidadeIGBE,
                    e.SUFRAMA,
                    e.Endereco,
                    e.Numero,
                    e.Complemento,
                    e.Bairro
                }).Select(group => group.First());

                var distinctSelect0150Nfe = select0150nfe.GroupBy(e => new
                {
                    e.Controle,
                    e.NomeCliente,
                    e.CodigoPais,
                    e.CNPJ,
                    e.CPF,
                    e.IE,
                    e.CodigoCidadeIGBE,
                    e.SUFRAMA,
                    e.Endereco,
                    e.Numero,
                    e.Complemento,
                    e.Bairro
                }).Select(group => group.First());

                var distinctSelect0150compra = select0150compra.GroupBy(e => new
                {
                    e.Controle,
                    e.RazaoSocial,
                    e.CodigoPais,
                    e.CNPJ,
                    e.CPF,
                    e.IE,
                    e.CodigoCidadeIBGE,
                    e.Suframa,
                    e.Endereco,
                    e.Numero,
                    e.Complemento,
                    e.Bairro
                }).Select(group => group.First());

                #endregion

                #region Registro 0000

                registro += "|" + "0000" + "|";
                registro += sped.txtLeiaute.Text + "|";
                if (sped.radioFinalidadeOrig.Checked)
                {
                    registro += "0" + "|";
                }
                else if (sped.radioFinalidadeSubst.Checked)
                {
                    registro += "1" + "|";
                }
                registro += Functions.RemoveCaracteres(sped.dateTimePickerDataInicio.Value.Date.ToShortDateString()) + "|";
                registro += Functions.RemoveCaracteres(sped.dateTimePickerDataFinal.Value.Date.ToShortDateString()) + "|";
                registro += emitente.RazaoSocial + "|";
                registro += Functions.RemoveCaracteres(emitente.CNPJ) + "|";
                registro += Functions.RemoveCaracteres(emitente.CPF) + "|";
                registro += emitente.UF + "|";
                registro += emitente.IE + "|";
                registro += emitente.CodCidadeIBGE + "|";
                registro += emitente.IM + "|";
                registro += emitente.SUFRAMA + "|";
                if (sped.radioPerfilA.Checked == true)
                {
                    registro += "A" + "|";

                } else if(sped.radioPerfilB.Checked == true)
                {
                    registro += "B" + "|";

                } else if (sped.radioPerfilC.Checked == true)
                {
                    registro += "C" + "|";
                }
                if (sped.radioButtonAtividadeOutros.Checked == true)
                {
                    registro += "1" + "|\n";
                } else if (sped.radioButtonAtividadeIndustria.Checked == true)
                {
                    registro += "0" + "|\n";
                }

                #endregion

                #region Registro 0001

                registro += "|" + "0001" + "|";
                registro += "0" + "|\n";

                #endregion

                #region Registro 0005

                registro += "|" + "0005" + "|";
                registro += emitente.NomeFantasia + "|";
                registro += Functions.RemoveCaracteres(emitente.CEP) + "|";
                registro += emitente.Endereco + "|";
                registro += emitente.Numero + "|";
                registro += emitente.Complemento + "|";
                registro += emitente.Bairro + "|";
                registro += Functions.RemoveCaracteres(emitente.Telefone) + "|";
                registro += Functions.RemoveCaracteres(emitente.Fax) + "|";
                registro += emitente.Email + "|\n";

                #endregion

                #region Registro 0100

                registro += "|" + "0100" + "|";
                registro += dadoContabilista.Nome + "|";
                registro += Functions.RemoveCaracteres(dadoContabilista.CPF) + "|";
                registro += dadoContabilista.CRC + "|";
                registro += Functions.RemoveCaracteres(dadoContabilista.CNPJ) + "|";
                registro += Functions.RemoveCaracteres(dadoContabilista.CEP) + "|";
                registro += dadoContabilista.Endereco + "|";
                registro += dadoContabilista.Numero + "|";
                registro += dadoContabilista.Complemento + "|";
                registro += dadoContabilista.Bairro + "|";
                registro += Functions.RemoveCaracteres(dadoContabilista.Telefone) + "|";
                registro += dadoContabilista.FAX + "|";
                registro += dadoContabilista.Email + "|";
                registro += dadoContabilista.Codmunicipio + "|\n";

                #endregion

                #region Registro 0150

                // NFCe
                foreach (var c in distinctSelect0150Nfce)
                {
                    registro += "|" + "150" + "|";
                    registro += c.Controle + "|";
                    registro += c.NomeCliente + "|";
                    registro += c.CodigoPais + "|";
                    registro += Functions.RemoveCaracteres(c.CNPJ) + "|";
                    registro += Functions.RemoveCaracteres(c.CPF) + "|";
                    registro += c.IE + "|";
                    registro += c.CodigoCidadeIGBE + "|";
                    registro += c.SUFRAMA + "|";
                    registro += c.Endereco + "|";
                    registro += c.Numero + "|";
                    registro += c.Complemento + "|";
                    registro += c.Bairro + "|\n";
                }

                // NFe
                foreach (var c in distinctSelect0150Nfe)
                {
                    registro += "|" + "150" + "|";
                    registro += c.Controle + "|";
                    registro += c.NomeCliente + "|";
                    registro += c.CodigoPais + "|";
                    registro += Functions.RemoveCaracteres(c.CNPJ) + "|";
                    registro += Functions.RemoveCaracteres(c.CPF) + "|";
                    registro += c.IE + "|";
                    registro += c.CodigoCidadeIGBE + "|";
                    registro += c.SUFRAMA + "|";
                    registro += c.Endereco + "|";
                    registro += c.Numero + "|";
                    registro += c.Complemento + "|";
                    registro += c.Bairro + "|\n";
                }

                // Compras
                foreach (var c in distinctSelect0150compra)
                {
                    registro += "|" + "150" + "|";
                    registro += c.Controle + "|";
                    registro += c.RazaoSocial + "|";
                    registro += c.CodigoPais + "|";
                    registro += Functions.RemoveCaracteres(c.CNPJ) + "|";
                    registro += Functions.RemoveCaracteres(c.CPF) + "|";
                    registro += c.IE + "|";
                    registro += c.CodigoCidadeIBGE + "|";
                    registro += c.Suframa + "|";
                    registro += c.Endereco + "|";
                    registro += c.Numero + "|";
                    registro += c.Complemento + "|";
                    registro += c.Bairro + "|\n";
                }

                #endregion

                #region Registro 0200

                foreach (var c in estoque)
                {
                    registro += "|" + "0200" + "|";
                    registro += c.Controle + "|";
                    registro += c.Produto + "|";
                    registro += c.CodBarras + "|";
                    registro += "|";
                    registro += c.UN + "|";
                    registro += c.CodAplicacao + "|";
                    registro += c.NCM + "|";
                    registro += "|";
                    registro += "|";
                    registro += "|";
                    registro += c.AliquotaICMS + "|";
                    registro += c.CEST + "|\n";
                }

                #endregion
            }

            return registro;

        }
    }
}