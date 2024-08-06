using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttackServer
{
    internal class Queue
    {
        private Node _head;
        private Node _tail;
        private int _count;

        public Queue()
        {
            this.setHead(null);
            this.setTail(null);
            this.setCount(0);
        }

        public void Enqueue(int value)
        {
            Node newNode = new Node(value);
            if (this.getTail() != null)
            {
                Node tail = this.getTail();
                tail.SetNext(newNode);
                this.setTail(newNode);
            }
            else
            {
                this.setHead(newNode);
                this.setTail(newNode);
            }
            this.setCount(this.getCount() + 1);
        }

        public Node Dequeue()
        {
            if (this.getHead() != null)
            {
                Node head = this.getHead();
                this.setHead(head.GetNext());
                if (this.getHead() == null)
                {
                    this.setTail(null);
                }
                this.setCount(this.getCount() - 1);
                return head;
            }
            return null;
        }

        public void setHead(Node head)
        {
            this._head = head;
        }

        public void setTail(Node node)
        {
            this._tail = null;
        }

        public void setCount(int count)
        {
            this._count = count;
        }

        public Node getHead()
        {
            return this._head;
        }

        public Node getTail()
        {
            return this._tail;
        }

        public int getCount()
        {
            return this._count;
        }
    }
}
