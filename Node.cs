using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttackServer
{
    internal class Node<T>
    {
        private T _value { get; set; }
        private Node<T> _next { get; set; }

        public Node(T value)
        {
            this._value = value;
        }

        public Node(T value, Node<T> next)
        {
            this._value = value;
            this._next = next;
        }

        public T GetValue()
        {
            return this._value;
        }

        public Node<T> GetNext()
        {
            return this._next;
        }

        public void SetValue(T value)
        {
            this._value = value;
        }

        public void SetNext(Node<T> next)
        {
            this._next = next;
        }

        public override string ToString()
        {
            string hasNext = this.GetNext() != null ? "has" : "not";
            return $"Node value is: {this._value}. {hasNext} Next.";
        }
    }
}
