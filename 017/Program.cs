//Дано число обозначающее день недели. Выяснить является номер дня недели выходным

Console.Write("Введите номер дня недели:");
int a = Convert.ToInt32(Console.ReadLine());

switch(a)
{
    case 1:
        System.Console.WriteLine("Понедельник - Не выходной");
        break;
    case 2:
        System.Console.WriteLine("Вторник - Не выходной");
        break;
    case 3:
        System.Console.WriteLine("Среда - Не выходной");
        break;
    case 4:
        System.Console.WriteLine("Четверг - Не выходной");   
        break;
    case 5:
        System.Console.WriteLine("Пятница - Не выходной");
        break;
    case 6:
        System.Console.WriteLine("Суббота - Выходной");   
        break;  
    case 7:
        System.Console.WriteLine("Воскресенье - Выходной");   
        break;                            
    default:
        System.Console.WriteLine("Error");
        break;    
}

// System.Console.WriteLine(a);

/*
Console.Write("Введите номер дня недели:");
int a = Convert.ToInt32(Console.ReadLine());

int DayWeek(int a)
{
    int result;
    if (a == 1) result = 1;
    if (a == 2) result = 1;
    if (a == 3) result = 1;
    if (a == 4) result = 1;
    if (a == 5) result = 1;
    if (a == 6) result = 2;
    if (a == 7) result = 2;
    return result;
}

int result = DayWeek(a);
if (result == 1) System.Console.WriteLine("Не выходной");
if (result == 2) System.Console.WriteLine("Выходной");
else System.Console.WriteLine("Нет такого порядкого номера дня недели");
*/

