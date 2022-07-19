//По двум заданным числам проверять является ли одно квадратом другого. Используйте подпрограмму.

Console.Write("Введите первое число:");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число:");
int b = Convert.ToInt32(Console.ReadLine());

bool Check(int a, int b)
{
    return a*a==b || b*b==a;
}

if (Check(a,b))
{
    System.Console.WriteLine("Является");
}
else
{
    System.Console.WriteLine("Не является");
}

/*
// Описание подпрограммы. Сумма двух чисел
int Sum(int a, double b); //Подпрограмма с БОЛЬШОЙ буквы
{
    //Тело подпрограммы
    return a+b;
}

//ОСНОВНАЯ ПРОГРАММА
int s=Sum(2,2);//Вызов подрограммы
System.Console.WriteLine(Sum(2,4));

//Ничего не возвращает
void Pause()
{
    return; //Недаёт выполнять дальше подпрограмму/программу
    Console.ReadKey();
}

Pause();
*/
