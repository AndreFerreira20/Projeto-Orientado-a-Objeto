using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principio_Fachada
{
    internal class Receiver
    {
        private int status = 0;
        private PlayerMidia midia;
        private SistemaSom som;

        public Receiver() { }

        public void Energia()
        {
            if (status == 0)
            {
                status = 1;
                return;
            }

            status = 0;            
            return;
        }
    }
}
