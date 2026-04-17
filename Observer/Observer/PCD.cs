using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class PCD : Subject
    {
        private decimal temp;
        private decimal ph;
        private decimal umidade;
        private string localiza;

        public PCD (string localiza) { this.localiza = localiza; }


        public decimal GetTemp() { return temp; }
        public decimal GetPh() { return ph; }
        public decimal GetUmidade() { return umidade; }
        public string GetLocaliza() { return localiza; }
        
       
        public void SetTipo(string tipo, decimal valor)
        {
            switch (tipo)
            {
                case "temp":
                    temp = valor;
                    NotifyObservers(tipo);
                    break;
                case "ph":
                    ph = valor;
                    NotifyObservers(tipo);
                    break;
                case "umidade":
                    umidade = valor;
                    NotifyObservers(tipo);
                    break;
            }
        }
    }
}
