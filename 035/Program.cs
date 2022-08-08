//Написать программу замены элементов массива на противоположные

int N =0;
int[] a = new int[N];
Input(out N);
Init (out a, min:-10, max:11);
Print();





/*---Input--------------------------------*/
int Input(out int N)
{
    Console.Write("Введите количество чисел:");
    N = Convert.ToInt32(Console.ReadLine());
    return N;
}

/*---Init--------------------------------*/
void Init (out int[] a, int min = -100, int max = 100)
{
    a = new int[N];
    Random random = new Random();//псевдослучайные числа
    for (int i = 0; i < a.Length; i++)
        a[i] = random.Next(min, max);
}

/*---Print-------------------------------*/
void Print ()
{
    PrintA(a);
    PrintB(a);
}

/*---PrintA-------------------------------*/
void PrintA (int[] a)
{
    for (int i = 0; i < a.Length; i++)
    {
        // a[i] = random.Next(-9, 10);
        System.Console.Write($"{a[i],5}");
    }
    System.Console.WriteLine();
}

/*---PrintB-------------------------------*/
void PrintB (int[] a)
{
    for (int i = 0; i < a.Length; i++)
    {    
        a[i] = -a[i];
        System.Console.Write($"{a[i],5}");
    }
}

