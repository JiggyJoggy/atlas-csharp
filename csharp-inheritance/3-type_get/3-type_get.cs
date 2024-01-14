using System;
using System.Collections.Generic;
using System.Reflection;

class Obj
{
    /// <summary>
    /// Method that prints out all 
    /// available properties and methods of an object
    /// </summary>
    /// <param name="myObj"></param>
    public static void Print(object myObj)
    {
        Type objType = myObj.GetType();

        Console.WriteLine($"{objType.Name} Properties:");
        PropertyInfo[] properties = objType.GetProperties();
        foreach (var prop in properties)
        {
            Console.WriteLine(prop.Name);
        }

        Console.WriteLine($"{objType.Name} Methods:");
        MethodInfo[] methods = objType.GetMethods();
        foreach (var method in methods)
        {
            Console.WriteLine(method.Name);
        }
    }
}