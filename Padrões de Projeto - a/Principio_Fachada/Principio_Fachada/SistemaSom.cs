using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principio_Fachada
{
    internal class SistemaSom
    {
        private int status = 0;
        private int volume = 0;

        public SistemaSom() { }

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

        public int GetVolume() { return volume; }

        public void Volume(string mudanca)
        {
            if (mudanca == "+")
            {
                volume += 10;
                return;
            }

            if (mudanca == "-")
            {
                if (volume == 0)
                    return;

                volume -= 10;
            }
        }

        public void Musica(string music) { Console.WriteLine($"Tocando: {music}"); }
    }
}
