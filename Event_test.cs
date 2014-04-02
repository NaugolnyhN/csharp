using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
namespace event_tutorial
{
    class Program
    {
        public class Family
        {
            public string name;
            public int age = 0;
            public int Age
            {
                get { return age; }
                set { age = value; }
            }

            public string Name
            {
                get { return name; }
                set { name = value; }
            }
        }
        
        static void Main(string[] args)
        {
            Family father = new Family();
            father.Age = 40;
            father.Name = "John";
            Family mother = new Family();
            mother.Age = 36;
            mother.Name = "JAnna";
            ChangedList l = new ChangedList();
            EventListener listener = new EventListener(l);
            l.Add(father);
            l.Add(mother);
            

        }
        public delegate void EventHandler(ArrayList sender, EventArgs e);
        
        public class ChangedList : ArrayList
        {
            public event EventHandler Event;
           public virtual void OnChanged(EventArgs e)
            {
                if (Event != null)
                    Event(this, e);
            }
            public override int Add(object value)
            {
                int i = base.Add(value);
                OnChanged(EventArgs.Empty);
                return i;
            }
        }
       
        public class EventListener
        {
            private ChangedList List;

            public EventListener(ChangedList list)
            {
                List = list;
                List.Event +=new EventHandler(ListChanged);
            }
           
             ///////////////////////////////////////////////////
 
            private void ListChanged(ArrayList sender, EventArgs e)
            {
               // foreach (Family f in sender)                  ���� ����� �������, �� �� ������� ������ ��� ������ � ���� ����������� � ������ ���������.
               // {
               //     Console.WriteLine(f.name);
               //     Console.WriteLine(f.age);
               // }

                
              //  Console.WriteLine(sender[0].);              ��� ����� ����� ����������� ����� � ������� ���� � ����� �����. ����� ���������� ��� ����������� �������� � ������.
                
                Console.ReadLine();
            }
        }



    }
}