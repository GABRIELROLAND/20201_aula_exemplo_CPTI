using Model;
using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control
{
    public class PessoaCtrl
    {

        #region "Métodos de  acesso ao arquivo"

        public bool SalvarPessoaNoArquivo(Pessoa _o)
        {
            try
            {
                PessoaDAO dao = new PessoaDAO();

                return dao.SalvarPessoaNoArquivo(_o);
            }
            catch (Exception ex)
            {
                throw new Exception("ERRO AO SALVAR PESSOA: " + ex.Message);
            }
        }

        public Dictionary<Int64, Pessoa> ListarPessoasNoArquivo()
        {
            try
            {
                PessoaDAO dao = new PessoaDAO();

                Dictionary<Int64, Pessoa> tabelaPessoas = dao.ListarPessoasNoArquivo();

                return tabelaPessoas;

                //return dao.ListarPessoasNoArquivo();
            }
            catch (Exception ex)
            {
                throw new Exception("ERRO LISTAR PESSOAS: " + ex.Message);
            }
        }

        #endregion

        #region "Métodos de Acesso ao Banco de Dados"

        //ExecutarOperacaoBD escolhendo o tipo de comando e passando o parâmetro necessário para a operação
        public Object BD(char _c, Object _param)
        {
            try
            {
                PessoaDAO dao = new PessoaDAO();
                switch (_c)
                {
                    case 'i':
                        return dao.InserirNoBD((Pessoa)_param);
                    case 'd':
                        return dao.DeletarNoBD((Int64)_param);
                    case 'u':
                        return dao.AlterarNoBD((Pessoa)_param);
                    case 't':
                        return dao.ListarTodos();
                    case 'o':
                        return dao.BuscarPorID((Int64)_param);
                    //case 'f':
                        //return dao.BuscarListaFiltrada((String)_param);
                }

                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #endregion
    }
}
