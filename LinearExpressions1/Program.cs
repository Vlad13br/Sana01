using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sana01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, x, y, z, r;
            string str;

            Console.WriteLine("Введіть число A");
            str = Console.ReadLine();
            a = double.Parse(str);


            Console.WriteLine("Введіть число B");
            str = Console.ReadLine();
            b = double.Parse(str);

            Console.WriteLine("Введіть число C");
            str = Console.ReadLine();
            c = double.Parse(str);

            Console.WriteLine("Введіть число D");
            str = Console.ReadLine();
            d = double.Parse(str);
            x = (a + 2 * b - c + d) / c * d + (a + b) / (c - d) - (a * a) / (b * b);
            Console.WriteLine("Результат обчислення виразу x = " + x);

            y = (5 * (a + b) * (c - d)) / (0.5 * c) + d * d * ((a * a - b * b) / (b - a));
            Console.WriteLine("Результат обчислення виразу y = " + y);

            z = ((Math.Pow((x * x - 2 * x), 3) - 4 * (x * x * x * x + 1) * (1 - b)) / (5 * a + 3 * b));
            Console.WriteLine("Результат обчислення виразу z = " + z);

            r = ((0.5 * a + 0.75 * b - 7 / 5) / 3 * c + 1) + 1 / (a - c);
            Console.WriteLine("Результат обчислення виразу r = " + r);

        }
    }
}