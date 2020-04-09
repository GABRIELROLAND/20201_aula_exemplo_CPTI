using Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class PessoaDAO
    {
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
            String caminhoArquivo = @"C:\Users\Thiago\Documents\Visual Studio 2012\Projects\20201_aula_exemplo_CPTI-master\bd.txt";

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
    }
}
