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