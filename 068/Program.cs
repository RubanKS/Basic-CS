// Напишите программу вычисления функции Аккермана с помощью рекурсии.
//Даны два неотрицательных числа m и n.

int m, n;
InputM(out m);
InputN(out n);
Ackerman(m,n);
Print(m,n);


















int InputM(out int M)
{
    Console.WriteLine("Введите число M:");
    M = Convert.ToInt32(Console.ReadLine());
    return M;
}

int InputN(out int N)
{
    Console.WriteLine("Введите число N:");
    N = Convert.ToInt32(Console.ReadLine());
    return N;
}

int Ackerman (int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0 && m > 0) return Ackerman(m - 1, 1);
    else return Ackerman(m - 1, Ackerman(m, n - 1));
}

void Print(int m, int n)
{   
    System.Console.WriteLine($"Функция Аккермана = {Ackerman(m,n)}");
}