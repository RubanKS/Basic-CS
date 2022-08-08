//Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

int[] a;
InitPrint (out a);



/*---InitPrint--------------------------------*/
void InitPrint (out int[] a, int Length = 8, int min = 0, int max = 2)
{
    a = new int[Length];
    Random random = new Random();
    for (int i = 0; i < a.Length; i++)
    {
        a[i] = random.Next(min, max);
        System.Console.Write($"{a[i],4}");
    }
}