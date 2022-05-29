using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace observer_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteSubject subject = new ConcreteSubject() { State = 0 };

            ConcreteObserver observer1 = new ConcreteObserver();
            ConcreteObserver observer2 = new ConcreteObserver();

            subject.RegisterObserver(observer1);
            subject.State = 100;

            Console.WriteLine("Наблюдатель Боб: " + observer1.Counter);
            Console.WriteLine("Наблюдатель Тед: " + observer2.Counter);

            subject.RegisterObserver(observer2);
            subject.State = 200;

            Console.WriteLine("Наблюдатель Боб: " + observer1.Counter);
            Console.WriteLine("Наблюдатель Тед: " + observer2.Counter);

            subject.RemoveObserver(observer2);
            subject.State = 300;

            Console.WriteLine("Наблюдатель Боб: " + observer1.Counter);
            Console.WriteLine("Наблюдатель Тед: " + observer2.Counter);

            Console.ReadKey();
        }
    }
}
