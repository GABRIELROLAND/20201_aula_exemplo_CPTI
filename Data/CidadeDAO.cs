using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class CidadeDAO
    {
        #region "Métodos de Acesso ao Banco de Dados"

        public Dictionary<Int32, Cidade> ListarTodos()
        {
            Dictionary<Int32, Cidade> mapaCidades = new Dictionary<Int32, Cidade>();
            try
            {
                String SQL = "SELECT * FROM cidade;";

                SqlCeDataReader data = BD.ExecutarSelect(SQL);

                while (data.Read())
                {
                    Cidade o = new Cidade();

                    o.ID = data.GetInt32(0);
                    o.Descricao = data.GetString(1);

                    mapaCidades.Add(o.ID, o);
                }

                data.Close();
                BD.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return mapaCidades;
        }

        public Cidade BuscarPorID(Int32 _cpf)
        {
            Cidade o = null;
            try
            {
                String SQL = "SELECT * FROM cidade;";

                SqlCeDataReader data = BD.ExecutarSelect(SQL);

                while (data.Read())
                {
                    o = new Cidade();

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

        public List<Cidade> ListarCidadesPorEstado(Int32 _estado_id)
        {
            List<Cidade> listaCidades = new List<Cidade>();
            try
            {
                String SQL = String.Format("SELECT * FROM cidade WHERE estado_id = {0};", _estado_id);

                SqlCeDataReader data = BD.ExecutarSelect(SQL);

                while (data.Read())
                {
                    Cidade o = new Cidade();

                    o.ID = data.GetInt32(0);
                    o.Descricao = data.GetString(1);

                    listaCidades.Add(o);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return listaCidades;
        }

        #endregion
    }
}
