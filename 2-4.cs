using System.IO;
using System;

class Program
{
    void CheckOddEven(int a)
    {
        if(a%2==0){
            Console.WriteLine("Number is even");
        }
        else{
             Console.WriteLine("Number is Odd");
        }
        
    }
    static void Main()
    {
        Program Program = new Program();
        int b = Convert.ToInt32(Console.ReadLine());
        Program.CheckOddEven(b);
    }
}