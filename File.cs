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
            
            string line;

            StreamWriter writer = new StreamWriter("D:\\new_file.txt");
            writer.WriteLine("Hello,world!");
            writer.WriteLine("One more time!");
            writer.Close();
            
            StreamReader reader = new StreamReader("D:\\new_file.txt");
            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
            Console.ReadLine();
            reader.Close();
        }
        
    }
}
