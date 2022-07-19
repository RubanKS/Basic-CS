// Написать программу вычисления произведения чисел от 1 до N

Console.Write("Введите число:");
int N = Convert.ToInt32(Console.ReadLine());

int a = 1;
double product = 1;

while (a <= N)
{
    product = product * a;
    a++;
}

Console.Write($"{product}");