using System;

namespace StackQueueUsingLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            StackUsingLinkedList linkedListStack = new StackUsingLinkedList();
            linkedListStack.Push(70);
            linkedListStack.Push(30);
            linkedListStack.Push(56);
            linkedListStack.Display();
            Console.WriteLine();
            linkedListStack.Peek(); 
            linkedListStack.Pop();
            linkedListStack.IsEmpty();
            linkedListStack.Display();


        }
    }
}
