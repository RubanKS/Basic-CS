int a;
string? a1;
int b;
string? b1;

Console.Write("Введите первое число:");
a1 = Console.ReadLine();
a = Convert.ToInt32(a1);
Console.Write("Введите второе число:");
b1 = Console.ReadLine();
b = Convert.ToInt32(b1);

if (a > b)
{
    Console.Write("Первое число больше = ");
    Console.WriteLine(a);
}
else
{
    Console.Write("Второе число больше = ");
    Console.WriteLine(b);
}