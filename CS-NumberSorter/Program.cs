using System;
using System.Threading;

namespace CS_NumberSorter
{
    class Program
    {
        static void Main()
        {
            string[] id = { "a = ", "b = ", "c = ", "d = ", "e = ", "f = ", "g = ", "h = " };
            double[] values = new double[8];
            bool retry = true, descending = true;

            Console.Write("Sort numbers in ascending(a) order/ descending(d) order or exit(e): ");
            String choice = Console.ReadLine().ToLower();
            if (choice == "a" || choice == "d") { if (choice == "a") { descending = false; } }
            else if (choice == "e") { Environment.Exit(0); }
            else
            {
                Console.Clear();
                Console.WriteLine("Choose a valid option! (a/d/e)\n");
                Main();
            }
            Console.WriteLine();

            // Sorting operation
            while (retry)
            {
                try
                {
                    for (int i = 0; i < id.Length; i++)
                    {
                        Console.Write(id[i]);
                        values[i] = double.Parse(Console.ReadLine());
                    }
                    retry = false;
                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine("Only numbers are accepted! (positive and negative)\n");
                    Thread.Sleep(1000);
                    Console.Clear();
                }
            }

            Array.Sort(values);
            if (descending) { 
                Array.Reverse(values);
                Console.Write("\nYour numbers in descending order are: ");
            }
            else { Console.Write("\nYour numbers in ascending order are: "); }

            for (int x = 0; x < values.Length - 1; x++)
            {
                Console.Write(values[x] + "; ");
            }
            Console.Write(values[7] + ".\n");
            Console.Write("\nPress any key to exit..");
            Console.ReadKey();
        }
    }
}
