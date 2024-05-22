using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.Observer
{
    public interface IObserver
    {
        void Update(string message);
    }

    public interface ISubject
    {
        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void Notify();
    }

    public class ConcreteSubject : ISubject
    {
        private List<IObserver> observers = new List<IObserver>();
        private string state;

        public string State
        {
            get { return state; }
            set
            {
                state = value;
                Notify();
            }
        }

        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in observers)
            {
                observer.Update(state);
            }
        }
    }

    public class ConcreteObserver : IObserver
    {
        private string name;

        public ConcreteObserver(string name)
        {
            this.name = name;
        }

        public void Update(string message)
        {
            Console.WriteLine($"{name} received update: {message}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Sử dụng
            var subject = new ConcreteSubject();
            var observer1 = new ConcreteObserver("Observer 1");
            var observer2 = new ConcreteObserver("Observer 2");

            subject.Attach(observer1);
            subject.Attach(observer2);

            subject.State = "State has changed!";
            Console.ReadKey();
        }
    }
}
