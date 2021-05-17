using System;

namespace Uri1160
{
    class Program
    {
        static void Main(string[] args)
        {
            int PA, PB, anos;
            double G1, G2;
            string[] s;

            int entrada = int.Parse(Console.ReadLine());
            for (int i = 1; i <= entrada; i++)
            {
                s = Console.ReadLine().Split(' ');
                PA = int.Parse(s[0]);
                PB = int.Parse(s[1]);
                G1 = double.Parse(s[2]);
                G2 = double.Parse(s[3]);

                for (anos = 0; PA <= PB; anos++)
                {
                    PA += (int)(PA * G1 / 100);
                    PB += (int)(PB * G2 / 100);
                    
                }
                if (anos > 100)
                {
                    Console.WriteLine("Mais de 1 seculo.");
                    continue;
                }
                else
                {
                    Console.WriteLine(anos + " anos.");
                }
            }       

        }
    }
}







