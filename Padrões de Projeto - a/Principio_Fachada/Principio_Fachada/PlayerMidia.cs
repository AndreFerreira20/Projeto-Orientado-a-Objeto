using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principio_Fachada
{
    internal class PlayerMidia
    {
        private int status = 0;
        private TV tv;

        public PlayerMidia() { }

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

        public int GetEnergia() { return status; }
    }
}
