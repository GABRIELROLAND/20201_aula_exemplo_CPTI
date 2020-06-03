using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Control
{
    public class CidadeCtrl
    {
        public Object BD(char _c, Object _param)
        {
            try
            {
                CidadeDAO dao = new CidadeDAO();
                switch (_c)
                {
                    case 'i':
                    //return dao.InserirNoBD((Pessoa)_param);
                    case 'd':
                    //return dao.DeletarNoBD((Int64)_param);
                    case 'u':
                    //return dao.AlterarNoBD((Pessoa)_param);
                    case 't':
                        return dao.ListarTodos();
                    case 'o':
                        return dao.BuscarPorID((Int32)_param);
                    case 'f':
                        return dao.ListarCidadesPorEstado((Int32)_param);
                }

                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
