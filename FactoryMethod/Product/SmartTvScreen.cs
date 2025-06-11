using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Product
{
    public class SmartTvScreen : Screen
    {
        public SmartTvScreen() : base("Yellow", "Welcome to the Smart TV Screen!")
        {
        }
    }
}
