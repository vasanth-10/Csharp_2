using System.IO;
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string");
       
       string sample= Console.ReadLine();
        char []rsample= new char[sample.Length];
       for(int i=sample.Length-1;i>=0 ; i--)
       {
           rsample[i]=sample[i];
       }
       string rsample2 = new string (rsample);
       if(rsample2==sample){
           Console.WriteLine("It is palindrome");
       }
       else{
            Console.WriteLine("It is not a palindrome");
       }
       
    }
}