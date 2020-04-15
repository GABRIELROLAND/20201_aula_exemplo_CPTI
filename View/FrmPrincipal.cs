using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace View
{
    public partial class frmPrincipal : Form
    {
        Pessoa pessoa;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            timer.Enabled = true;

            this.Hide();

            frmLogin form = new frmLogin();

            if (form.ShowDialog() == DialogResult.OK)
            {
                Usuario user = (Usuario)form.Tag;

                lblUserLogado.Text = user.Nome;

                this.Show();
            }
            else
            {
                this.Close();
            }
        }

        private void MostrarAlgoNaTela(String _texto)
        {
            MessageBox.Show(_texto);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            itemStatusHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void itemBarraCadastro_Click(object sender, EventArgs e)
        {
            frmCadPessoa form = new frmCadPessoa();

            form.ShowDialog();
        }

        private void itemBarraSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void itemMenuSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void itemMenuNovo_Click(object sender, EventArgs e)
        {
            frmCadPessoa form = new frmCadPessoa();

            form.ShowDialog();
        }

        private void itemBarraListagem_Click(object sender, EventArgs e)
        {
            frmListaPessoas form = new frmListaPessoas();

            form.ShowDialog();
        }
    }
}
