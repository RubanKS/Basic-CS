//Написать программу замены элементов массива на противоположные

Console.Write("Введите количество чисел:");
int N = Convert.ToInt32(Console.ReadLine());

int[] a = new int[N];
Random random = new Random();

for (int i = 0; i < a.Length; i++)
{
    a[i] = random.Next(-9, 10);
    System.Console.Write($"{a[i],5}");
}

System.Console.WriteLine();

for (int i = 0; i < a.Length; i++)
{    
    a[i] = -a[i];
    System.Console.Write($"{a[i],5}");
}