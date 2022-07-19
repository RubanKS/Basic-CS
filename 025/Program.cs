// Вывести на экран кубы чисел от 1 до N

int N;

Console.Write("Введите число:");
N = Convert.ToInt32(Console.ReadLine());

int a = 1;
double cube = 1;

while (a <= N)
{
    cube = a * a * a;
    Console.Write($"{cube} ");
    a++;
}

