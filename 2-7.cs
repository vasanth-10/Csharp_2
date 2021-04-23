
using System.IO;
using System;
class HelloWorld {
  static void Main() {
    int a;
    int.TryParse(Console.ReadLine(), out a);
    if (a==0)
    {
       Console.WriteLine("It is a numbr"); 
    }
    else{
         Console.WriteLine("It is not a numbr"); 
    }
    
  }
}
