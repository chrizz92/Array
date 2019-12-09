using System;

namespace Array.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            string input;

            for(int i = 0;i<numbers.Length;i++)
            {
                Console.Write("{0}. Zahl eingeben: ",i+1);
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            do
            {
                Console.Write("Die wievielte Zahl wollen sie ausgeben(e für Ende)?");
                input = Console.ReadLine();

                switch (input)
                {
                    case "e":
                        break;
                    case "1":
                    case "2":
                    case "3":
                    case "4":
                    case "5":
                    case "6":
                    case "7":
                    case "8":
                    case "9":
                    case "10":
                        Console.WriteLine("Die Zahl lautet: {0}", numbers[Convert.ToInt32(input)-1]);
                        break;
                    default:
                        Console.WriteLine("Ungültiger Index!");
                        break;
                }           
            } while (input != "e");
        }
    }
}
