using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PCD pcd = new PCD("Manaus");
            Universidade ufrgs = new Universidade();
            Universidade usp = new Universidade();

            
            pcd.AddObserver(ufrgs);
            pcd.AddObserver(usp);

            
            pcd.SetTipo("temp", 28.5m);
            pcd.SetTipo("ph", 6.8m);
            pcd.SetTipo("umidade", 85.0m);
        }
    }
}
