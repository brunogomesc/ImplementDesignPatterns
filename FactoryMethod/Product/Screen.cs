using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Product
{
    public abstract class Screen
    {

        protected string BackgroundColor { get; }
        private readonly string MessageText;

        public Screen(string backgroundColor, string messageText)
        {
            BackgroundColor = backgroundColor;
            MessageText = messageText;
        }

        public string GetMessageText()
        {
            return MessageText;
        }

    }
}
