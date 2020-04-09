namespace View
{
    partial class frmPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.itemMenuArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.itemMenuNovo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.itemMenuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemMenuEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.barraTarefa = new System.Windows.Forms.ToolStrip();
            this.itemBarraCadastro = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.itemBarraSair = new System.Windows.Forms.ToolStripButton();
            this.barraStatus = new System.Windows.Forms.StatusStrip();
            this.itemStatusHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUserLogado = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuPrincipal.SuspendLayout();
            this.barraTarefa.SuspendLayout();
            this.barraStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemMenuArquivo,
            this.ItemMenuEditar});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(669, 24);
            this.menuPrincipal.TabIndex = 0;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // itemMenuArquivo
            // 
            this.itemMenuArquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemMenuNovo,
            this.toolStripMenuItem2,
            this.itemMenuSair});
            this.itemMenuArquivo.Name = "itemMenuArquivo";
            this.itemMenuArquivo.Size = new System.Drawing.Size(61, 20);
            this.itemMenuArquivo.Text = "&Arquivo";
            // 
            // itemMenuNovo
            // 
            this.itemMenuNovo.Name = "itemMenuNovo";
            this.itemMenuNovo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.itemMenuNovo.Size = new System.Drawing.Size(152, 22);
            this.itemMenuNovo.Text = "Novo+";
            this.itemMenuNovo.Click += new System.EventHandler(this.itemMenuNovo_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(149, 6);
            // 
            // itemMenuSair
            // 
            this.itemMenuSair.Name = "itemMenuSair";
            this.itemMenuSair.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.itemMenuSair.Size = new System.Drawing.Size(152, 22);
            this.itemMenuSair.Text = "Sair";
            this.itemMenuSair.Click += new System.EventHandler(this.itemMenuSair_Click);
            // 
            // ItemMenuEditar
            // 
            this.ItemMenuEditar.Name = "ItemMenuEditar";
            this.ItemMenuEditar.Size = new System.Drawing.Size(49, 20);
            this.ItemMenuEditar.Text = "&Editar";
            // 
            // barraTarefa
            // 
            this.barraTarefa.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.barraTarefa.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.barraTarefa.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemBarraCadastro,
            this.toolStripSeparator1,
            this.itemBarraSair});
            this.barraTarefa.Location = new System.Drawing.Point(0, 24);
            this.barraTarefa.Name = "barraTarefa";
            this.barraTarefa.Size = new System.Drawing.Size(669, 47);
            this.barraTarefa.TabIndex = 1;
            this.barraTarefa.Text = "toolStrip1";
            // 
            // itemBarraCadastro
            // 
            this.itemBarraCadastro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.itemBarraCadastro.Image = global::View.Properties.Resources.usuario;
            this.itemBarraCadastro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.itemBarraCadastro.Name = "itemBarraCadastro";
            this.itemBarraCadastro.Size = new System.Drawing.Size(44, 44);
            this.itemBarraCadastro.Text = "Cadastrar Usuario";
            this.itemBarraCadastro.Click += new System.EventHandler(this.itemBarraCadastro_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 47);
            // 
            // itemBarraSair
            // 
            this.itemBarraSair.Image = global::View.Properties.Resources.sair;
            this.itemBarraSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.itemBarraSair.Name = "itemBarraSair";
            this.itemBarraSair.Size = new System.Drawing.Size(70, 44);
            this.itemBarraSair.Text = "Sair";
            this.itemBarraSair.Click += new System.EventHandler(this.itemBarraSair_Click);
            // 
            // barraStatus
            // 
            this.barraStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemStatusHora,
            this.lblUserLogado});
            this.barraStatus.Location = new System.Drawing.Point(0, 379);
            this.barraStatus.Name = "barraStatus";
            this.barraStatus.Size = new System.Drawing.Size(669, 22);
            this.barraStatus.TabIndex = 2;
            this.barraStatus.Text = "statusStrip1";
            // 
            // itemStatusHora
            // 
            this.itemStatusHora.Name = "itemStatusHora";
            this.itemStatusHora.Size = new System.Drawing.Size(49, 17);
            this.itemStatusHora.Text = "00:00:00";
            // 
            // lblUserLogado
            // 
            this.lblUserLogado.Name = "lblUserLogado";
            this.lblUserLogado.Size = new System.Drawing.Size(16, 17);
            this.lblUserLogado.Text = "...";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::View.Properties.Resources.logo_lasalle;
            this.pictureBox1.Location = new System.Drawing.Point(0, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(669, 308);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(669, 401);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.barraStatus);
            this.Controls.Add(this.barraTarefa);
            this.Controls.Add(this.menuPrincipal);
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "frmPrincipal";
            this.Text = "Aplicação de Exemplo da Aula";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.barraTarefa.ResumeLayout(false);
            this.barraTarefa.PerformLayout();
            this.barraStatus.ResumeLayout(false);
            this.barraStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem itemMenuArquivo;
        private System.Windows.Forms.ToolStripMenuItem itemMenuNovo;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem itemMenuSair;
        private System.Windows.Forms.ToolStripMenuItem ItemMenuEditar;
        private System.Windows.Forms.ToolStrip barraTarefa;
        private System.Windows.Forms.ToolStripButton itemBarraCadastro;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton itemBarraSair;
        private System.Windows.Forms.StatusStrip barraStatus;
        private System.Windows.Forms.ToolStripStatusLabel itemStatusHora;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripStatusLabel lblUserLogado;

    }
}

