// Дан целочисленный массив.
//Найти среднее арифметическое каждого из столбцов.

int n, m;
InputN(out n);
InputM(out m);
int[,] a = Create2DArray(n, m);
Print(a);
int[] sum = new int[m];
Init(ref sum);
PrintMean(ref sum);









int InputN(out int N)
{
    Console.WriteLine("Введите количетсво строк:");
    N = Convert.ToInt32(Console.ReadLine());
    return N;
}

int InputM(out int M)
{
    Console.WriteLine("Введите количество столбцов:");
    M = Convert.ToInt32(Console.ReadLine());
    return M;
}

int[,] Create2DArray(int n, int m, int min = 0, int max = 10)
{
    int[,] a = new int[n, m];//создаем массив
    Random random = new Random();
    for (int i = 0; i < a.GetLength(0); i++)//перебираем строки
        for (int j = 0; j < a.GetLength(1); j++)//перебираем столбцы
            a[i, j] = random.Next(min, max + 1);
    return a;
}

void Print(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)//перебираем строки
    {
        for (int j = 0; j < a.GetLength(1); j++)//перебираем столбцы
            System.Console.Write($"{a[i, j],4}");
        System.Console.WriteLine();
    }
}

void Init(ref int [] sum)
{
for (int i = 0; i < a.GetLength(0); i++)//перебираем строки
    {
        for (int j = 0; j < a.GetLength(1); j++)//перебираем столбцы
            sum[j] += a[i, j];
    }
}

void PrintMean(ref int[] sum)
{
for (int i=0;i<sum.GetLength(0); i++)
    Console.WriteLine($"Среднее арифметическое {(i+1)} столбца: {sum[i]} / {n} = {sum[i]/n}");
}