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
using Control;

namespace View
{
    public partial class frmListaPessoas : Form
    {
        private Dictionary<Int64, Pessoa> tabelaPessoas;

        public frmListaPessoas()
        {
            InitializeComponent();
        }

        private void frmListaPessoas_Load(object sender, EventArgs e)
        {
            //Carregar Objetos do Tipo Pessoa do Arquivo
            CarregarGridDoBD();
        }

        private void CarregarGridDoBD()
        {
            try
            {
                dgvDados.Rows.Clear();

                PessoaCtrl control = new PessoaCtrl();

                tabelaPessoas = (Dictionary<Int64, Pessoa>)control.BD('t', null);

                foreach (Pessoa item in tabelaPessoas.Values)
                {
                    dgvDados.Rows.Add(item.Cpf, item.Nome, item.Celular);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO CARREGAR BD: " + ex.Message);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Int64 cpf = Convert.ToInt64(dgvDados.SelectedRows[0].Cells[0].Value);

                Pessoa p = tabelaPessoas[cpf];

                frmCadPessoa form = new frmCadPessoa();

                form.Tag = p;

                form.ShowDialog();

                CarregarGridDoBD();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO SELECIONAR CADASTRO: " + ex.Message);
            }
            
        }

        private void iMenuDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                Int64 cpf = Convert.ToInt64(dgvDados.SelectedRows[0].Cells[0].Value);

                PessoaCtrl control = new PessoaCtrl();

                if ((bool)control.BD('d', cpf))
                {
                    MessageBox.Show("Cadastro deletado com sucesso!!");
                }

                CarregarGridDoBD();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO DELETAR CADASTRO: " + ex.Message);
            }
        }
    }
}
