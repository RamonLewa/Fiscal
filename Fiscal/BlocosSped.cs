using Fiscal.Classes;
using Fiscal.Forms;
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
                var dadosEmitente = emitente.ToList();
                var dadosContabilista = dadoContabilista.ToList();

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
                        registro += c.Codmunicipio + "|";
                    }
                }
                
            return registro;

            }
        }
    }
}
