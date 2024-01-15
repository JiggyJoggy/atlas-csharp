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

class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    public void Interact()
    {

    }

    public int durability { get; set; }

    public void Break()
    {

    }

    public bool isCollected { get; set; }

    public void Collect()
    {
        
    }
}