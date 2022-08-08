//Задать массив из 8 целых элементов и вывести их на экран

//Инициализация переменных
int[] a;

//Ввод данных
Init(out a);

//Обработка данных

//Вывод результатов
Print(a);






/*---Init--------------------------------*/
void Init (out int[] a, int Length = 8, int min = 0, int max = 100)
{
    a = new int[Length];
    Random random = new Random();//псевдослучайные числа
    for (int i = 0; i < a.Length; i++)
        a[i] = random.Next(min, max);
}
/*---Print-------------------------------*/
void Print (int[] a)
{
    for (int i = 0; i < a.Length; i++)
    System.Console.Write($"{a[i],5}");//5 - количество знаков для вывода
}
/*---------------------------------------*/





/*------------------------------------------------
int N = 8;

int[] a = new int[N];// создание нового массива
Random random = new Random();//псевдослучайные числа
for (int i = 0; i < a.Length; i++)
    a[i] = random.Next(0, 10);
for (int i = 0; i < a.Length; i++)
    System.Console.Write($"{a[i],4}");//4 - количество знаков для вывода
System.Console.WriteLine();
*/

/*------------------------------------------------
//Инициализация переменных
int N = 8;

int[] a;// создание нового массива

//Ввод данных
Init(out a,max:100); // max присвоили 100


//Обработка данных




//Вывод результатов

Print(a);



void Init (out int[] a, int Length=10, int min=0, int max=10) //по умолчанию
{
    a=new int[Length];
    Random random = new Random();//псевдослучайные числа
    for (int i = 0; i < a.Length; i++)
        a[i] = random.Next(min, max);
}


void Print(int[] a)
{
    for (int i = 0; i < a.Length; i++)
    System.Console.Write($"{a[i],4}");//4 - количество знаков для вывода
    System.Console.WriteLine();
}
*/