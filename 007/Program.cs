// Выяснить является ли число чётным.

int a;
Console.Write("Введите число:");
a = Convert.ToInt32(Console.ReadLine());

if (a % 2 == 1)
{
    Console.WriteLine("Число нечётное");

}
else
{
    Console.WriteLine("Число чётное");
}