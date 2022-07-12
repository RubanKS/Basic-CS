// Дано число больше 9. Вывести на экран  вторую цифру числа с конца

int n;
int second;

Console.Write("Введите число:");
n = Convert.ToInt32(Console.ReadLine());

while (n > 99)
{
    n = n / 10;
}

second = n % 10;

Console.WriteLine(second);