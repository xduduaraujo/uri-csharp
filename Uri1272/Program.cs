using System;

namespace Uri1272
{
    class Program
    {
        static void Main(string[] args)
        {
            int entrada = int.Parse(Console.ReadLine());
            string msg;


            for (int i = 0; i < entrada; i++)
            {
                msg = Console.ReadLine().Trim();
                string[] msgSplit = msg.Split(' ');

                foreach (var word in msgSplit) {
                    if (!String.IsNullOrWhiteSpace(word))
                    {
                        char firstLetter = word[0];
                        Console.Write(firstLetter);
                    }
                   
                }
                Console.WriteLine();
            }
        }
    }
}

