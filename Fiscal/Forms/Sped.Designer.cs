namespace Fiscal.Forms
{
    partial class Sped
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sped));
            this.tabDados = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBoxRegistros = new System.Windows.Forms.GroupBox();
            this.checkBox1Bloco0 = new System.Windows.Forms.CheckBox();
            this.groupBoxLeiaute = new System.Windows.Forms.GroupBox();
            this.txtLeiaute = new System.Windows.Forms.TextBox();
            this.groupAtividadeContribuinte = new System.Windows.Forms.GroupBox();
            this.radioButtonAtividadeIndustria = new System.Windows.Forms.RadioButton();
            this.radioButtonAtividadeOutros = new System.Windows.Forms.RadioButton();
            this.groupBoxPerfil = new System.Windows.Forms.GroupBox();
            this.radioPerfilC = new System.Windows.Forms.RadioButton();
            this.radioPerfilB = new System.Windows.Forms.RadioButton();
            this.radioPerfilA = new System.Windows.Forms.RadioButton();
            this.groupBoxFinalidade = new System.Windows.Forms.GroupBox();
            this.radioFinalidadeSubst = new System.Windows.Forms.RadioButton();
            this.radioFinalidadeOrig = new System.Windows.Forms.RadioButton();
            this.groupBoxPeriodo = new System.Windows.Forms.GroupBox();
            this.lblAte = new System.Windows.Forms.Label();
            this.lclDe = new System.Windows.Forms.Label();
            this.dateTimePickerDataFinal = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDataInicio = new System.Windows.Forms.DateTimePicker();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.tabDados.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBoxRegistros.SuspendLayout();
            this.groupBoxLeiaute.SuspendLayout();
            this.groupAtividadeContribuinte.SuspendLayout();
            this.groupBoxPerfil.SuspendLayout();
            this.groupBoxFinalidade.SuspendLayout();
            this.groupBoxPeriodo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabDados
            // 
            this.tabDados.Controls.Add(this.tabPage1);
            this.tabDados.Location = new System.Drawing.Point(12, 12);
            this.tabDados.Name = "tabDados";
            this.tabDados.SelectedIndex = 0;
            this.tabDados.Size = new System.Drawing.Size(607, 294);
            this.tabDados.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.groupBoxRegistros);
            this.tabPage1.Controls.Add(this.groupBoxLeiaute);
            this.tabPage1.Controls.Add(this.groupAtividadeContribuinte);
            this.tabPage1.Controls.Add(this.groupBoxPerfil);
            this.tabPage1.Controls.Add(this.groupBoxFinalidade);
            this.tabPage1.Controls.Add(this.groupBoxPeriodo);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(599, 268);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dados";
            // 
            // groupBoxRegistros
            // 
            this.groupBoxRegistros.Controls.Add(this.checkBox1Bloco0);
            this.groupBoxRegistros.Location = new System.Drawing.Point(16, 169);
            this.groupBoxRegistros.Name = "groupBoxRegistros";
            this.groupBoxRegistros.Size = new System.Drawing.Size(570, 74);
            this.groupBoxRegistros.TabIndex = 5;
            this.groupBoxRegistros.TabStop = false;
            this.groupBoxRegistros.Text = "Registros a serem gerados";
            // 
            // checkBox1Bloco0
            // 
            this.checkBox1Bloco0.AutoSize = true;
            this.checkBox1Bloco0.BackColor = System.Drawing.Color.White;
            this.checkBox1Bloco0.Checked = true;
            this.checkBox1Bloco0.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1Bloco0.Enabled = false;
            this.checkBox1Bloco0.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBox1Bloco0.Location = new System.Drawing.Point(6, 19);
            this.checkBox1Bloco0.Name = "checkBox1Bloco0";
            this.checkBox1Bloco0.Size = new System.Drawing.Size(182, 17);
            this.checkBox1Bloco0.TabIndex = 0;
            this.checkBox1Bloco0.Text = "Bloco 0 - Registros apresentados";
            this.checkBox1Bloco0.UseVisualStyleBackColor = false;
            // 
            // groupBoxLeiaute
            // 
            this.groupBoxLeiaute.Controls.Add(this.txtLeiaute);
            this.groupBoxLeiaute.Location = new System.Drawing.Point(309, 96);
            this.groupBoxLeiaute.Name = "groupBoxLeiaute";
            this.groupBoxLeiaute.Size = new System.Drawing.Size(129, 67);
            this.groupBoxLeiaute.TabIndex = 4;
            this.groupBoxLeiaute.TabStop = false;
            this.groupBoxLeiaute.Text = "Leiaute do arquivo";
            // 
            // txtLeiaute
            // 
            this.txtLeiaute.Location = new System.Drawing.Point(6, 21);
            this.txtLeiaute.Name = "txtLeiaute";
            this.txtLeiaute.Size = new System.Drawing.Size(117, 20);
            this.txtLeiaute.TabIndex = 5;
            this.txtLeiaute.Text = "018";
            // 
            // groupAtividadeContribuinte
            // 
            this.groupAtividadeContribuinte.Controls.Add(this.radioButtonAtividadeIndustria);
            this.groupAtividadeContribuinte.Controls.Add(this.radioButtonAtividadeOutros);
            this.groupAtividadeContribuinte.Location = new System.Drawing.Point(16, 96);
            this.groupAtividadeContribuinte.Name = "groupAtividadeContribuinte";
            this.groupAtividadeContribuinte.Size = new System.Drawing.Size(277, 67);
            this.groupAtividadeContribuinte.TabIndex = 3;
            this.groupAtividadeContribuinte.TabStop = false;
            this.groupAtividadeContribuinte.Text = "Atividade do contribuinte";
            // 
            // radioButtonAtividadeIndustria
            // 
            this.radioButtonAtividadeIndustria.AutoSize = true;
            this.radioButtonAtividadeIndustria.Location = new System.Drawing.Point(6, 44);
            this.radioButtonAtividadeIndustria.Name = "radioButtonAtividadeIndustria";
            this.radioButtonAtividadeIndustria.Size = new System.Drawing.Size(187, 17);
            this.radioButtonAtividadeIndustria.TabIndex = 1;
            this.radioButtonAtividadeIndustria.Text = "Indústria ou equiparado a indústria";
            this.radioButtonAtividadeIndustria.UseVisualStyleBackColor = true;
            // 
            // radioButtonAtividadeOutros
            // 
            this.radioButtonAtividadeOutros.AutoSize = true;
            this.radioButtonAtividadeOutros.Checked = true;
            this.radioButtonAtividadeOutros.Location = new System.Drawing.Point(6, 21);
            this.radioButtonAtividadeOutros.Name = "radioButtonAtividadeOutros";
            this.radioButtonAtividadeOutros.Size = new System.Drawing.Size(241, 17);
            this.radioButtonAtividadeOutros.TabIndex = 0;
            this.radioButtonAtividadeOutros.TabStop = true;
            this.radioButtonAtividadeOutros.Text = "Outros (Comércio, prestador de serviço, etc...)";
            this.radioButtonAtividadeOutros.UseVisualStyleBackColor = true;
            // 
            // groupBoxPerfil
            // 
            this.groupBoxPerfil.Controls.Add(this.radioPerfilC);
            this.groupBoxPerfil.Controls.Add(this.radioPerfilB);
            this.groupBoxPerfil.Controls.Add(this.radioPerfilA);
            this.groupBoxPerfil.Location = new System.Drawing.Point(309, 53);
            this.groupBoxPerfil.Name = "groupBoxPerfil";
            this.groupBoxPerfil.Size = new System.Drawing.Size(277, 37);
            this.groupBoxPerfil.TabIndex = 2;
            this.groupBoxPerfil.TabStop = false;
            this.groupBoxPerfil.Text = "Perfil de geração";
            // 
            // radioPerfilC
            // 
            this.radioPerfilC.AutoSize = true;
            this.radioPerfilC.Location = new System.Drawing.Point(209, 14);
            this.radioPerfilC.Name = "radioPerfilC";
            this.radioPerfilC.Size = new System.Drawing.Size(58, 17);
            this.radioPerfilC.TabIndex = 2;
            this.radioPerfilC.Text = "Perfil C";
            this.radioPerfilC.UseVisualStyleBackColor = true;
            // 
            // radioPerfilB
            // 
            this.radioPerfilB.AutoSize = true;
            this.radioPerfilB.Checked = true;
            this.radioPerfilB.Location = new System.Drawing.Point(107, 14);
            this.radioPerfilB.Name = "radioPerfilB";
            this.radioPerfilB.Size = new System.Drawing.Size(58, 17);
            this.radioPerfilB.TabIndex = 1;
            this.radioPerfilB.TabStop = true;
            this.radioPerfilB.Text = "Perfil B";
            this.radioPerfilB.UseVisualStyleBackColor = true;
            // 
            // radioPerfilA
            // 
            this.radioPerfilA.AutoSize = true;
            this.radioPerfilA.Location = new System.Drawing.Point(6, 14);
            this.radioPerfilA.Name = "radioPerfilA";
            this.radioPerfilA.Size = new System.Drawing.Size(58, 17);
            this.radioPerfilA.TabIndex = 0;
            this.radioPerfilA.Text = "Perfil A";
            this.radioPerfilA.UseVisualStyleBackColor = true;
            // 
            // groupBoxFinalidade
            // 
            this.groupBoxFinalidade.Controls.Add(this.radioFinalidadeSubst);
            this.groupBoxFinalidade.Controls.Add(this.radioFinalidadeOrig);
            this.groupBoxFinalidade.Location = new System.Drawing.Point(16, 53);
            this.groupBoxFinalidade.Name = "groupBoxFinalidade";
            this.groupBoxFinalidade.Size = new System.Drawing.Size(277, 37);
            this.groupBoxFinalidade.TabIndex = 1;
            this.groupBoxFinalidade.TabStop = false;
            this.groupBoxFinalidade.Text = "Finalidade do arquivo";
            // 
            // radioFinalidadeSubst
            // 
            this.radioFinalidadeSubst.AutoSize = true;
            this.radioFinalidadeSubst.Location = new System.Drawing.Point(162, 14);
            this.radioFinalidadeSubst.Name = "radioFinalidadeSubst";
            this.radioFinalidadeSubst.Size = new System.Drawing.Size(109, 17);
            this.radioFinalidadeSubst.TabIndex = 1;
            this.radioFinalidadeSubst.Text = "Arquivo substituto";
            this.radioFinalidadeSubst.UseVisualStyleBackColor = true;
            // 
            // radioFinalidadeOrig
            // 
            this.radioFinalidadeOrig.AutoSize = true;
            this.radioFinalidadeOrig.Checked = true;
            this.radioFinalidadeOrig.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioFinalidadeOrig.Location = new System.Drawing.Point(9, 14);
            this.radioFinalidadeOrig.Name = "radioFinalidadeOrig";
            this.radioFinalidadeOrig.Size = new System.Drawing.Size(97, 17);
            this.radioFinalidadeOrig.TabIndex = 0;
            this.radioFinalidadeOrig.TabStop = true;
            this.radioFinalidadeOrig.Text = "Arquivo original";
            this.radioFinalidadeOrig.UseVisualStyleBackColor = true;
            // 
            // groupBoxPeriodo
            // 
            this.groupBoxPeriodo.Controls.Add(this.lblAte);
            this.groupBoxPeriodo.Controls.Add(this.lclDe);
            this.groupBoxPeriodo.Controls.Add(this.dateTimePickerDataFinal);
            this.groupBoxPeriodo.Controls.Add(this.dateTimePickerDataInicio);
            this.groupBoxPeriodo.Location = new System.Drawing.Point(16, 6);
            this.groupBoxPeriodo.Name = "groupBoxPeriodo";
            this.groupBoxPeriodo.Size = new System.Drawing.Size(570, 41);
            this.groupBoxPeriodo.TabIndex = 0;
            this.groupBoxPeriodo.TabStop = false;
            this.groupBoxPeriodo.Text = "Período";
            // 
            // lblAte
            // 
            this.lblAte.AutoSize = true;
            this.lblAte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAte.Location = new System.Drawing.Point(279, 21);
            this.lblAte.Name = "lblAte";
            this.lblAte.Size = new System.Drawing.Size(25, 13);
            this.lblAte.TabIndex = 1;
            this.lblAte.Text = "até";
            // 
            // lclDe
            // 
            this.lclDe.AutoSize = true;
            this.lclDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lclDe.Location = new System.Drawing.Point(6, 21);
            this.lclDe.Name = "lclDe";
            this.lclDe.Size = new System.Drawing.Size(23, 13);
            this.lclDe.TabIndex = 1;
            this.lclDe.Text = "De";
            // 
            // dateTimePickerDataFinal
            // 
            this.dateTimePickerDataFinal.Location = new System.Drawing.Point(337, 15);
            this.dateTimePickerDataFinal.Name = "dateTimePickerDataFinal";
            this.dateTimePickerDataFinal.Size = new System.Drawing.Size(217, 20);
            this.dateTimePickerDataFinal.TabIndex = 1;
            // 
            // dateTimePickerDataInicio
            // 
            this.dateTimePickerDataInicio.Location = new System.Drawing.Point(35, 15);
            this.dateTimePickerDataInicio.Name = "dateTimePickerDataInicio";
            this.dateTimePickerDataInicio.Size = new System.Drawing.Size(217, 20);
            this.dateTimePickerDataInicio.TabIndex = 0;
            this.dateTimePickerDataInicio.ValueChanged += new System.EventHandler(this.DateTimePickerDataInicio_ValueChanged);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(51)))), ((int)(((byte)(255)))));
            this.btnConfirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.Image = global::Fiscal.Properties.Resources.confirmar;
            this.btnConfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmar.Location = new System.Drawing.Point(514, 319);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(105, 30);
            this.btnConfirmar.TabIndex = 3;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // Sped
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Fiscal.Properties.Resources.background2;
            this.ClientSize = new System.Drawing.Size(624, 361);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.tabDados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Sped";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filtro por período de datas";
            this.Load += new System.EventHandler(this.Sped_Load);
            this.tabDados.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBoxRegistros.ResumeLayout(false);
            this.groupBoxRegistros.PerformLayout();
            this.groupBoxLeiaute.ResumeLayout(false);
            this.groupBoxLeiaute.PerformLayout();
            this.groupAtividadeContribuinte.ResumeLayout(false);
            this.groupAtividadeContribuinte.PerformLayout();
            this.groupBoxPerfil.ResumeLayout(false);
            this.groupBoxPerfil.PerformLayout();
            this.groupBoxFinalidade.ResumeLayout(false);
            this.groupBoxFinalidade.PerformLayout();
            this.groupBoxPeriodo.ResumeLayout(false);
            this.groupBoxPeriodo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabDados;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.GroupBox groupBoxPeriodo;
        private System.Windows.Forms.Label lblAte;
        private System.Windows.Forms.Label lclDe;
        private System.Windows.Forms.GroupBox groupBoxPerfil;
        private System.Windows.Forms.GroupBox groupBoxFinalidade;
        private System.Windows.Forms.GroupBox groupAtividadeContribuinte;
        private System.Windows.Forms.GroupBox groupBoxLeiaute;
        private System.Windows.Forms.GroupBox groupBoxRegistros;
        private System.Windows.Forms.CheckBox checkBox1Bloco0;
        public System.Windows.Forms.TextBox txtLeiaute;
        public System.Windows.Forms.RadioButton radioFinalidadeSubst;
        public System.Windows.Forms.RadioButton radioFinalidadeOrig;
        public System.Windows.Forms.DateTimePicker dateTimePickerDataFinal;
        public System.Windows.Forms.DateTimePicker dateTimePickerDataInicio;
        public System.Windows.Forms.RadioButton radioPerfilC;
        public System.Windows.Forms.RadioButton radioPerfilB;
        public System.Windows.Forms.RadioButton radioPerfilA;
        public System.Windows.Forms.RadioButton radioButtonAtividadeIndustria;
        public System.Windows.Forms.RadioButton radioButtonAtividadeOutros;
    }
}