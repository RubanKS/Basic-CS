//Задача 36: Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элементов, стоящих на нечётных позициях.

int N;
int sum = 0;
Input(out N);
int[] a = new int[N];
Random random = new Random();
Init(ref a, max:10);
Print();





/*---Input---*/
int Input(out int N)
{
    Console.Write("Введите количество чисел:");
    N = Convert.ToInt32(Console.ReadLine());
    return N;
}

/*---Init---*/
void Init(ref int[] a, int min = 0, int max = 100)
{
    for (int i = 0; i < a.Length; i++)
    {
        a[i] = random.Next(min, max);
        if (i % 2 == 1)
            sum = sum + a[i];
        System.Console.Write($"{a[i],4}");
    }
}

/*---Print---*/
void Print()
{
System.Console.Write($"\n {sum}");
}