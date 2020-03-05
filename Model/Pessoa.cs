using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Pessoa
    {
        public Int32 Id { get; set; }

        private String nome;
        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }

    }
}
