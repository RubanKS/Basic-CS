// Задача 38: Задайте массив вещественных чисел.
//Найдите разницу между максимальным и минимальным элементов массива.

int N;
double diff = 0;
Input(out N);
double [] a = new double[N];
Random random = new Random();
Init(ref a, max:10);
double minN = a.Min(), maxN = a.Max();
Result(minN, maxN);
Print();



/*---Input---*/
int Input(out int N)
{
    Console.Write("Введите количество чисел:");
    N = Convert.ToInt32(Console.ReadLine());
    return N;
}

/*---Init---*/
void Init(ref double[] a, int min = 0, int max = 100)
{
    for (int i = 0; i < a.Length; i++)
    {
        a[i] = random.Next(min, max);
        System.Console.Write($"{a[i],5}");
    }
}

/*---Result---*/
double Result(double a, double b)
{
    diff = maxN - minN;
    return diff;
}

/*---Print---*/
void Print()
{
    System.Console.Write($"\n {diff}");
}