using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Pessoa
    {
        public Int64 Cpf { get; set; }

        private String nome;
        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public String Nascimento { get; set; }

        public String Celular { get; set; }

        public Int32 TipoEnd { get; set; }

        public String Lograd { get; set; }

        public Int32 Estado { get; set; }

        public Int32 Cidade { get; set; }

        public String Sexo { get; set; }

        public String EstadoCivil { get; set; }

        public Boolean Filhos { get; set; }

        public Boolean Animais { get; set; }

    }
}
