namespace View
{
    partial class frmListaPessoas
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
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.colCpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txbPesquisa = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToAddRows = false;
            this.dgvDados.AllowUserToDeleteRows = false;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCpf,
            this.colNome,
            this.colCel});
            this.dgvDados.Location = new System.Drawing.Point(12, 61);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.ReadOnly = true;
            this.dgvDados.RowHeadersVisible = false;
            this.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDados.Size = new System.Drawing.Size(393, 277);
            this.dgvDados.TabIndex = 0;
            this.dgvDados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellDoubleClick);
            // 
            // colCpf
            // 
            this.colCpf.HeaderText = "CPF";
            this.colCpf.Name = "colCpf";
            this.colCpf.ReadOnly = true;
            // 
            // colNome
            // 
            this.colNome.HeaderText = "Nome";
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;
            this.colNome.Width = 180;
            // 
            // colCel
            // 
            this.colCel.HeaderText = "Cel";
            this.colCel.Name = "colCel";
            this.colCel.ReadOnly = true;
            this.colCel.Width = 110;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pesquisa:";
            // 
            // txbPesquisa
            // 
            this.txbPesquisa.Location = new System.Drawing.Point(73, 22);
            this.txbPesquisa.Name = "txbPesquisa";
            this.txbPesquisa.Size = new System.Drawing.Size(332, 20);
            this.txbPesquisa.TabIndex = 2;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(330, 361);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmListaPessoas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 424);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.txbPesquisa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmListaPessoas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listagem de Pessoas";
            this.Load += new System.EventHandler(this.frmListaPessoas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbPesquisa;
        private System.Windows.Forms.Button btnSair;
    }
}