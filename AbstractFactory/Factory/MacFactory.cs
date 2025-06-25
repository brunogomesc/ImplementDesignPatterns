using AbstractFactory.Factory.Interface;
using AbstractFactory.Product;
using AbstractFactory.Product.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factory
{
    public class MacFactory : IGUIFactory
    {

        public IButton CreateButton()
        {
            return new MacButton();
        }

        public ICheckbox CreateCheckbox()
        {
            return new MacCheckbox(); 
        }

    }
}
