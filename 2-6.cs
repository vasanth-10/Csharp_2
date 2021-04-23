
using System.IO;
using System;

class Program
{
    void Swap(ref int a , ref int b)
    {
       int c;
       
       
       c= a;
       a=b;
       b=c;
        Console.WriteLine("The value of After swap ");
       Console.WriteLine("The value of a "+a);
        Console.WriteLine("The value of b "+b);
        
    }
    static void Main()
    {
        Program Program = new Program();
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        Program.Swap(ref a,ref b);
         Console.WriteLine("The value of Before swap ");

        
        Console.WriteLine("The value of a "+a);
        Console.WriteLine("The value of b "+b);
        
    }
}