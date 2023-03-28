using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ConcreteSubject : Subject
    {
        List <Observer> observers = new List<Observer> { };

        public void RegisterObserver(Observer observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(Observer observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObserver()
        {
            foreach (var observer in observers) observer.Update();
        }

        int state;
        public int State
        {
            get { return state; }
            set { state = value; this.NotifyObserver(); }
        }
    }
}
