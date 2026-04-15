using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principio_Decorator
{
    public class CafeExpresso : Bebida
    {
        public string GetNome()
        {
            return "Café Expresso";
        }

        public int GetValor()
        {
            return 3;
        }
    }

    public class Cappuccino : Bebida
    {
        public string GetNome()
        {
            return "Cappuccino";
        }

        public int GetValor()
        {
            return 5;
        }
    }

    public class Cha : Bebida
    {
        public string GetNome()
        {
            return "Chá";
        }

        public int GetValor()
        {
            return 2;
        }
    }
}
