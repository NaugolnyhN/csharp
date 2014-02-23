using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exam
{
    class Program
    {
        static void Main(string[] args)
        {
            Boy boy = new Boy(); //new object
            boy.Name = "Ted";    // we use fields of the base class in the inherited class
            boy.Age = 6;
            Console.WriteLine("Hello,my name is {0}, I'm {1} years old.I,m {2}.", boy.Name, boy.Age, boy.Gender);
            Console.ReadLine();
        }

      
        class Human     // base class
        {
            public string Name = "";
            public int Age;            
        }
        class Boy : Human  // inherited class
        { 
            public string Gender = "Male";
        }
       
    }
}