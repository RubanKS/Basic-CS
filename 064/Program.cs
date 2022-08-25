// Задайте значения M и N. Напишите программу,
//которая выведет все натуральные числа в промежутке от M до N.

int M;
int N;
InputM(out M);
InputN(out N);
Print(M,N);



















int InputN(out int N)
{
    Console.WriteLine("Введите число N:");
    N = Convert.ToInt32(Console.ReadLine());
    return N;
}

int InputM(out int M)
{
    Console.WriteLine("Введите число M:");
    M = Convert.ToInt32(Console.ReadLine());
    return M;
}

void Print(int M, int N)
{
    if (M<N)
    {
        for (int i=M; i <= N; i++)
        {
            System.Console.Write($"{i}  ");
        }
    }
    else
    {
        for (int i=N; i <= M; i++)
        {
            System.Console.Write($"{i}  ");
        }        
    }
}