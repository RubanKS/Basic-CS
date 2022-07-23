// В Указанном массиве вещественных чисел найдите
//разницу между максимальным и минимальным элементом

Console.Write("Введите количество чисел:");
int N = Convert.ToInt32(Console.ReadLine());

int[] a = new int[N];
Random random = new Random();

int diff = 0;

for (int i = 0; i < a.Length; i++)
{
    a[i] = random.Next(0, 1000000);
    //System.Console.Write($"{a[i],5}\n");
}

int minN = a.Min();//минимальное значение в заданном массиве
int maxN = a.Max();//максимальное значение в заданном массиве

/*
int minN = a[0];
int maxN = a[0];

for (int i = 0; i < a.Length; i++)
{
    if (minN > a[i])
        minN = a[i];
    if (maxN < a[i])
        maxN = a[i];
}
*/

diff = maxN - minN;

// System.Console.WriteLine($"Минимальное значение: {minN}");
// System.Console.WriteLine($"Максимальное значение: {maxN}");
System.Console.WriteLine($"Разница между максимальным и минимальным значениями: {maxN} - {minN} = {diff}");