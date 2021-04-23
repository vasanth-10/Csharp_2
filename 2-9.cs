using System.IO;
using System;

class Program
{
    static void Main()
    {
        object str = "hello";
        char[] values = { 'h','e','l','l','o'};
        object str2 = new string(values);
        Console.WriteLine("Using equality operator"+(str==str2));
        
        Console.WriteLine("Using equals() method"+str.Equals(str2));
    }
}