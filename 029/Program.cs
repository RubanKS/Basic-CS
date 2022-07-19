// Подсчитать сумму цифр в числе

Console.Write("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());

int sum = 0;

while (n > 0)
{
    sum = sum + n % 10;
    n = n / 10;
}

System.Console.WriteLine(sum);