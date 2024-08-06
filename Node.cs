using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttackServer
{
    internal class Node
    {
        private int? _value { get; set; }
        private Node _next { get; set; }

        public Node()
        {
            this.SetValue(null);
            this.SetNext(null);
        }

        public Node(int value)
        {
            this._value = value;
        }

        public Node(int value, Node next)
        {
            this._value = value;
            this._next = next;
        }

        public int? GetValue()
        {
            return this._value;
        }

        public Node GetNext()
        {
            return this._next;
        }

        public void SetValue(int? value)
        {
            this._value = value;
        }

        public void SetNext(Node next)
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
