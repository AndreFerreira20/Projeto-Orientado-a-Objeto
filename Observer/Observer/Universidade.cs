using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class Universidade : Observer
    {
        private string nome;

        public void update (Subject s, string tipo)
        {
            decimal val;
            switch (tipo)
            {
                case "temp":
                    val = ((PCD)s).GetTemp();
                    Console.WriteLine("Temperatura: " + val);
                    break;
                case "ph":
                    val = ((PCD)s).GetPh();
                    Console.WriteLine("PH: " + val);
                    break;
                case "umidade":
                    val = ((PCD)s).GetUmidade();
                    Console.WriteLine("Umidade: " + val);
                    break;
            }
            
        }
    }
}
