using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.Strategy
{
    // Strategy Interface
    public interface IStrategy
    {
        void Algorithm();
    }

    // Concrete Strategy
    public class ConcreteStrategyA : IStrategy
    {
        public void Algorithm()
        {
            Console.WriteLine("Algorithm A");
        }
    }

    public class ConcreteStrategyB : IStrategy
    {
        public void Algorithm()
        {
            Console.WriteLine("Algorithm B");
        }
    }

    // Context
    public class Context
    {
        private IStrategy _strategy;

        public void SetStrategy(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public void ExecuteStrategy()
        {
            _strategy.Algorithm();
        }
    }

    // Client
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();

            context.SetStrategy(new ConcreteStrategyA());
            context.ExecuteStrategy();

            context.SetStrategy(new ConcreteStrategyB());
            context.ExecuteStrategy();
            Console.ReadKey();
        }
    }

}
