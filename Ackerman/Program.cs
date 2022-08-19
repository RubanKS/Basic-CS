// Написать программу вычисления функции Аккермана

int n, m;
InputN(out n);
InputM(out m);
Ackerman(n,m);
Print(n,m);



















int InputN(out int N)
{
    Console.WriteLine("Введите первое число:");
    N = Convert.ToInt32(Console.ReadLine());
    return N;
}

int InputM(out int M)
{
    Console.WriteLine("Введите второе число:");
    M = Convert.ToInt32(Console.ReadLine());
    return M;
}

int Ackerman (int n, int m)
{
    if (n == 0) return m + 1;
    if (n != 0 && m == 0) return Ackerman(n - 1, 1);
    if (n > 0 && m > 0) return Ackerman(n - 1, Ackerman(n, m - 1));
    return Ackerman(n,m);
}

void Print(int n, int m)
{   
    System.Console.WriteLine($"Функция Аккермана = {Ackerman(n,m)}");
}