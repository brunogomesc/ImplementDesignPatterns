using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod.Product;

namespace FactoryMethod.Creator
{
    public class ConcreteSmartphoneScreenCreator : ScreenCreator
    {
        public override Screen CreateScreen()
        {
            return new SmartphoneScreen();
        }
    }

}
