using System.IO;
using System;

class Program
{
    static void Main()
    {
         int x=0 ;
        Console.WriteLine("Enter a string");
       
       string s= "Vasanth";
       //string s = sample.ToLower;
      
       for(int i=0 ;i<s.Length; i++)
       {
           if(s[i]=='a'||s[i]=='e'||s[i]=='i'||s[i]=='o'||s[i]=='u')
           {
             x++;
            }
       }
       
       Console.WriteLine(x);
       
    }
}