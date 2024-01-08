using System;
using System.Collections.Generic;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        // Number of items in aStack
        Console.WriteLine($"Number of items: {aStack.Count}");

        // Checking what item is at the top of aStack
        var firstItem = aStack.Peek();
        if (aStack.Count == 0)
        {
            Console.WriteLine("Stack is empty");
        }
        else
        {
            Console.WriteLine($"Top item: {firstItem}");
        }

        // Searching to see if it's in aStack
        if (aStack.Contains(search))
        {
            Console.WriteLine($"Stack contains \"{search}\": True");
            while (aStack.Contains(search))
            {
                aStack.Pop();
            }
        }
        else
        {
            Console.WriteLine($"Stack contains \"{search}\": False");
        }
        aStack.Push(newItem);
        return aStack;
    }
}