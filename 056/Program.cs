// Написать программу, которая обменивает элементы первой строки и последней строки

int n, m;
InputN(out n);
InputM(out m);
int[,] a = Create2DArray(n, m);
Print(a);
Change();
Print(a);









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
    System.Console.WriteLine();
}

void Change()
{
    int j, temp;
    for (j = 0; j < m; j++)
    {
        temp = a[0, j];
        a[0, j] = a[n - 1, j];
        a[n - 1, j] = temp;
    }
}