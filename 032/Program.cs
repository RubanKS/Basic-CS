//Задать массив из 8 целых элементов и вывести их на экран

int N = 8;

int[] a = new int[N];// создание нового массива
Random random = new Random();//псевдослучайные числа
for (int i = 0; i < a.Length; i++)
    a[i] = random.Next(0, 10);
for (int i = 0; i < a.Length; i++)
    System.Console.Write($"{a[i],4}");//4 - количество знаков для вывода
System.Console.WriteLine();