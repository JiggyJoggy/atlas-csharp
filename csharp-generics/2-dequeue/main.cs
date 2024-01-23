using System;

class Program
{
    static void Main(string[] args)
    {
        Queue<string> myQ = new Queue<string>();

        myQ.Enqueue("972");
        myQ.Enqueue("Market");
        myQ.Enqueue("Street");
        myQ.Enqueue("San");
        myQ.Enqueue("Francisco");
        myQ.Enqueue("California");

        Console.WriteLine("Number of nodes in queue: " + myQ.Count());
        Console.WriteLine("Value of head node: " + myQ.Dequeue());
        
        Console.WriteLine("Number of nodes in queue: " + myQ.Count());
        Console.WriteLine("Value of head node: " + myQ.Dequeue());

        Console.WriteLine("Number of nodes in queue: " + myQ.Count());
        Console.WriteLine("Value of head node: " + myQ.Dequeue());
    }
}