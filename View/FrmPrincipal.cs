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
            pessoa = new Pessoa();
            pessoa.Id = 1;
            pessoa.Nome = "Thiago";

            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            String texto = String.Format("Id: {0} / Nome: {1}", pessoa.Id, pessoa.Nome);

            MostrarAlgoNaTela(texto);
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            timer.Enabled = true;
        }

        private void MostrarAlgoNaTela(String _texto)
        {
            MessageBox.Show(_texto);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            itemStatusHora.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
