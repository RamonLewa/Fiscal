using Fiscal.Forms;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fiscal
{
    public class BlocosSped
    {
        public Sped sped;

        //Sped sped = new Sped();

        public string registro0000()
        {
            var registro = "";

            using (var _context = new DataContext())
            {
                var registros = _context.DadoContabilista.Count();

                if (registros > 0)
                {
                    var contabilistas = _context.DadoContabilista.ToList();

                    foreach (var contabilista in contabilistas)
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
                        registro += contabilista.CNPJ.PadRight(12) + "|";
                        registro += contabilista.Nome.PadRight(12);

                    }
                }
            }

            return registro;
        }
    }
}
