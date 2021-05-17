using System;
using System.Collections.Generic;
using System.Linq;

namespace Uri1140
{
    class Program
    {
        static void Main()
        {
            string entrada = Console.ReadLine();
            
            while (entrada != "*")
            {
                var letters = new List<string>();
                string[] words = entrada.Split(' ');

                foreach (var word in words)
                {

                    letters.Add(word[0].ToString().ToUpper());
                }
                
                if (letters.All(x => x == letters.First()))
                {
                    Console.WriteLine("Y");
                }
                else
                {
                    Console.WriteLine("N");
                }

                entrada = Console.ReadLine().Trim();
            }
        }
    }
}

