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
            this.groupBoxStatus = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLCDPR = new System.Windows.Forms.Button();
            this.btnSpedContribuicoes = new System.Windows.Forms.Button();
            this.btnSpedFiscal = new System.Windows.Forms.Button();
            this.btnSintegra = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnContabilista = new System.Windows.Forms.Button();
            this.btnConfiguracoes = new System.Windows.Forms.Button();
            this.groupBoxSelecaoArquivo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.groupBoxStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSelecaoArquivo
            // 
            this.groupBoxSelecaoArquivo.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxSelecaoArquivo.Controls.Add(this.pictureBoxLogo);
            this.groupBoxSelecaoArquivo.Controls.Add(this.groupBoxStatus);
            this.groupBoxSelecaoArquivo.Controls.Add(this.btnLCDPR);
            this.groupBoxSelecaoArquivo.Controls.Add(this.btnSpedContribuicoes);
            this.groupBoxSelecaoArquivo.Controls.Add(this.btnSpedFiscal);
            this.groupBoxSelecaoArquivo.Controls.Add(this.btnSintegra);
            this.groupBoxSelecaoArquivo.Location = new System.Drawing.Point(12, 12);
            this.groupBoxSelecaoArquivo.Name = "groupBoxSelecaoArquivo";
            this.groupBoxSelecaoArquivo.Size = new System.Drawing.Size(630, 290);
            this.groupBoxSelecaoArquivo.TabIndex = 0;
            this.groupBoxSelecaoArquivo.TabStop = false;
            this.groupBoxSelecaoArquivo.Text = "Seleção do arquivo a ser gerado";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackgroundImage = global::Fiscal.Properties.Resources.logo_master_280x62px;
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxLogo.Location = new System.Drawing.Point(171, 206);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(288, 68);
            this.pictureBoxLogo.TabIndex = 8;
            this.pictureBoxLogo.TabStop = false;
            // 
            // groupBoxStatus
            // 
            this.groupBoxStatus.Controls.Add(this.label2);
            this.groupBoxStatus.Controls.Add(this.label1);
            this.groupBoxStatus.Controls.Add(this.panel2);
            this.groupBoxStatus.Controls.Add(this.panel1);
            this.groupBoxStatus.Location = new System.Drawing.Point(15, 127);
            this.groupBoxStatus.Name = "groupBoxStatus";
            this.groupBoxStatus.Size = new System.Drawing.Size(597, 73);
            this.groupBoxStatus.TabIndex = 7;
            this.groupBoxStatus.TabStop = false;
            this.groupBoxStatus.Text = "Status da geração";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(538, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "0,00%";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(290, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "...";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(151)))), ((int)(((byte)(179)))));
            this.panel2.Location = new System.Drawing.Point(64, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(468, 16);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(151)))), ((int)(((byte)(179)))));
            this.panel1.Location = new System.Drawing.Point(64, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(468, 16);
            this.panel1.TabIndex = 0;
            // 
            // btnLCDPR
            // 
            this.btnLCDPR.BackgroundImage = global::Fiscal.Properties.Resources.lcdpr;
            this.btnLCDPR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLCDPR.FlatAppearance.BorderSize = 0;
            this.btnLCDPR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLCDPR.Location = new System.Drawing.Point(513, 19);
            this.btnLCDPR.Name = "btnLCDPR";
            this.btnLCDPR.Size = new System.Drawing.Size(102, 102);
            this.btnLCDPR.TabIndex = 6;
            this.btnLCDPR.UseVisualStyleBackColor = true;
            this.btnLCDPR.MouseEnter += new System.EventHandler(this.btnLCDPR_MouseEnter);
            this.btnLCDPR.MouseLeave += new System.EventHandler(this.btnLCDPR_MouseLeave);
            // 
            // btnSpedContribuicoes
            // 
            this.btnSpedContribuicoes.BackgroundImage = global::Fiscal.Properties.Resources.sped_contribuições;
            this.btnSpedContribuicoes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSpedContribuicoes.FlatAppearance.BorderSize = 0;
            this.btnSpedContribuicoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpedContribuicoes.Location = new System.Drawing.Point(347, 19);
            this.btnSpedContribuicoes.Name = "btnSpedContribuicoes";
            this.btnSpedContribuicoes.Size = new System.Drawing.Size(102, 102);
            this.btnSpedContribuicoes.TabIndex = 5;
            this.btnSpedContribuicoes.UseVisualStyleBackColor = true;
            this.btnSpedContribuicoes.MouseEnter += new System.EventHandler(this.btnSpedContribuicoes_MouseEnter);
            this.btnSpedContribuicoes.MouseLeave += new System.EventHandler(this.btnSpedContribuicoes_MouseLeave);
            // 
            // btnSpedFiscal
            // 
            this.btnSpedFiscal.BackgroundImage = global::Fiscal.Properties.Resources.sped;
            this.btnSpedFiscal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSpedFiscal.FlatAppearance.BorderSize = 0;
            this.btnSpedFiscal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpedFiscal.Location = new System.Drawing.Point(181, 19);
            this.btnSpedFiscal.Name = "btnSpedFiscal";
            this.btnSpedFiscal.Size = new System.Drawing.Size(102, 102);
            this.btnSpedFiscal.TabIndex = 4;
            this.btnSpedFiscal.UseVisualStyleBackColor = true;
            this.btnSpedFiscal.Click += new System.EventHandler(this.btnSpedFiscal_Click);
            this.btnSpedFiscal.MouseEnter += new System.EventHandler(this.btnSpedFiscal_MouseEnter);
            this.btnSpedFiscal.MouseLeave += new System.EventHandler(this.btnSpedFiscal_MouseLeave);
            // 
            // btnSintegra
            // 
            this.btnSintegra.BackgroundImage = global::Fiscal.Properties.Resources.sintegra;
            this.btnSintegra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSintegra.FlatAppearance.BorderSize = 0;
            this.btnSintegra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSintegra.Location = new System.Drawing.Point(15, 19);
            this.btnSintegra.Name = "btnSintegra";
            this.btnSintegra.Size = new System.Drawing.Size(102, 102);
            this.btnSintegra.TabIndex = 3;
            this.btnSintegra.UseVisualStyleBackColor = true;
            this.btnSintegra.MouseEnter += new System.EventHandler(this.btnSintegra_MouseEnter);
            this.btnSintegra.MouseLeave += new System.EventHandler(this.btnSintegra_MouseLeave);
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
            this.btnSair.Location = new System.Drawing.Point(550, 308);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(92, 30);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sair - F10";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.btnContabilista.Location = new System.Drawing.Point(12, 308);
            this.btnContabilista.Name = "btnContabilista";
            this.btnContabilista.Size = new System.Drawing.Size(135, 30);
            this.btnContabilista.TabIndex = 0;
            this.btnContabilista.Text = "Contabilista - F12";
            this.btnContabilista.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnContabilista.UseVisualStyleBackColor = false;
            this.btnContabilista.Click += new System.EventHandler(this.btnContabilista_Click);
            // 
            // btnConfiguracoes
            // 
            this.btnConfiguracoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(51)))), ((int)(((byte)(255)))));
            this.btnConfiguracoes.FlatAppearance.BorderSize = 0;
            this.btnConfiguracoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfiguracoes.ForeColor = System.Drawing.Color.White;
            this.btnConfiguracoes.Image = global::Fiscal.Properties.Resources.engrenagem;
            this.btnConfiguracoes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfiguracoes.Location = new System.Drawing.Point(153, 308);
            this.btnConfiguracoes.Name = "btnConfiguracoes";
            this.btnConfiguracoes.Size = new System.Drawing.Size(135, 30);
            this.btnConfiguracoes.TabIndex = 2;
            this.btnConfiguracoes.Text = "Configurações - F11";
            this.btnConfiguracoes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfiguracoes.UseVisualStyleBackColor = false;
            // 
            // Fiscal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Fiscal.Properties.Resources.background2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(651, 356);
            this.Controls.Add(this.btnConfiguracoes);
            this.Controls.Add(this.btnContabilista);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.groupBoxSelecaoArquivo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Fiscal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fiscal SG Master | | SGBR SISTEMAS LTDA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxSelecaoArquivo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.groupBoxStatus.ResumeLayout(false);
            this.groupBoxStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSelecaoArquivo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnContabilista;
        private System.Windows.Forms.Button btnLCDPR;
        private System.Windows.Forms.Button btnSpedContribuicoes;
        private System.Windows.Forms.Button btnSpedFiscal;
        private System.Windows.Forms.Button btnSintegra;
        private System.Windows.Forms.Button btnConfiguracoes;
        private System.Windows.Forms.GroupBox groupBoxStatus;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

