using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principio_Fachada
{
    internal class Projetor
    {
        private int status = 0;
        private int foco = 0;

        public Projetor() { }

        public void Energia()
        {
            if (status == 0)
            {
                status = 1;
                return;
            }

            status = 0;
            foco = 0;
            return;
        }

        public int GetEnergia() { return status; }

        public void Focar() { foco = 1; }

    }
}
