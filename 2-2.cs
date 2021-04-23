using System.IO;
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("enter the number");
        var x=Console.ReadLine();
        Console.WriteLine(x);
        Console.WriteLine(x.GetType());
        Console.ReadLine();
    }
}