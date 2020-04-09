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
    }
}
