using FactoryMethod.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Creator
{
    public class ConcreteSmartTvScreenCreator : ScreenCreator
    {
        public override Screen CreateScreen()
        {
            return new SmartTvScreen();
        }
    }
}
