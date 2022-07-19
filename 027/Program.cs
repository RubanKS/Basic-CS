// Возведите число А в натуральную степень B используя цикл

Console.Write("Введите число:");
int A = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите степень:");
int d = Convert.ToInt32(Console.ReadLine());

int i = 0;
int result = 1;

while (i < d)
{
    result = result * A;
    i++;
}

System.Console.WriteLine(result);