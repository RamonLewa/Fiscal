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

        public string registro0000()
        {
            var registro = "";

            using (var dc = new DataContext())
            {
                IQueryable<Emitente> emitente = dc.Emitente.AsQueryable().Where(d => d.Controle == 1);
                IQueryable<DadoContabilista> dadoContabilista = dc.DadoContabilista.AsQueryable().Where(d => d.Controle == 1);
                IQueryable<Fornecedor> fornecedor = dc.Fornecedor.AsQueryable();
                IQueryable<Cliente> cliente = dc.Cliente.AsQueryable();
                IQueryable<VendaNFCe> vendaNFCe = dc.VendaNFCe.AsQueryable();
                IQueryable<VendaNFe> vendaNFe = dc.VendaNFe.AsQueryable();
                IQueryable<Estoque> estoque = dc.Estoque.AsQueryable();
                var dadosEmitente = emitente.ToList();
                var dadosContabilista = dadoContabilista.ToList();
                var dadosFornecedor = fornecedor.ToList();
                var dadosClientes = cliente.ToList();
                var notasNFCe = vendaNFCe.ToList();
                var notasNFe = vendaNFe.ToList();
                var prodEstoque = estoque.ToList();

                DateTime dataInicial = sped.dateTimePickerDataInicio.Value;
                DateTime dataFinal = sped.dateTimePickerDataFinal.Value;

                var select0150nfce = notasNFCe.Join(dadosClientes, nfc => nfc.CodCliente, cli => cli.Controle, (nfc, cli) => new
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
                }).Where(nfc => (nfc.StatusEnvio == "Autorizado o uso da NF-e" || nfc.StatusEnvio == "Emitida em contingência")
                && nfc.Inutilizada == null
                && nfc.ProtocoloCancelamento == null
                && nfc.SAT == "NÃO"
                && (nfc.DataEmissao >= dataInicial && nfc.DataEmissao <= dataFinal)
                );

                var distinctSelect0150 = select0150nfce.GroupBy(item => new {
                    item.Controle,
                    item.NomeCliente,
                    item.CodigoPais,
                    item.CNPJ,
                    item.CPF,
                    item.IE,
                    item.CodigoCidadeIGBE,
                    item.SUFRAMA,
                    item.Endereco,
                    item.Numero,
                    item.Complemento,
                    item.Bairro,
                    item.StatusEnvio,
                    item.Inutilizada,
                    item.ProtocoloCancelamento
                }).Select(group => group.First());

                foreach (var e in emitente)
                {
                    // Registro 0000
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

                    registro += sped.dateTimePickerDataInicio.Value.Date.ToShortDateString().Replace("/", "") + "|";
                    registro += sped.dateTimePickerDataFinal.Value.Date.ToShortDateString().Replace("/", "") + "|";
                    registro += e.RazaoSocial + "|";
                    registro += Functions.RemoveCaracteres(e.CNPJ) + "|";
                    registro += Functions.RemoveCaracteres(e.CPF) + "|";
                    registro += e.UF + "|";
                    registro += e.IE + "|";
                    registro += e.CodCidadeIBGE + "|";
                    registro += e.IM + "|";
                    registro += e.SUFRAMA + "|";
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

                    // Registro 0001
                    registro += "|" + "0001" + "|";
                    registro += "0" + "|\n";

                    // Registro 0005
                    registro += "|" + "0005" + "|";
                    registro += e.NomeFantasia + "|";
                    registro += Functions.RemoveCaracteres(e.CEP) + "|";
                    registro += e.Endereco + "|";
                    registro += e.Numero + "|";
                    registro += e.Complemento + "|";
                    registro += e.Bairro + "|";
                    registro += Functions.RemoveCaracteres(e.Telefone) + "|";
                    registro += Functions.RemoveCaracteres(e.Fax) + "|";
                    registro += e.Email + "|\n";

                    // Registro 0100

                    foreach (var c in dadosContabilista)
                    {
                        registro += "|" + "0100" + "|";
                        registro += c.Nome + "|";
                        registro += Functions.RemoveCaracteres(c.CPF) + "|";
                        registro += c.CRC + "|";
                        registro += Functions.RemoveCaracteres(c.CNPJ) + "|";
                        registro += Functions.RemoveCaracteres(c.CEP) + "|";
                        registro += c.Endereco + "|";
                        registro += c.Numero + "|";
                        registro += c.Complemento + "|";
                        registro += c.Bairro + "|";
                        registro += Functions.RemoveCaracteres(c.Telefone) + "|";
                        registro += c.FAX + "|";
                        registro += c.Email + "|";
                        registro += c.Codmunicipio + "|\n";

                    }

                    // Registro 0150

                    foreach (var c in distinctSelect0150)
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

                    // Registro 0200
                    foreach(var c in prodEstoque)
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
                }
                
            return registro;

            }
        }
    }
}
