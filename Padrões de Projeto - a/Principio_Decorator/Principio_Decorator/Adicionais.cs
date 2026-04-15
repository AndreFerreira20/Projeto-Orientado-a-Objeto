using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Principio_Decorator.Decorator;

namespace Principio_Decorator
{
    interface class Adicionais
    {
        public class Leite : AdicionalDecorator
        {
            public Leite(Bebida bebida) : base(bebida) { }           

            public override string GetNome()
            {
                return _bebida.GetNome() + " + Leite";
            }

            public override int GetValor()
            {
                return _bebida.GetValor() + 1;
            }
        }

        public class Chantilly : AdicionalDecorator
        {
            public Chantilly(Bebida bebida) : base(bebida) { }            

            public override string GetNome()
            {
                return _bebida.GetNome() + " + Chantilly";
            }

            public override int GetValor()
            {
                return _bebida.GetValor() + 2;
            }
        }

        public class Canela : AdicionalDecorator
        {
            public Canela(Bebida bebida) : base(bebida) { }            

            public override string GetNome()
            {
                return _bebida.GetNome() + " + Canela";
            }

            public override int GetValor()
            {
                return _bebida.GetValor() + 5; 
            }
        }

        public class CaldaChocolate : AdicionalDecorator
        {
            public CaldaChocolate(Bebida bebida) : base(bebida)
            {
            }

            public override string GetNome()
            {
                return _bebida.GetNome() + " + Calda de Chocolate";
            }

            public override int GetValor()
            {
                return _bebida.GetValor() + 1;
            }
        }
    }
}
