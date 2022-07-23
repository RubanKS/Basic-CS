//Определить, присутствует ли в заданном массиве, некоторое число

Console.Write("Введите число которое хотите найти:");
int j = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество чисел:");
int N = Convert.ToInt32(Console.ReadLine());

int[] a = new int[N];
Random random = new Random();

for (int i = 0; i < a.Length; i++)
{
    a[i] = random.Next(-9, 10);
    //System.Console.Write($"{a[i],5}");
}

for (int i = 0; i < a.Length; i++)
{
    if (a[i] == j)
        System.Console.WriteLine($"Число {j} найдено");
}

/*
int N=3;
int[] a=new int[N];
Random random=new Random();//псевдослучайные числа
for(int i=0;i<a.Length;i++)
{
    a[i]=random.Next(-9,10);
}

int number=400;
a[1]=number;
//Алгоритм линейного поиска
int j=0;
while (j<a.Length && a[j]!=number) j++;
if (j==a.Length) System.Console.WriteLine("No");
else System.Console.WriteLine($"Yes. {j}");;

for(int i=0;i<a.Length;i++)
    System.Console.Write($"{a[i],4}");
    System.Console.WriteLine();
*/