using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principio_Fachada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HomeTheater home = new HomeTheater();


            home.AssistirFilme();
            home.OuvirMusica();
            home.Festa();
        }
    }
}
