
using System.IO;
using System;

    public struct person{
        public string  Name{ get; set;}
        public person(string _name){
            Name = _name;
        }
    }
     public struct dog{
        public string  Breed{get; set;}
        public dog(string _breed){
            Breed = _breed;
        }
    }


class Hello {
    public static void ShowValue(object o){
        if(o is person p ){
            Console.WriteLine(p.Name);
        }
        else if (o is dog d)
        {
           Console.WriteLine(d.Breed);  
        }
    }
    
  static void Main() {
    object o = new person("vk");
    ShowValue(o);
    o = new dog("abc");
    ShowValue(o);
    
  }
}
