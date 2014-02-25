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
                Teacher teacher = new Teacher();
                int money = 0;
                teacher.EarnMoney(money);
                GoodTeacher good_teacher = new GoodTeacher();
                good_teacher.EarnMoney(money);
                Console.ReadLine();

        }


// 2.Polymorphism example
        class Teacher
        {
            public virtual void EarnMoney(int money)
            {
                Console.WriteLine("Teacher earns " + money + " money");
            }
        }

        class GoodTeacher : Teacher
        {
            public override void EarnMoney(int money)
            {
                int bonus = 1;
                money += bonus;
                Console.WriteLine("Good teacher earns " + money + " money");
            }
        }     
    }
}