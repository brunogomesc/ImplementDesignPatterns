using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Arma
    {

        private string Nome { get; set; }

        public Arma(string nome)
        {
            Nome = nome;
        }

        public string GetNomeArma()
        {
            return Nome;
        }

    }
}
