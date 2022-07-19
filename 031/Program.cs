// Показать кубы чисел, заканчивающихся на четную цифру

Console.Write("Введите число:");
int N = Convert.ToInt32(Console.ReadLine());

int a = 1;
int cube = 0;

while (a <= N)
{
    if (a % 2 == 0)
    {
        cube = a * a * a;
        Console.Write($"{cube} ");
    }
    a++;
}
