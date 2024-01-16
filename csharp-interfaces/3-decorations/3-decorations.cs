using System;
using System.Collections.Generic;
using System.Reflection;

abstract class Base
{
    public string name { get; set; }

    public override string ToString()
    {
        return $"{name} is a {GetType().Name}";
    }
}

interface IInteractive
{
    void Interact();
}

interface IBreakable
{
    int durability { get; set; }

    void Break();
}

interface ICollectable
{
    bool isCollected { get; set; }

    void Collect();
}

class Door : Base, IInteractive
{
    public Door(string newName = "Door")
    {
        name = newName;
    }
    public void Interact()
    {
        Console.WriteLine($"You try to open the {name}. It's locked."); 
    }
}

class Decoration : Base, IInteractive, IBreakable
{
    public bool isQuestItem { get; set; }

    public int durability { get; set; }

    public Decoration(string newNameDec = "Decoration", int setDurability = 1, bool setQuestItem = false)
    {
        name = newNameDec;
        durability = setDurability;
        isQuestItem = setQuestItem;

        if (durability <= 0)
        {
            throw new ArgumentException("Durability must be greater than 0");
        }
    }
    public void Interact()
    {
        if (durability <= 0)
        {
            Console.WriteLine($"The {name} has been broken.");
        }
        else if (isQuestItem == true)
        {
            Console.WriteLine($"You look at the {name}. There's a key inside.");
        }
        else if (isQuestItem == false)
        {
            Console.WriteLine($"You look at the {name}. Not much to see here.");
        }
    }
    public void Break()
    {
        durability--;

        if (durability > 0)
        {
            Console.WriteLine($"You hit the {name}. It cracks.");
        }
        else if (durability == 0)
        {
            Console.WriteLine($"You smash the {name}. What a mess.");
        }
        else if (durability < 0)
        {
            Console.WriteLine($"The {name} is already broken.");
        }
    }
}