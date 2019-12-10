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
            bool retry = true;

            // Sort in descending order
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
            Array.Reverse(values);

            Console.Write("\nYour numbers in descending order are: ");
            for (int x = 0; x < values.Length - 1; x++)
            {
                Console.Write(values[x] + ", ");
            }
            Console.Write(values[7] + ".\n");
            Console.Write("\nPress any key to exit..");
            Console.ReadKey();
        }
    }
}
