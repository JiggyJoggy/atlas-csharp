using System;

class Queue<T>
{
    public Node head;
    public Node tail;
    public int count;

    public void Enqueue(T value)
    {
        Node newNode = new Node(value);

        if (tail == null)
        {
            head = newNode;
            tail = newNode;
        }
        else
        {
            tail.next = newNode;
            tail = newNode;
        }
        count++;
    }

    public T Dequeue()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }

        T value = head.value;
        head = head.next;
        count--;

        if (head == null)
        {
            tail = null;
        }

        return value;
    }

    public T Peek()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        return head.value;
    }

    public void Print()
    {
        Node current = head;

        while (current != null)
        {
            Console.WriteLine(current.value);
            current = current.next;
        }

        if (head == null)
        {
            Console.WriteLine("Queue is empty");
        }
    }

    public string Concatenate()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return null;
        }

        if (typeof(T) != typeof(string) && typeof(T) != typeof(char))
        {
            Console.WriteLine("Concatenate is for a queue of Strings or Chars only.");
            return null;
        }

        string catValue = this.head.value.ToString();
        Node current = this.head.next;

        while (current != null)
        {
            if (typeof(T) == typeof(string))
            {
                catValue = catValue + " ";
            }
            catValue = catValue + current.value;
            current = current.next;
        }
        return catValue;
    }

    public int Count()
    {
        return count;
    }

    public Type CheckType()
    {
        return typeof(T);
    }

    public class Node
    {
        public T value { get; set; }
        public Node next { get; set; }

        public Node(T value)
        {
            this.value = value;
            this.next = null;
        }
    }
}