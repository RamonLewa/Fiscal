namespace Fiscal
{
    partial class Fiscal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fiscal));
            this.groupBoxSelecaoArquivo = new System.Windows.Forms.GroupBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.btnSpedFiscal = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnContabilista = new System.Windows.Forms.Button();
            this.groupBoxSelecaoArquivo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxSelecaoArquivo
            // 
            this.groupBoxSelecaoArquivo.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxSelecaoArquivo.Controls.Add(this.pictureBoxLogo);
            this.groupBoxSelecaoArquivo.Controls.Add(this.btnSpedFiscal);
            this.groupBoxSelecaoArquivo.Location = new System.Drawing.Point(12, 12);
            this.groupBoxSelecaoArquivo.Name = "groupBoxSelecaoArquivo";
            this.groupBoxSelecaoArquivo.Size = new System.Drawing.Size(397, 236);
            this.groupBoxSelecaoArquivo.TabIndex = 0;
            this.groupBoxSelecaoArquivo.TabStop = false;
            this.groupBoxSelecaoArquivo.Text = "Seleção do arquivo a ser gerado";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackgroundImage = global::Fiscal.Properties.Resources.logo_master_280x62px;
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxLogo.Location = new System.Drawing.Point(54, 156);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(288, 68);
            this.pictureBoxLogo.TabIndex = 8;
            this.pictureBoxLogo.TabStop = false;
            // 
            // btnSpedFiscal
            // 
            this.btnSpedFiscal.BackgroundImage = global::Fiscal.Properties.Resources.sped;
            this.btnSpedFiscal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSpedFiscal.FlatAppearance.BorderSize = 0;
            this.btnSpedFiscal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpedFiscal.Location = new System.Drawing.Point(147, 31);
            this.btnSpedFiscal.Name = "btnSpedFiscal";
            this.btnSpedFiscal.Size = new System.Drawing.Size(102, 102);
            this.btnSpedFiscal.TabIndex = 4;
            this.btnSpedFiscal.UseVisualStyleBackColor = true;
            this.btnSpedFiscal.Click += new System.EventHandler(this.btnSpedFiscal_Click);
            this.btnSpedFiscal.MouseEnter += new System.EventHandler(this.btnSpedFiscal_MouseEnter);
            this.btnSpedFiscal.MouseLeave += new System.EventHandler(this.btnSpedFiscal_MouseLeave);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(51)))), ((int)(((byte)(255)))));
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Image = global::Fiscal.Properties.Resources.cancelar;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(317, 269);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(92, 30);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnContabilista
            // 
            this.btnContabilista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(51)))), ((int)(((byte)(255)))));
            this.btnContabilista.FlatAppearance.BorderSize = 0;
            this.btnContabilista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContabilista.ForeColor = System.Drawing.Color.White;
            this.btnContabilista.Image = global::Fiscal.Properties.Resources._13;
            this.btnContabilista.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContabilista.Location = new System.Drawing.Point(12, 269);
            this.btnContabilista.Name = "btnContabilista";
            this.btnContabilista.Size = new System.Drawing.Size(135, 30);
            this.btnContabilista.TabIndex = 0;
            this.btnContabilista.Text = "Contabilista";
            this.btnContabilista.UseVisualStyleBackColor = false;
            this.btnContabilista.Click += new System.EventHandler(this.btnContabilista_Click);
            // 
            // Fiscal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Fiscal.Properties.Resources.background2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(421, 309);
            this.Controls.Add(this.btnContabilista);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.groupBoxSelecaoArquivo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Fiscal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fiscal SG Master | | ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxSelecaoArquivo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSelecaoArquivo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnContabilista;
        private System.Windows.Forms.Button btnSpedFiscal;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}

