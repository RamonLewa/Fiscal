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

        private void Sped_Load(object sender, EventArgs e)
        {
            btnConfirmar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnConfirmar.Width, btnConfirmar.Height, 4, 4));
            comboBoxPrecoCusto.SelectedItem = "Preço de custo unitário";
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            BlocosSped blocosSped = new BlocosSped();
            blocosSped.sped = this;
            string registro = blocosSped.registro0000();

            string registro00 = registro;

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "Arquivos de Texto (*.txt)|*.txt";
            saveFileDialog1.Title = "Salvar Arquivo SPED";
            saveFileDialog1.FileName = "SPED" + DateTime.Now.ToString("yyyyMMdd");
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string caminhoArquivo = saveFileDialog1.FileName;

                try
                {
                    File.WriteAllText(caminhoArquivo, registro00);

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
