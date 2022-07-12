double a;
string? a1;
double y;

Console.Write("Введите число:");
a1 = Console.ReadLine();
a = Convert.ToDouble(a1);

y = Math.Sin(a);

Console.WriteLine(y);