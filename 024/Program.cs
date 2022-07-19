// Вывести на экран таблицу квадратов чисел от 1 до N

int N;

Console.Write("Введите число:");
N = Convert.ToInt32(Console.ReadLine());

int a = 1;
double square = 1;

while (a <= N)
{
    square = a * a;
    Console.Write($"{square} ");
    a++;
}