using System;

namespace StackQueueUsingLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            StackUsingLinkedList linkedListStack = new StackUsingLinkedList();
            QueueUsingLinkedList linkedListQueue = new QueueUsingLinkedList();

            linkedListStack.Push(70);
            linkedListStack.Push(30);
            linkedListStack.Push(56);
            linkedListStack.Display();
            Console.WriteLine();
            linkedListStack.Peek(); 
            linkedListStack.Pop();
            linkedListStack.IsEmpty();
            linkedListStack.Display();

            linkedListQueue.Enqueue(56);
            linkedListQueue.Enqueue(30);
            linkedListQueue.Enqueue(70);
            linkedListQueue.Display();
            linkedListQueue.Dequeue();
            Console.WriteLine();
            linkedListQueue.Display();



        }
    }
}
