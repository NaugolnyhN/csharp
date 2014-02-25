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
            List<string> cities = new List<string>();
            cities.Add("New York");
            cities.Add("Mumbai");
            cities.Add("Berlin");
            cities.Add("Istanbul");
            
            var dict = new Dictionary<string, bool>();
            dict.Add("Sevastopol", true);
            dict.Add("Yalta", false);
            List<string> keys = new List<string>(dict.Keys);

            cities.Insert(2, keys[0]);
            cities.Insert(2, keys[1]);

            foreach (string city in cities) 
            {
                Console.WriteLine(city);
            }
            Console.ReadLine();
        }
        
    }
}
