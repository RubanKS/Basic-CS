//С клавиатуры вводятся три числа. Найти максимальное из трех чисел

int a;
string? a1;
int b;
string? b1;
int c;
string? c1;

//a1 = Convert.ToInt32(a1);


Console.Write("Введите первое число:");
a1 = Console.ReadLine();
a = Convert.ToInt32(a1);

Console.Write("Введите второе число:");
b1 = Console.ReadLine();
b = Convert.ToInt32(b1);

Console.Write("Введите третье число:");
c1 = Console.ReadLine();
c = Convert.ToInt32(c1);

int max = a;

if (b > max)
{
    max = b;
}
else
{
    max = a;
    }
if (c > max)
{
    max = c;
}
Console.WriteLine(max);