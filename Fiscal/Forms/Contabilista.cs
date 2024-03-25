using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fiscal
{
    public partial class Contabilista : Form
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

        public Contabilista()
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

        private void Contabilista_Load(object sender, EventArgs e)
        {
            btnGravar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnGravar.Width, btnGravar.Height, 4, 4));

            using (var dc = new DataContext()) 
            {
                IQueryable<DadoContabilista> dadoContabilistas = dc.DadoContabilista.AsQueryable().Where(d => d.Controle == 1);

                var dadosContabilista = dadoContabilistas.FirstOrDefault();

                if(dadosContabilista != null)
                {
                    txtNomeContador.Text = dadosContabilista.Nome;
                    txtCnpjEscritorio.Text = dadosContabilista.CNPJ;
                    txtCrc.Text = dadosContabilista.CRC;
                    txtCpf.Text = dadosContabilista.CPF;
                    txtCep.Text = dadosContabilista.CEP;
                    txtEndereco.Text = dadosContabilista.Endereco;
                    txtNumero.Text = dadosContabilista.Numero;
                    txtComplemento.Text = dadosContabilista.Complemento;
                    txtBairro.Text = dadosContabilista.Bairro;
                    txtTelefone.Text = dadosContabilista.Telefone;
                    txtFax.Text = dadosContabilista.FAX;
                    txtEmail.Text = dadosContabilista.Email;
                    txtCodMunicipioIbge.Text = dadosContabilista.Codmunicipio;
                    txtCodContaAnalitica.Text = dadosContabilista.Codcontaanalitica;
                }
            }     
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}