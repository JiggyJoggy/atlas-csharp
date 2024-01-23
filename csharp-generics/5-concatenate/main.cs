using System;

class Program
{
    static void Main(string[] args)
    {
        Queue<int> myQ = new Queue<int>();

        myQ.Enqueue(8);
        myQ.Enqueue(6);
        myQ.Enqueue(7);
        myQ.Enqueue(5);
        myQ.Enqueue(3);

        Console.WriteLine(myQ.Concatenate());
    }
}