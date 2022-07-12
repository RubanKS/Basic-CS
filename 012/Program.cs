//Дано число из  диапозона  [10, 99]. Показать наибольшую цифру числа

int n;
int max;

Console.Write("Введите число от 10 до 99:");
n = Convert.ToInt32(Console.ReadLine());

max = n % 10;

n = n / 10;

if (n > max)
{
    max = n;
}

Console.WriteLine(max);