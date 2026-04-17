using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class Subject
    {
        List<Observer> observers = new List<Observer>();

        public Subject() { }

        public void AddObserver(Observer observer) {  observers.Add(observer); }
        public void RemoveObserver(Observer observer) { observers.Remove(observer); }

        public void NotifyObservers(string dado)
        {
            foreach (Observer universidade in observers)
            {
                universidade.update(this, dado);
            }
        }
    }
}
