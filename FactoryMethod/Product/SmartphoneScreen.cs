using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Product
{
    public class SmartphoneScreen : Screen
    {
        public SmartphoneScreen() : base("Blue", "Welcome to the Smartphone Screen!")
        {
        }
    }
}
