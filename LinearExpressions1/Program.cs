
double a, b, c, d, x, y, z, r;

Console.WriteLine("Введіть число A");
a = double.Parse(Console.ReadLine());


Console.WriteLine("Введіть число B");
b = double.Parse(Console.ReadLine());

Console.WriteLine("Введіть число C");
c = double.Parse(Console.ReadLine());

Console.WriteLine("Введіть число D");
d = double.Parse(Console.ReadLine());

x = (a + 2 * b - c + d) / (c * d) + (a + b) / (c - d) - Math.Pow(a, 2) / Math.Pow(b, 2);
Console.WriteLine("Результат обчислення виразу x = " + x);

y = (5 * (a + b) * (c - d)) / (0.5 * c) + Math.Pow(d, 2) * ((Math.Pow(a, 2) - Math.Pow(b, 2)) / (b - a));
Console.WriteLine("Результат обчислення виразу y = " + y);

z = ((Math.Pow(Math.Pow(x, 2) - 2 * x, 3) - 4 * (Math.Pow(x, 4) + 1) * (1 - b)) / (5 * a + 3 * b));
Console.WriteLine("Результат обчислення виразу z = " + z);

r = (0.5 * a + 0.75 * b - 7 / 5) / (3 * c + 1) + 1 / (a - c);
Console.WriteLine("Результат обчислення виразу r = " + r);