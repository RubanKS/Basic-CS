//Вывести на экран числа от -N до N

int N;

Console.Write("Введите число:");
N = Convert.ToInt32(Console.ReadLine());

int a = -N;

while (a <= N)
{
    Console.Write($"{a} ");
    a++;
}