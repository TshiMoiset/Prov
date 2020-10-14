using System;

namespace Prov
{
    class Program
    {
        static void Main(string[] args)
        {


            string svar;

            Console.ForegroundColor
            = ConsoleColor.Yellow;
            Console.WriteLine("Hej! Dags att köra ett spel");
            Console.WriteLine("Sänk båten. Gissa på en siffra mellan (1 - 10)");
            Console.WriteLine();

            while (true)
            {
                svar = Console.ReadLine().ToLower();

                if (svar == "1" || svar == "2" || svar == "3" || svar == "4" || svar == "5")
                {
                    Console.WriteLine("Miss!");
                    Console.WriteLine();
                    continue;
                }

                if (svar == "0")
                {
                    Console.WriteLine("Välj en siffra mellan (1 - 10)");
                }

                else if (svar == "8")
                {
                    Console.WriteLine("Hit!");
                    Console.ReadLine();
                    break;
                }

                else if (svar == "6" || svar == "7" || svar == "9" || svar == "10")
                {
                    Console.WriteLine();
                    Console.WriteLine("Near miss!");
                    continue;
                }

                Console.WriteLine();
                Console.WriteLine("Det var ingen siffra");
                Console.WriteLine("Gissa på en siffra mellan (1 - 10)");
                continue;
            }
        }
    }
}
