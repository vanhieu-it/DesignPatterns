using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.Iterator
{
    public interface IIterator<T>
    {
        T Current { get; }
        bool MoveNext();
        void Reset();
    }

    public interface IEnumerable<T>
    {
        IIterator<T> CreateIterator();
    }

    public class ConcreteIterator<T> : IIterator<T>
    {
        private readonly T[] _collection;
        private int _position = -1;

        public ConcreteIterator(T[] collection)
        {
            _collection = collection;
        }

        public T Current
        {
            get
            {
                if (_position < 0 || _position >= _collection.Length)
                {
                    throw new InvalidOperationException();
                }
                return _collection[_position];
            }
        }

        public bool MoveNext()
        {
            if (_position < _collection.Length - 1)
            {
                _position++;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            _position = -1;
        }
    }

    public class ConcreteCollection<T> : IEnumerable<T>
    {
        private readonly T[] _items;

        public ConcreteCollection(T[] items)
        {
            _items = items;
        }

        public IIterator<T> CreateIterator()
        {
            return new ConcreteIterator<T>(_items);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var items = new int[] { 1, 6 ,2, 3, 4, 5 };
            var collection = new ConcreteCollection<int>(items);
            var iterator = collection.CreateIterator();

            while (iterator.MoveNext())
            {
                Console.WriteLine(iterator.Current);
            }
            Console.ReadKey();
        }
    }

}
