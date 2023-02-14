using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var states = new Dictionary<string, string>();

            states.Add("Estonia", "EST");
            states.Add("Latvia", "LAT");
            states.Add("Finland", "FIN");
            states.Add("Sweden", "SWE");
        
            foreach (var state in states)
            {
                Console.WriteLine($"{state.Key} - {state.Value}");
            }
            Console.WriteLine("---------------");
            Console.WriteLine(states["Estonia"]);
            Console.Write(states["Latvia"]);
        }
    }
}
