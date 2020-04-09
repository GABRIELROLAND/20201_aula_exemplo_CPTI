namespace View
{
    partial class frmCadPessoa
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
            this.gpbDadosPrincipais = new System.Windows.Forms.GroupBox();
            this.mtbCel = new System.Windows.Forms.MaskedTextBox();
            this.mtbNascimento = new System.Windows.Forms.MaskedTextBox();
            this.mtbCPF = new System.Windows.Forms.MaskedTextBox();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gpbEndereco = new System.Windows.Forms.GroupBox();
            this.cmbCidade = new System.Windows.Forms.ComboBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.txbLogradouro = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ltbTipo = new System.Windows.Forms.ListBox();
            this.gpbDadosAdicionais = new System.Windows.Forms.GroupBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.rdbFeminino = new System.Windows.Forms.RadioButton();
            this.rdbCasado = new System.Windows.Forms.RadioButton();
            this.rdbSolteiro = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ckbFilhos = new System.Windows.Forms.CheckBox();
            this.ckbAnimais = new System.Windows.Forms.CheckBox();
            this.gpbDadosPrincipais.SuspendLayout();
            this.gpbEndereco.SuspendLayout();
            this.gpbDadosAdicionais.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbDadosPrincipais
            // 
            this.gpbDadosPrincipais.Controls.Add(this.mtbCel);
            this.gpbDadosPrincipais.Controls.Add(this.mtbNascimento);
            this.gpbDadosPrincipais.Controls.Add(this.mtbCPF);
            this.gpbDadosPrincipais.Controls.Add(this.txbNome);
            this.gpbDadosPrincipais.Controls.Add(this.label4);
            this.gpbDadosPrincipais.Controls.Add(this.label3);
            this.gpbDadosPrincipais.Controls.Add(this.label2);
            this.gpbDadosPrincipais.Controls.Add(this.label1);
            this.gpbDadosPrincipais.Location = new System.Drawing.Point(12, 12);
            this.gpbDadosPrincipais.Name = "gpbDadosPrincipais";
            this.gpbDadosPrincipais.Size = new System.Drawing.Size(462, 138);
            this.gpbDadosPrincipais.TabIndex = 0;
            this.gpbDadosPrincipais.TabStop = false;
            this.gpbDadosPrincipais.Text = "Dados Principais";
            // 
            // mtbCel
            // 
            this.mtbCel.Location = new System.Drawing.Point(307, 77);
            this.mtbCel.Mask = "(00) 90000-0000";
            this.mtbCel.Name = "mtbCel";
            this.mtbCel.Size = new System.Drawing.Size(143, 20);
            this.mtbCel.TabIndex = 7;
            // 
            // mtbNascimento
            // 
            this.mtbNascimento.Location = new System.Drawing.Point(87, 77);
            this.mtbNascimento.Mask = "00/00/0000";
            this.mtbNascimento.Name = "mtbNascimento";
            this.mtbNascimento.Size = new System.Drawing.Size(178, 20);
            this.mtbNascimento.TabIndex = 6;
            this.mtbNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // mtbCPF
            // 
            this.mtbCPF.Location = new System.Drawing.Point(307, 30);
            this.mtbCPF.Mask = "000,000,000-00";
            this.mtbCPF.Name = "mtbCPF";
            this.mtbCPF.Size = new System.Drawing.Size(143, 20);
            this.mtbCPF.TabIndex = 5;
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(87, 30);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(178, 20);
            this.txbNome.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(276, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cel:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nascimento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CPF:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // gpbEndereco
            // 
            this.gpbEndereco.Controls.Add(this.cmbCidade);
            this.gpbEndereco.Controls.Add(this.cmbEstado);
            this.gpbEndereco.Controls.Add(this.txbLogradouro);
            this.gpbEndereco.Controls.Add(this.label8);
            this.gpbEndereco.Controls.Add(this.label7);
            this.gpbEndereco.Controls.Add(this.label6);
            this.gpbEndereco.Controls.Add(this.label5);
            this.gpbEndereco.Controls.Add(this.ltbTipo);
            this.gpbEndereco.Location = new System.Drawing.Point(12, 165);
            this.gpbEndereco.Name = "gpbEndereco";
            this.gpbEndereco.Size = new System.Drawing.Size(462, 134);
            this.gpbEndereco.TabIndex = 1;
            this.gpbEndereco.TabStop = false;
            this.gpbEndereco.Text = "Endereço";
            // 
            // cmbCidade
            // 
            this.cmbCidade.FormattingEnabled = true;
            this.cmbCidade.Items.AddRange(new object[] {
            "Araruama",
            "Niterói",
            "Rio de Janeiro",
            "Belo Horizonte",
            "Ouro Preto",
            "São Paulo",
            "Taubaté"});
            this.cmbCidade.Location = new System.Drawing.Point(317, 93);
            this.cmbCidade.Name = "cmbCidade";
            this.cmbCidade.Size = new System.Drawing.Size(133, 21);
            this.cmbCidade.TabIndex = 7;
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "RJ",
            "MG",
            "SP"});
            this.cmbEstado.Location = new System.Drawing.Point(317, 45);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(133, 21);
            this.cmbEstado.TabIndex = 6;
            // 
            // txbLogradouro
            // 
            this.txbLogradouro.Location = new System.Drawing.Point(129, 45);
            this.txbLogradouro.Multiline = true;
            this.txbLogradouro.Name = "txbLogradouro";
            this.txbLogradouro.Size = new System.Drawing.Size(172, 69);
            this.txbLogradouro.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(327, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Cidade";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(327, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Estado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(182, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Logradouro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tipo";
            // 
            // ltbTipo
            // 
            this.ltbTipo.FormattingEnabled = true;
            this.ltbTipo.Items.AddRange(new object[] {
            "Rua",
            "Avenida",
            "Travessa",
            "Beco",
            "Estrada",
            "Praça"});
            this.ltbTipo.Location = new System.Drawing.Point(18, 45);
            this.ltbTipo.Name = "ltbTipo";
            this.ltbTipo.Size = new System.Drawing.Size(94, 69);
            this.ltbTipo.TabIndex = 0;
            // 
            // gpbDadosAdicionais
            // 
            this.gpbDadosAdicionais.Controls.Add(this.groupBox3);
            this.gpbDadosAdicionais.Controls.Add(this.groupBox2);
            this.gpbDadosAdicionais.Controls.Add(this.groupBox1);
            this.gpbDadosAdicionais.Location = new System.Drawing.Point(12, 319);
            this.gpbDadosAdicionais.Name = "gpbDadosAdicionais";
            this.gpbDadosAdicionais.Size = new System.Drawing.Size(462, 148);
            this.gpbDadosAdicionais.TabIndex = 2;
            this.gpbDadosAdicionais.TabStop = false;
            this.gpbDadosAdicionais.Text = "Dados Adicionais";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(30, 488);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(127, 488);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 4;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(387, 488);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Location = new System.Drawing.Point(29, 31);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(73, 17);
            this.rdbMasculino.TabIndex = 0;
            this.rdbMasculino.TabStop = true;
            this.rdbMasculino.Text = "Masculino";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // rdbFeminino
            // 
            this.rdbFeminino.AutoSize = true;
            this.rdbFeminino.Location = new System.Drawing.Point(29, 71);
            this.rdbFeminino.Name = "rdbFeminino";
            this.rdbFeminino.Size = new System.Drawing.Size(67, 17);
            this.rdbFeminino.TabIndex = 1;
            this.rdbFeminino.TabStop = true;
            this.rdbFeminino.Text = "Feminino";
            this.rdbFeminino.UseVisualStyleBackColor = true;
            // 
            // rdbCasado
            // 
            this.rdbCasado.AutoSize = true;
            this.rdbCasado.Location = new System.Drawing.Point(19, 31);
            this.rdbCasado.Name = "rdbCasado";
            this.rdbCasado.Size = new System.Drawing.Size(61, 17);
            this.rdbCasado.TabIndex = 2;
            this.rdbCasado.TabStop = true;
            this.rdbCasado.Text = "Casado";
            this.rdbCasado.UseVisualStyleBackColor = true;
            // 
            // rdbSolteiro
            // 
            this.rdbSolteiro.AutoSize = true;
            this.rdbSolteiro.Location = new System.Drawing.Point(19, 71);
            this.rdbSolteiro.Name = "rdbSolteiro";
            this.rdbSolteiro.Size = new System.Drawing.Size(60, 17);
            this.rdbSolteiro.TabIndex = 3;
            this.rdbSolteiro.TabStop = true;
            this.rdbSolteiro.Text = "Solteiro";
            this.rdbSolteiro.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbMasculino);
            this.groupBox1.Controls.Add(this.rdbFeminino);
            this.groupBox1.Location = new System.Drawing.Point(18, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(144, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbCasado);
            this.groupBox2.Controls.Add(this.rdbSolteiro);
            this.groupBox2.Location = new System.Drawing.Point(168, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(116, 100);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Estado Civil";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ckbAnimais);
            this.groupBox3.Controls.Add(this.ckbFilhos);
            this.groupBox3.Location = new System.Drawing.Point(290, 29);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(147, 100);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Info";
            // 
            // ckbFilhos
            // 
            this.ckbFilhos.AutoSize = true;
            this.ckbFilhos.Location = new System.Drawing.Point(17, 31);
            this.ckbFilhos.Name = "ckbFilhos";
            this.ckbFilhos.Size = new System.Drawing.Size(53, 17);
            this.ckbFilhos.TabIndex = 0;
            this.ckbFilhos.Text = "Filhos";
            this.ckbFilhos.UseVisualStyleBackColor = true;
            // 
            // ckbAnimais
            // 
            this.ckbAnimais.AutoSize = true;
            this.ckbAnimais.Location = new System.Drawing.Point(17, 71);
            this.ckbAnimais.Name = "ckbAnimais";
            this.ckbAnimais.Size = new System.Drawing.Size(62, 17);
            this.ckbAnimais.TabIndex = 1;
            this.ckbAnimais.Text = "Animais";
            this.ckbAnimais.UseVisualStyleBackColor = true;
            // 
            // frmCadPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 523);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.gpbDadosAdicionais);
            this.Controls.Add(this.gpbEndereco);
            this.Controls.Add(this.gpbDadosPrincipais);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCadPessoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Pessoas";
            this.Load += new System.EventHandler(this.frmCadPessoa_Load);
            this.gpbDadosPrincipais.ResumeLayout(false);
            this.gpbDadosPrincipais.PerformLayout();
            this.gpbEndereco.ResumeLayout(false);
            this.gpbEndereco.PerformLayout();
            this.gpbDadosAdicionais.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbDadosPrincipais;
        private System.Windows.Forms.GroupBox gpbEndereco;
        private System.Windows.Forms.GroupBox gpbDadosAdicionais;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.MaskedTextBox mtbCel;
        private System.Windows.Forms.MaskedTextBox mtbNascimento;
        private System.Windows.Forms.MaskedTextBox mtbCPF;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.ComboBox cmbCidade;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.TextBox txbLogradouro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox ltbTipo;
        private System.Windows.Forms.RadioButton rdbSolteiro;
        private System.Windows.Forms.RadioButton rdbCasado;
        private System.Windows.Forms.RadioButton rdbFeminino;
        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox ckbAnimais;
        private System.Windows.Forms.CheckBox ckbFilhos;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}