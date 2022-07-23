// Задать массив, заполнить случайными положительными трёхзначными числами.
// Показать количество нечетных\четных чисел

int countEven = 0;
int countOdd = 0;

Console.Write("Введите количество чисел:");
int N = Convert.ToInt32(Console.ReadLine());

int[] a = new int[N];
Random random = new Random();

for (int i = 0; i < a.Length; i++)
{
    a[i] = random.Next(100, 1000);
    //System.Console.Write($"{a[i],5}\n");
    if (a[i] % 2 == 0)
        countEven = countEven + 1;
    else
        countOdd = countOdd + 1;
}

System.Console.WriteLine($"Всего чётных чисел: {countEven}");
System.Console.WriteLine($"Всего нечётных чисел: {countOdd}");