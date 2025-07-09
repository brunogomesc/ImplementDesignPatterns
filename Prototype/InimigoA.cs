using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class InimigoA : Inimigo, IInimigoPrototype
    {

        public Inimigo DeepCopy()
        {
            var result = (Inimigo)this.MemberwiseClone();
            result.Arma = new Arma("Faca");
            return result;
        }

        public Inimigo ShallowCopy()
        {
            return (Inimigo)this.MemberwiseClone();
        }

    }
}
