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
            Console.WriteLine("Введите длину массива ");
            int i, j, size;
            size = int.Parse(Console.ReadLine());
            int[] mas = new int[size];
            Console.WriteLine("Введите" + size); 
            Console.WriteLine("эллементов(а) массива");

            for (i = 0; i < size; i++)
            {
                mas[i] = int.Parse(Console.ReadLine());
            }
            for (i = 0; i < size - 1; i++)
            {
                for (j = i + 1; j < size; j++)
                {
                    if (mas[i] > mas[j])
                    {
                        int temp = mas[i];
                        mas[i] = mas[j];
                        mas[j] = temp;
                    }
                }
            }

            foreach (int X in mas)
            {
                Console.WriteLine(" " + X);
            }
            Console.ReadLine();
        }
        
    }
}
