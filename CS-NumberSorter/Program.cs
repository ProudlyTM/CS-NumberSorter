using System;

namespace CS_NumberSorter
{
    class Program
    {
        static void Main()
        {
            double a, b, c, d, e, f, g, h, temp;
            a = b = c = d = e = f = g = h = 0;
            bool loop = true; bool retry = true;

            while (retry)
            {
                try
                {
                    Console.Write("a = "); a = double.Parse(Console.ReadLine());
                    Console.Write("b = "); b = double.Parse(Console.ReadLine());
                    Console.Write("c = "); c = double.Parse(Console.ReadLine());
                    Console.Write("d = "); d = double.Parse(Console.ReadLine());
                    Console.Write("e = "); e = double.Parse(Console.ReadLine());
                    Console.Write("f = "); f = double.Parse(Console.ReadLine());
                    Console.Write("g = "); g = double.Parse(Console.ReadLine());
                    Console.Write("h = "); h = double.Parse(Console.ReadLine());
                    retry = false;
                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine("Only numbers are accepted! (positive and negative)\n");
                }
            }

            while (loop)
            {
                if (a < b)
                {
                    temp = a;
                    a = b;
                    b = temp;
                }
                else if (b < c)
                {
                    temp = b;
                    b = c;
                    c = temp;
                }
                else if (c < d)
                {
                    temp = c;
                    c = d;
                    d = temp;
                }
                else if (d < e)
                {
                    temp = d;
                    d = e;
                    e = temp;
                }
                else if (e < f)
                {
                    temp = e;
                    e = f;
                    f = temp;
                }
                else if (f < g)
                {
                    temp = f;
                    f = g;
                    g = temp;
                }
                else if (g < h)
                {
                    temp = g;
                    g = h;
                    h = temp;
                }
                else
                {
                    loop = false;
                }
            }
            Console.Clear();
            Console.WriteLine($"Your numbers in descending order are: {a}, {b}, {c}, {d}, {e}, {f}, {g}, {h}");
        }
    }
}
