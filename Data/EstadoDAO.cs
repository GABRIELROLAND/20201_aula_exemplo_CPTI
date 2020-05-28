using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class EstadoDAO
    {
        public Dictionary<Int32, Estado> ListarTodos()
        {
            Dictionary<Int32, Estado> mapaEstados = new Dictionary<Int32, Estado>();
            try
            {
                String SQL = "SELECT * FROM estado;";

                SqlCeDataReader data = BD.ExecutarSelect(SQL);

                while (data.Read())
                {
                    Estado estado = new Estado();

                    estado.ID = data.GetInt32(0);
                    estado.Descricao = data.GetString(1);

                    CidadeDAO daoCidade = new CidadeDAO();

                    estado.Cidades = daoCidade.ListarCidadesPorEstado(estado.ID);

                    mapaEstados.Add(estado.ID, estado);
                }

                data.Close();
                BD.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return mapaEstados;
        }

        public Estado BuscarPorID(Int32 _cpf)
        {
            Estado o = null;
            try
            {
                String SQL = "SELECT * FROM estado;";

                SqlCeDataReader data = BD.ExecutarSelect(SQL);

                while (data.Read())
                {
                    o = new Estado();

                    o.ID = data.GetInt32(0);
                    o.Descricao = data.GetString(1);
                }

                data.Close();
                BD.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return o;
        }
    }
}
