using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fiscal.Forms
{
    public partial class Sped : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
                int nLeft,
                int nTop,
                int nRight,
                int nBottom,
                int nWitdthEllipse,
                int nHeightEllipse
            );

        private const int BORDER_SIZE = 4;
        public Sped()
        {
            InitializeComponent();

            dateTimePickerDataInicio.ValueChanged += DateTimePickerDataInicio_ValueChanged;
            dateTimePickerDataInicio.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            DateTime ultimoDiaMes = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month));
            dateTimePickerDataFinal.Value = ultimoDiaMes;
        }

        #region PersonalizaForm

        [DllImport("DwmApi")]


        private static extern int DwmSetWindowAttribute(IntPtr hwn, int attr, int[] attrValue, int attrSize);

        protected override void OnHandleCreated(EventArgs e)
        {
            if (DwmSetWindowAttribute(Handle, 19, new[] { 1 }, 4) != 0)
            {
                DwmSetWindowAttribute(Handle, 20, new[] { 1 }, 4);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle,
            Color.Black, BORDER_SIZE, ButtonBorderStyle.Solid,
            Color.Black, BORDER_SIZE, ButtonBorderStyle.Solid,
            Color.Black, BORDER_SIZE, ButtonBorderStyle.Solid,
            Color.Black, BORDER_SIZE, ButtonBorderStyle.Solid);
        }

        #endregion

        private void DateTimePickerDataInicio_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerDataFinal.Value = new DateTime(dateTimePickerDataInicio.Value.Year, dateTimePickerDataInicio.Value.Month, 1);
            DateTime primeiroDiaSelecionado = dateTimePickerDataInicio.Value;
            DateTime ultimoDiaSelecionado = new DateTime(primeiroDiaSelecionado.Year, primeiroDiaSelecionado.Month, DateTime.DaysInMonth(primeiroDiaSelecionado.Year, primeiroDiaSelecionado.Month));
            dateTimePickerDataFinal.Value = ultimoDiaSelecionado;
        }

        private void Sped_Load(object sender, EventArgs e)
        {
            btnConfirmar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnConfirmar.Width, btnConfirmar.Height, 4, 4));
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            BlocosSped blocosSped = new BlocosSped();
            blocosSped.sped = this;
            string registro = blocosSped.registroSped();
            string registroSped = registro;

            DateTime dataInicial = dateTimePickerDataInicio.Value;

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "Arquivos de Texto (*.txt)|*.txt";
            saveFileDialog1.Title = "Salvar Arquivo SPED";
            saveFileDialog1.FileName = "Sped " + dataInicial.ToString("MM-yyyy");
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string caminhoArquivo = saveFileDialog1.FileName;

                try
                {
                    File.WriteAllText(caminhoArquivo, registroSped);

                    MessageBox.Show("SPED gerado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao gerar o arquivo SPED: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
