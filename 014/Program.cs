//С клавиатуры вводятся два числа a и b. Выяснить, кратно ли число a числу b, если нет, вывести остаток от деления a на b.

int a;
int b;

Console.Write("Введите первое число:");
a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число:");
b = Convert.ToInt32(Console.ReadLine());

if (a%b==0)
{
    Console.WriteLine("Кратно");
}
else
{
    Console.WriteLine(a%b);
}