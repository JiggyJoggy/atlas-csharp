using System;

class Program
{
    static void Main(string[] args)
    {
        TestObject test = new TestObject();

        Console.WriteLine(test.ToString());
    }
}

class TestObject : Base
{
    // Empty class
}