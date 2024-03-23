using Fiscal.Properties;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Fiscal
{
    public partial class Form1 : Form
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

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        #region PersonalizaForm
        private void Form1_Load(object sender, EventArgs e)
        {
            btnSair.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnSair.Width, btnSair.Height, 4, 4));
            btnConfiguracoes.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnConfiguracoes.Width, btnSair.Height, 4, 4));
            btnContabilista.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnContabilista.Width, btnSair.Height, 4, 4));
        }

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
        private void btnSintegra_MouseEnter(object sender, EventArgs e)
        {
            btnSintegra.BackgroundImage = Resources.sintegra_select;
        }

        private void btnSintegra_MouseLeave(object sender, EventArgs e)
        {
            btnSintegra.BackgroundImage = Resources.sintegra;
        }

        private void btnSpedFiscal_MouseEnter(object sender, EventArgs e)
        {
            btnSpedFiscal.BackgroundImage = Resources.sped_select;
        }

        private void btnSpedFiscal_MouseLeave(object sender, EventArgs e)
        {
            btnSpedFiscal.BackgroundImage = Resources.sped;
        }

        private void btnSpedContribuicoes_MouseEnter(object sender, EventArgs e)
        {
            btnSpedContribuicoes.BackgroundImage = Resources.sped_contribuições_select;
        }

        private void btnSpedContribuicoes_MouseLeave(object sender, EventArgs e)
        {
            btnSpedContribuicoes.BackgroundImage = Resources.sped_contribuições;
        }

        private void btnLCDPR_MouseEnter(object sender, EventArgs e)
        {
            btnLCDPR.BackgroundImage = Resources.lcdpr_select;
        }

        private void btnLCDPR_MouseLeave(object sender, EventArgs e)
        {
            btnLCDPR.BackgroundImage = Resources.lcdpr;
        }

        #endregion

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnContabilista_Click(object sender, EventArgs e)
        {
            Contabilista contabilista = new Contabilista();
            contabilista.ShowDialog();
        }

        private string registro0000()
        {
            var registro = "";

            using(var _context = new DataContext())
            {
                var registros = _context.DadoContabilista.Count();

                if(registros > 0) 
                {
                    var contabilistas = _context.DadoContabilista.ToList();

                    foreach(var contabilista in contabilistas)
                    {
                        registro += "00" + "|";
                        registro += contabilista.CNPJ.PadRight(12) + "|";
                        registro += contabilista.Nome.PadRight(12);

                    }
                }
            }

            return registro;
        }

        private void btnSpedFiscal_Click(object sender, EventArgs e)
        {
            string registro00 = registro0000(); 
            
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "Arquivos de Texto (*.txt)|*.txt";
            saveFileDialog1.Title = "Salvar Arquivo Sintegra";
            saveFileDialog1.FileName = "SPED" + DateTime.Now.ToString("yyyyMMdd");
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string caminhoArquivo = saveFileDialog1.FileName;

                try
                {
                    File.WriteAllText(caminhoArquivo, registro00);

                    MessageBox.Show("SPED gerado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao gerar o arquivo SPED: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}