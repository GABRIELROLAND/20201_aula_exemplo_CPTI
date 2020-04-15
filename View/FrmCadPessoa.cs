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
            //Verificar se tem dados para carregar
            if (this.Tag != null)
            {
                btnAtualizar.Visible = true;

                mtbCPF.Enabled = false;

                Pessoa pessoa = (Pessoa)this.Tag;

                //Carregamento dos Dados do Objeto pessoa para o Form
                CarregarFormDePessoa(pessoa);
            }
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

        private void CarregarFormDePessoa(Pessoa _p)
        {
            try
            {
                mtbCPF.Text = _p.Cpf.ToString();
                txbNome.Text = _p.Nome;
                mtbNascimento.Text = _p.Nascimento;
                mtbCel.Text = _p.Celular;
                ltbTipo.SelectedIndex = _p.TipoEnd;
                txbLogradouro.Text = _p.Lograd;
                cmbEstado.SelectedIndex = _p.Estado;

                cmbCidade.SelectedIndex = _p.Cidade;
                if (_p.Sexo.Equals("masculino"))
                {
                    rdbMasculino.Checked = true;
                }
                else
                {
                    rdbFeminino.Checked = true;
                }

                if (_p.EstadoCivil.Equals("casado"))
                {
                    rdbCasado.Checked = true;
                }
                else
                {
                    rdbSolteiro.Checked = true;
                }

                ckbFilhos.Checked = _p.Filhos;
                ckbAnimais.Checked = _p.Animais;

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO CARREGAR FORMULARIO: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            //Método para alterar dados no BD
        }
    }
}
