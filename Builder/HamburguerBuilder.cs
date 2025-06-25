using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class HamburguerBuilder
    {

        private readonly Hamburguer _hamburguer;

        public HamburguerBuilder() => _hamburguer = new Hamburguer();

        public HamburguerBuilder SetTipoPao(string tipoPao)
        {
            _hamburguer.TipoPao = tipoPao;
            return this;
        }

        public HamburguerBuilder SetTipoCarne(string tipoCarne)
        {
            _hamburguer.TipoCarne = tipoCarne;
            return this;
        }

        public HamburguerBuilder TemBacon()
        {
            _hamburguer.TemBacon = true;
            return this;
        }

        public HamburguerBuilder TemBatataPalha()
        {
            _hamburguer.TemBatataPalha = true;
            return this;
        }

        public HamburguerBuilder TemQueijo()
        {
            _hamburguer.TemQueijo = true;
            return this;
        }

        public HamburguerBuilder TemSalada()
        {
            _hamburguer.TemSalada = true;
            return this;
        }

        public Hamburguer Build()
        {
            if (string.IsNullOrEmpty(_hamburguer.TipoPao))
                throw new InvalidOperationException("Tipo de pão não pode ser vazio.");
            if (string.IsNullOrEmpty(_hamburguer.TipoCarne))
                throw new InvalidOperationException("Tipo de carne não pode ser vazio.");
            return _hamburguer;
        }

    }
}
