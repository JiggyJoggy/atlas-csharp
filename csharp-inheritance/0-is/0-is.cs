using System;
using System.Collections.Generic;

class Obj
{
    /// <summary>
    /// Checking to obj's type
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public static bool IsOfTypeInt(object obj)
    {
        return (obj is int);
    }
}