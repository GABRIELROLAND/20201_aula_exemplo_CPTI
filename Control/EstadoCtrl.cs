using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control
{
    public class EstadoCtrl
    {
        public Object BD(char _c, Object _param)
        {
            try
            {
                EstadoDAO dao = new EstadoDAO();
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
    }
}
