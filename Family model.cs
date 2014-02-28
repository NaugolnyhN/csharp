using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ConsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> family_list = new List<string>();
            
            Father father = new Father();
            Mother mother = new Mother();
            Daughter daughter = new Daughter();


            father.gender = "male";
            father.name = "Alex";
            father.Age = 40;
            family_list.Add(father.name);
            Console.WriteLine(family_list[0]);
            Console.WriteLine();
            father.Work();
            MyEvent evt1 = new MyEvent();
            evt1.UserEvent += father.FamilyInfoHandler;
            evt1.OnUserEvent();           
           
            mother.gender = "female";
            mother.name = "Anna";
            mother.Age = 36;
            family_list.Add(mother.name);
            Console.WriteLine(family_list[1]);
            Console.WriteLine();
            mother.Work();
            MyEvent evt2 = new MyEvent();
            evt2.UserEvent += mother.FamilyInfoHandler;
            evt2.OnUserEvent();

            
            daughter.gender = "female";
            daughter.name = "Alice";
            daughter.Age = 4;
            family_list.Add(daughter.name);
            Console.WriteLine(family_list[2]);
            Console.WriteLine();
            MyEvent evt3 = new MyEvent();
            evt3.UserEvent += daughter.FamilyInfoHandler;
            evt3.OnUserEvent();

          
            
        }

        public class Family
        {
           public  string gender = "";
           public string name = "";
           private int age;
           public int Age
           {
               get { return age; }
               set
               {
                   if (value < 0)
                   {
                       Console.WriteLine("It can't be!");
                       Console.ReadLine();
                   }
                   age = value;

               }
           }
            public void Walk()
           {
               Console.WriteLine("I can go for a walk!");
               Console.ReadLine();
           }
            [Obsolete("Update info")]
            public void FamilyInfoHandler()
            {
                Console.WriteLine("name: {0}\n age: {1}\n gender: {2}", name, age, gender);
                Console.ReadLine();
            }
          
        }

        public class Adult : Family,work
        {
            public virtual void Work()
            {
                Console.WriteLine("I am hardworking!");
                Console.ReadLine();
            }
        }

        public class Father : Adult
        {
            public override void Work()
            {
                Console.WriteLine("I am truckdriver!");

                
            }
            
        }
        public class Mother : Adult
        {
            public override void Work()
            {
                Console.WriteLine("I am nurse");

            }
      
        }
        public class Daughter : Family
        {

        }
    
        interface work
        {
            void Work();
        }

        delegate void FI();

        class MyEvent
        {
            public event FI UserEvent;
            public void OnUserEvent()
            {
                UserEvent();
            }
        }
    }
}
