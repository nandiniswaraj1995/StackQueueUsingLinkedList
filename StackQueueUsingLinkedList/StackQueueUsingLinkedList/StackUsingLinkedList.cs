using System;
using System.Collections.Generic;
using System.Text;

namespace StackQueueUsingLinkedList
{
    class StackUsingLinkedList
    {
        private Node top;
        public StackUsingLinkedList()
        {
            this.top = null;
        }

        //30
        internal void Push(int value)
        {
            Node node = new Node(value);
            if (this.top == null)
                node.next = null;
            else
                node.next = this.top;//1300
            this.top = node;
            Console.WriteLine("{0} pushed to stack ", value);
        }
        public void Display()
        {
            Node temp = this.top;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;//1400
            }
        }
    }
}

      