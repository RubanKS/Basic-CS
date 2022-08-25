// Задайте значения M и N.
//Напишите программу, которая найдёт сумму натуральных элементов
//в промежутке от M до N.

int M;
int N;
int sum = 0;
InputM(out M);
InputN(out N);
Summ(M, N);
Print();



















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

void Summ(int M, int N)
{
    if (M < N)
    {
        for (int i = M; i <= N; i++)
        {
            sum=sum+i;
        }
    }
    else
    {
        for (int i = N; i <= M; i++)
        {
            sum=sum+i;
        }
    }
}

void Print()
{
    System.Console.WriteLine(sum);
}