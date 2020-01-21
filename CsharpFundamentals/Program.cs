using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*using statement*/

namespace Classes
{
    public string Name; // field
    
    public void Introduce(tring to) // method
    {
        // {this are parameter that will be filled by some value}
        Console.WriteLine("Hi {0}, I am {1}", to, Name); // format string 
    }
    
    public Person Parse(string str)
    {
        var person = new Person();
        person.Name = str;
        
        return person;
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            //var person = new Person();
            //var p = person.Parse("John");
            
            var person = Person.Parse("John");
            person.Introduce("Mosh");
        }
    }
}
