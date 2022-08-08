//В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int min = 0;
int max = 0;
int count = 0;
int[] a = new int[123];
Random random = new Random();

MinMax(out min, out max);
Init(ref a);
Print();








/*---MinMax--------------------------------*/
int MinMax(out int min,out int max)
{
    Console.Write("Введите минимальное число:");
    min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите максимальное число:");
    max = Convert.ToInt32(Console.ReadLine());
    return 0;
}

/*---Init--------------------------------*/
void Init (ref int[] a)
{
    for (int i = 0; i < 123; i++)
    {
    a[i] = random.Next(min, max);
    if (a[i] > 9 && a[i] < 100)
        count = count + 1;
    }
}

/*---Print-------------------------------*/
void Print()
{
    System.Console.WriteLine($"В отрезке всего элементов: {count}");
}


/*
int count = 0;

int[] a = new int[123];
Random random = new Random();

for (int i = 10; i < 99; i++)
    count = count + 1;

System.Console.WriteLine($"В отрезке всего элементов: {count}");
*/