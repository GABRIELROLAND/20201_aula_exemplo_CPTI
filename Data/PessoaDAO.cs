using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class PessoaDAO
    {
        #region "Métodos de  acesso ao arquivo"

        public bool SalvarPessoaNoArquivo(Pessoa _o)
        {
            String dir = AppDomain.CurrentDomain.BaseDirectory;
            String path = dir + "bd.txt";

            String caminhoArquivo = @"C:\Users\Thiago\Documents\Visual Studio 2012\Projects\20201_aula_exemplo_CPTI-master\bd.txt";
            
            bool resultado = false;
            try
            {
                StreamWriter escritor = new StreamWriter(caminhoArquivo, true);

                escritor.Write(_o.Cpf + ";");
                escritor.Write(_o.Nome + ";");
                escritor.Write(_o.Nascimento + ";");
                escritor.Write(_o.Celular + ";");
                escritor.Write(_o.TipoEnd + ";");
                escritor.Write(_o.Lograd + ";");
                escritor.Write(_o.Estado + ";");
                escritor.Write(_o.Cidade + ";");
                escritor.Write(_o.Sexo + ";");
                escritor.Write(_o.EstadoCivil + ";");
                escritor.Write(_o.Filhos + ";");
                escritor.Write(_o.Animais + ";");

                escritor.WriteLine();

                escritor.Close();

                resultado = true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return resultado;
        }

        public Dictionary<Int64, Pessoa> ListarPessoasNoArquivo()
        {
            String caminhoArquivo = @"D:\Thiago\Documents\Visual Studio 2012\Projects\20201_aula_exemplo_CPTI\bd.txt";

            Dictionary<Int64, Pessoa> tabelaPessoas = new Dictionary<Int64, Pessoa>();

            try
            {
                char[] divisorLinhas = {'\n'};
                char[] divisorColunas = { ';' };

                StreamReader leitor = new StreamReader(caminhoArquivo);

                String arquivo = leitor.ReadToEnd();

                string[] linhas = arquivo.Split(divisorLinhas);

                for (int i = 0; i < linhas.Length - 1; i++)
                {
                    Pessoa p = new Pessoa();

                    string[] colunas = linhas[i].Split(divisorColunas);

                    p.Cpf = Convert.ToInt64(colunas[0]);
                    p.Nome = colunas[1];
                    p.Nascimento = colunas[2];
                    p.Celular = colunas[3];
                    p.TipoEnd = Convert.ToInt32(colunas[4]);
                    p.Lograd = colunas[5];
                    p.Estado = Convert.ToInt32(colunas[6]);
                    p.Cidade = Convert.ToInt32(colunas[7]);
                    p.Sexo = colunas[8];
                    p.EstadoCivil = colunas[9];
                    p.Filhos = Convert.ToBoolean(colunas[10]);
                    p.Animais = Convert.ToBoolean(colunas[11]);

                    tabelaPessoas.Add(p.Cpf, p);
                }

                return tabelaPessoas;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #endregion

        #region "Métodos de Acesso ao Banco de Dados"

        public Dictionary<Int64, Pessoa> ListarTodos()
        {
            Dictionary<Int64, Pessoa> mapaPessoas = new Dictionary<Int64, Pessoa>();
            try
            {
                String SQL = "SELECT * FROM pessoa;";

                SqlCeDataReader data = BD.ExecutarSelect(SQL);

                while (data.Read())
                {
                    Pessoa p = new Pessoa();

                    p.Cpf = data.GetInt64(0);
                    p.Nome = data.GetString(1);
                    p.Nascimento = data.GetString(2);
                    p.Celular = data.GetString(3);
                    p.TipoEnd = data.GetInt32(4);
                    p.Lograd = data.GetString(5);
                    p.Estado = data.GetInt32(6);
                    p.Cidade = data.GetInt32(7);
                    p.Sexo = data.GetString(8);
                    p.EstadoCivil = data.GetString(9);
                    p.Filhos = data.GetBoolean(10);
                    p.Animais = data.GetBoolean(11);

                    mapaPessoas.Add(p.Cpf, p);
                }

                data.Close();
                BD.FecharConexao();
                /*
                foreach (Pessoa p in listaPessoas)
                {
                    EnderecoDAO dao = new EnderecoDAO();

                    p.Enderecos = dao.BuscarEnderecosPorPessoa(p.Id);
                }
                 * */

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return mapaPessoas;
        }

        public Pessoa BuscarPorID(Int64 _cpf)
        {
            Pessoa p = null;
            try
            {
                String SQL = String.Format("SELECT * FROM pessoa WHERE id = {0} ", _cpf);

                SqlCeDataReader data = BD.ExecutarSelect(SQL);

                if (data.Read())
                {
                    p.Cpf = data.GetInt64(0);
                    p.Nome = data.GetString(1);
                    p.Nascimento = data.GetString(2);
                    p.Celular = data.GetString(3);
                    p.TipoEnd = data.GetInt32(4);
                    p.Lograd = data.GetString(5);
                    p.Estado = data.GetInt32(6);
                    p.Cidade = data.GetInt32(7);
                    p.Sexo = data.GetString(8);
                    p.EstadoCivil = data.GetString(9);
                    p.Filhos = data.GetBoolean(10);
                    p.Animais = data.GetBoolean(11);
                }

                data.Close();
                BD.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return p;
        }

        public Boolean InserirNoBD(Pessoa _obj)
        {
            bool resultado = false;
            try
            {
                String SQL = String.Format("INSERT INTO pessoa (cpf, nome, nascimento, cel, tipo_end, endereco, estado, cidade, sexo, est_civil, filhos, animais) "
                    + "VALUES ({0}, '{1}', '{2}', '{3}', {4}, '{5}', {6}, {7}, '{8}', '{9}', '{10}', '{11}')",
                    _obj.Cpf,
                    _obj.Nome,
                    _obj.Nascimento,
                    _obj.Celular,
                    _obj.TipoEnd,
                    _obj.Lograd,
                    _obj.Estado,
                    _obj.Cidade,
                    _obj.Sexo,
                    _obj.EstadoCivil,
                    _obj.Animais,
                    _obj.Filhos);

                int linhaAfetadas = BD.ExecutarIDU(SQL);

                if (linhaAfetadas > 0)
                {
                    resultado = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return resultado;
        }

        public Boolean AlterarNoBD(Pessoa _obj)
        {
            bool resultado = false;
            try
            {
                String SQL = String.Format("UPDATE pessoa SET "
                + "nome = '{0}', nascimento = '{1}', cel = '{2}', tipo_end = {3}, "
                + "endereco = '{4}', estado = {5}, cidade = {6}, sexo = '{7}', "
                + "est_civil = '{8}', filhos = '{9}', animais = '{10}' WHERE cpf = {11};",
                    _obj.Nome,
                    _obj.Nascimento,
                    _obj.Celular,
                    _obj.TipoEnd,
                    _obj.Lograd,
                    _obj.Estado,
                    _obj.Cidade,
                    _obj.Sexo,
                    _obj.EstadoCivil,
                    _obj.Filhos,
                    _obj.Animais,
                    _obj.Cpf);

                int linhaAfetadas = BD.ExecutarIDU(SQL);

                if (linhaAfetadas > 0)
                {
                    resultado = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return resultado;
        }

        public Boolean DeletarNoBD(Int64 _cpf)
        {
            bool resultado = false;
            try
            {
                String SQL = String.Format("DELETE FROM pessoa WHERE cpf = {0};", _cpf);

                int linhaAfetadas = BD.ExecutarIDU(SQL);

                if (linhaAfetadas > 0)
                {
                    resultado = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return resultado;
        }

        #endregion
    }
}
