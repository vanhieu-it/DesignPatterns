using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.ChainOfResponsibility
{
    abstract class Handler
    {
        protected Handler successor;

        public void SetSuccessor(Handler successor)
        {
            this.successor = successor;
        }

        public abstract void HandleRequest(int request);
    }

    class ConcreteHandler1 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request < 10)
            {
                Console.WriteLine($"{this.GetType().Name} handled request {request}");
            }
            else if (successor != null)
            {
                successor.HandleRequest(request);
            }
        }
    }

    class ConcreteHandler2 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request >= 10 && request < 20)
            {
                Console.WriteLine($"{this.GetType().Name} handled request {request}");
            }
            else if (successor != null)
            {
                successor.HandleRequest(request);
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var handler1 = new ConcreteHandler1();
            var handler2 = new ConcreteHandler2();

            handler1.SetSuccessor(handler2);

            int[] requests = { 5, 24, 19 };

            foreach (int request in requests)
            {
                handler1.HandleRequest(request);
            }
            Console.ReadKey();
        }

    }
}
