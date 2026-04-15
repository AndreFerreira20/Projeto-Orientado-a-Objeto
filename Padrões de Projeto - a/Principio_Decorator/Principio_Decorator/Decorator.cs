using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principio_Decorator
{
    class Decorator
    {
        public abstract class AdicionalDecorator : Bebida
        {
            protected Bebida _bebida;

            public AdicionalDecorator(Bebida bebida)
            {
                _bebida = bebida;
            }

            public abstract string GetNome();
            public abstract int GetValor();
        }
    }
}
