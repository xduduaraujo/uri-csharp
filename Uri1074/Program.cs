using System;

namespace Uri1074
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = int.Parse(Console.ReadLine());
            

            for (int i = 0; i < x; i++)
            {
                int n = int.Parse(Console.ReadLine());

                if (n == 0)
                {
                    Console.WriteLine("NULL");
                }
                else if (n % 2 == 0)
                {
                    if (n > 0)
                    {
                        Console.WriteLine("EVEN POSITIVE");
                    }
                    else
                    {
                        Console.WriteLine("EVEN NEGATIVE");
                    }
                }
                else
                {
                    if (n > 0)
                    {
                        Console.WriteLine("ODD POSITIVE");
                    }
                    else
                    {
                        Console.WriteLine("ODD NEGATIVE");
                    }
                }
            }
        }

    }
}
