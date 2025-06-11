using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Product
{
    public class WebScreen : Screen
    {
        public WebScreen() : base("White", "Welcome to the Web Screen!")
        {
        }
    }
}
