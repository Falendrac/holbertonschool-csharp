using System;
using System.Collections.Generic;
using System.Reflection;

/// <summary>Class object</summary>
class Obj
{
    /// <summary>
    /// prints the names of the available properties and methods of an object
    /// </summary>
    /// <param name="myObj">The object we print the properties and methods</param>
    public static void Print(object myObj)
    {
        Type objInfo = myObj.GetType();

        String str = "";

        str += objInfo.Name + " Properties:";
        foreach (var info in objInfo.GetProperties())
        {
            str += "\n" + info.Name;
        }
        str += "\n" + objInfo.Name + " Methods:";
        foreach (var info in objInfo.GetMethods())
        {
            str += "\n" + info.Name;
        }

        Console.WriteLine(str);
    }
}
