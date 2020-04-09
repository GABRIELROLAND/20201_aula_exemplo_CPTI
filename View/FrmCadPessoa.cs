using Control;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class frmCadPessoa : Form
    {
        public frmCadPessoa()
        {
            InitializeComponent();
        }

        private void frmCadPessoa_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Pessoa p = CarregarPessoaDoForm();

                PessoaCtrl control = new PessoaCtrl();


                if (control.SalvarPessoaNoArquivo(p))
                {
                    MessageBox.Show("Cadastro efetuado com sucesso!!!");
                }
                else
                {
                    MessageBox.Show("Cadastro não efetuado!!!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message);
            }
        }

        //METODO PARA CARREGAR OS DADOS DO FOMULARIO E RETORNAR UM OBJETO DO TIPO PESSOA
        private Pessoa CarregarPessoaDoForm()
        {
            Pessoa p = new Pessoa();

            try
            {
                String cpf = mtbCPF.Text.Replace(".", "").Replace("-", "");
                p.Cpf = Convert.ToInt64(cpf);
                p.Nome = txbNome.Text;
                p.Nascimento = mtbNascimento.Text;
                p.Celular = mtbCel.Text;
                
                p.TipoEnd = ltbTipo.SelectedIndex;
                p.Lograd = txbLogradouro.Text;
                p.Estado = cmbEstado.SelectedIndex;
                p.Cidade = cmbCidade.SelectedIndex;

                if (rdbMasculino.Checked)
	            {
                    p.Sexo = "masculino";
	            }
                else
                {
                    p.Sexo = "feminino";
                }

                if (rdbCasado.Checked)
                {
                    p.EstadoCivil = "casado";
                }
                else
                {
                    p.EstadoCivil = "solteiro";
                }

                p.Filhos = ckbFilhos.Checked;
                p.Animais = ckbAnimais.Checked;

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message);
            }

            return p;
        }
    }
}
