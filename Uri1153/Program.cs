﻿using System;

namespace Uri1153
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n = int.Parse(Console.ReadLine());
            int fatorial = 1;

            for (int i = n; i >= 1; i--)
            {
                fatorial = fatorial * i;
            }

            Console.WriteLine(fatorial);
        }
    }
}
