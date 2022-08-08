// Задать массив, заполнить случайными положительными трёхзначными числами.
// Показать количество нечетных\четных чисел

int countEven = 0;
int countOdd = 0;
int N = 0;

Input(out N);

int[] a = new int[N];
Random random = new Random();

Count(countEven, countOdd);
Print();




/*---Input--------------------------------*/
int Input(out int N)
{
    Console.Write("Введите количество чисел:");
    N = Convert.ToInt32(Console.ReadLine());
    return N;
}

/*---Count--------------------------------*/
int Count(int countE, int countO)
{
    for (int i = 0; i < a.Length; i++)
    {
        a[i] = random.Next(100, 1000);
        // System.Console.Write($"{a[i],5}\n");
        if (a[i] % 2 == 0)
            countEven = countEven + 1;
        else
            countOdd = countOdd + 1;
    }
    return 0;
}

/*---Print-------------------------------*/
void Print()
{
    System.Console.WriteLine($"Всего чётных чисел: {countEven}");
    System.Console.WriteLine($"Всего нечётных чисел: {countOdd}");
}