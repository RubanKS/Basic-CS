// Задача 34: Задайте массив заполненный случайными
//положительными трёхзначными числами. Напишите программу,
//которая покажет количество чётных чисел в массиве.

int N;
Input(out N);
int[] a = new int[N];
int count = 0;
Random random = new Random();
Init(ref a);
Print();



/*---Input---*/
int Input(out int N)
{
    Console.Write("Введите количество чисел:");
    N = Convert.ToInt32(Console.ReadLine());
    return N;
}

/*---Init---*/
void Init(ref int[] a)
{
    for (int i = 0; i < a.Length; i++)
    {
        a[i] = random.Next(100, 1000);
        if (a[i] % 2 == 0)
            count = count + 1;
        System.Console.Write($"{a[i],4}");
    }
}
/*---Print---*/
void Print()
{
    System.Console.WriteLine($"\n {count}");
}