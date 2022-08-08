//По заданному с клавиатуры номеру дня недели вывести его название
int n;
string? n1;
string a;

/*
String one = "Понедельник";
String two = "Вторник";
String three = "Среда";
String four = "Четверг";
String five = "Пятница";
String six = "Суббота";
String seven = "Воскресенье";
*/

Console.Write("Введите номер дня недели:");
n1 = Console.ReadLine();
n = Convert.ToInt32(n1);
//n = int.Parse(Console.ReadLine()); // Тоже самое, что n = Convert.ToInt32(n1);

/*

int dayOfWeek;//camelCase 
//int DayOfWeek;//PascalCase
//dayOfWeek=Convert.ToInt32(Console.ReadLine());
dayOfWeek=Convert.ToInt32(Console.ReadLine());

switch(dayOfWeek)
{
    case 1:
        System.Console.WriteLine("Monday");
        break;
    case 2:
        System.Console.WriteLine("Tuesday");
        break;
    case 3:
        System.Console.WriteLine("Wednesday");
        break;
    default:
        System.Console.WriteLine("Wrong!");
        break;
}
*/

switch(n)
{
    case 1:
        System.Console.WriteLine("Monday");
        break;
    case 2:
        System.Console.WriteLine("Tuesday");
        break;
    case 3:
        System.Console.WriteLine("Wensday");
        break;
    case 4:
        System.Console.WriteLine("Thusday");   
        break;
    case 5:
        System.Console.WriteLine("Friday");
        break;
    case 6:
        System.Console.WriteLine("Saturday");   
        break;  
    case 7:
        System.Console.WriteLine("Sunday");   
        break;                            
    default:
        System.Console.WriteLine("Wrong!!");
}


if (n == 1)
{
    Console.WriteLine("Понедельник");
}
if (n == 2)
{
    Console.WriteLine("Вторник");
}
if (n == 3)
{
    Console.WriteLine("Среда");
}
if (n == 4)
{
    Console.WriteLine("Четверг");
}
if (n == 5)
{
    Console.WriteLine("Пятница");
}
if (n == 6)
{
    Console.WriteLine("Суббота");
}
if (n == 7)
{
    Console.WriteLine("Воскресенье");
}