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

        //Sped sped = new Sped();



        private string SoNumeros(string texto)
        {
            if(string.IsNullOrEmpty(texto))
                return texto;

            texto = Regex.Replace(texto, @"[^0-9]", "");

            return texto;
        }
        public string registro0000()
        {
            var registro = "";

            using (var dc = new DataContext())
            {
                IQueryable<Emitente> emitente = dc.Emitente.AsQueryable().Where(d => d.Controle == 1);
                var dadosEmitente = emitente.ToList();

                foreach (var e in emitente)
                {
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
                    else
                    {
                        // Se nenhum RadioButton estiver marcado, faça algo ou emita um aviso
                        MessageBox.Show("Por favor, selecione uma finalidade.");
                    }
                    registro += sped.dateTimePickerDataInicio.Value.Date.ToShortDateString().Replace("/", "") + "|";
                    registro += sped.dateTimePickerDataFinal.Value.Date.ToShortDateString().Replace("/", "") + "|";
                    registro += e.RazaoSocial + "|";
                    registro += SoNumeros(e.CNPJ) + "|";
                    registro += e.CPF + "|";
                }
                
            return registro;

            }
        }
    }
}
