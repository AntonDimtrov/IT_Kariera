using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateClasses
{
    class Box<T>
    {
        private Stack<T> elements= new Stack<T>();

        private int count;

        public int Count { get { return this.count; } }
        public void Add(T element)
        {
            elements.Push(element);
            Console.WriteLine();
        }
        public T Remove()
        {
            return elements.Pop();
        }
        public T GetLastElement()
        {
            return elements.Peek();
        }

        public override string ToString()
        {
            return $"{typeof(T)}";
        }

    }
}
